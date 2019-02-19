using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmCeaseNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }

        public bool FormHasDraftResolution { get; set; }

        public LetterData FrmLetterData { get; set; }

        /*
            In LINQ to Object method, we must first build a DataSet and fill it with
            our Subjects data table. The reason for that is because there is no direct
            relationship between the LINQ and the Microsoft Access database, but we
            can set up an indirect relationship between them using the LINQ to ADO.NET
            since ADO.NET covers any kinds of database including the Microsoft Access
            20016. In order to set up this relationship, a DataSet must be built by
            filling it with the desired data table such as Subjects in this case.
            One point to note is that this DataSet is a nontyped DataSet if it is 
            built in this way, and you must use the field location, not field name,
            to identify each column in the data table.
        */

        private string cDeptsConString = "SELECT * FROM tblCentralDepartments";
        private readonly OleDbDataAdapter _cDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _cDeptsOdbCommand = new OleDbCommand();


        private string gDeptsConString = "SELECT * FROM tblDepartments";
        private readonly OleDbDataAdapter _gDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _gDeptsOdbCommand = new OleDbCommand();

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        /*
           The DataSet is used to query data using the LINQ to DataSet method since
           there is no direct way to connect LINQ to the Microsoft Access database.
         */
        private readonly DataSet _cDeptsDs = new DataSet();
        private readonly DataTable _cDeptsDt = new DataTable();
        private readonly DataSet _gDeptsDs = new DataSet();
        private readonly DataSet _subjectsDs = new DataSet();


        public FrmCeaseNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
            FormHasDraftResolution = false;

            /*
             * Globals.ThisAddIn.SubjectsConnection used to access and get the original
             * Connection object in the add-in and we need to use that connection here.
             * The Command instance is initialized with the Connection object that is
             * created in the ThisAddIn_Startup event.
             */
            _cDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _cDeptsOdbCommand.CommandType = CommandType.Text;
            _cDeptsOdbCommand.CommandText = cDeptsConString;
            _cDepartmentsDataAdapter.SelectCommand = _cDeptsOdbCommand;
            _cDepartmentsDataAdapter.Fill(_cDeptsDs, "tblCentralDepartments");

            _gDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _gDeptsOdbCommand.CommandType = CommandType.Text;
            _gDeptsOdbCommand.CommandText = gDeptsConString;
            _gDepartmentsDataAdapter.SelectCommand = _gDeptsOdbCommand;
            _gDepartmentsDataAdapter.Fill(_gDeptsDs, "tblDepartments");

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = _subjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chbxDraftRes.Checked)
            {
                FrmLetterData.HasDraftResolution = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var investigationInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInvestigationNum.SelectedItem.ToString())
                select sb;

            foreach (var investInfoRow in investigationInfo)
            {
                FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text;
                FrmLetterData.InvYear = investInfoRow.Field<string>("subject_year");
                txtYear.Text = LetterSentences.ForYear + " " + FrmLetterData.InvYear;
                FrmLetterData.Subject = investInfoRow.Field<string>("subject_about");
                txtSubject.Text = FrmLetterData.Subject;
            }
        }

        private void FrmCeaseNote_Load(object sender, EventArgs e)
        {
            chbxDraftRes.Checked = true;

            var cDepts = from cdpt in _cDeptsDs.Tables["tblCentralDepartments"].AsEnumerable()
                select cdpt;

            foreach (var cDept in cDepts)
            {
                cmbCDept.Items.Add(cDept.Field<string>("centralDepts_name"));
            }

            var gDepts = from gd in _gDeptsDs.Tables["tblDepartments"].AsEnumerable()
                select gd;

            foreach (var gdept in gDepts)
            {
                cmbxDepartments.Items.Add(gdept.Field<string>("Dept_name"));
            }

            var investigations = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                select sb;

            foreach (var investigation in investigations)
            {
                cmbxInvestigationNum.Items.Add(investigation.Field<string>("subject_num"));
            }


            cmbxDepartments.SelectedIndex = 0;
        }

        private void FrmCeaseNote_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _cDepartmentsDataAdapter?.Dispose();
            _cDeptsOdbCommand?.Dispose();
            _cDeptsDt?.Dispose();
            _gDepartmentsDataAdapter?.Dispose();
            _gDeptsOdbCommand?.Dispose();
        }

        private void cmbxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "SELECT tblCentralDepartments.centralDepts_name, " +
                               "tblCentralDepartments.centralDepts_headName " +
                               "FROM tblCentralDepartments " +
                               "INNER JOIN tblDepartments " +
                               "ON tblCentralDepartments.[cDept_id] = tblDepartments.[cDept_id] " +
                               "WHERE (((tblDepartments.dept_name)=\"" + cmbxDepartments.Text + "\"));";

            _cDeptsOdbCommand.CommandText = conString;
            _cDepartmentsDataAdapter.SelectCommand = _cDeptsOdbCommand;
            _cDepartmentsDataAdapter.Fill(_cDeptsDt);

            if (_cDeptsDt.Rows.Count > 0)
            {
                foreach (DataRow row in _cDeptsDt.Rows)
                {
                    cmbCDept.Text = row["centralDepts_name"].ToString();
                    FrmLetterData.HeadName = row["centralDepts_headName"].ToString();
                }

                FrmLetterData.CDptName = cmbCDept.Text;
            }
            else
            {
                MessageBox.Show("No Match Departments Found!");
            }

            FrmLetterData.DepartmentName = cmbxDepartments.Text;
        }
    }
}