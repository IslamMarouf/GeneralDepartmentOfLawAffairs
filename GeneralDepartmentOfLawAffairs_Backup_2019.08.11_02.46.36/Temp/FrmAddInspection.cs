using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmAddInspection : GeneralForm
    {
        private string cDeptsConString = "SELECT * FROM tblCentralDepartments";
        private readonly OleDbDataAdapter _cDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _cDeptsOdbCommand = new OleDbCommand();

        readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        private readonly DataSet _cDeptsDs = new DataSet();


        public FrmAddInspection()
        {
            InitializeComponent();

            _cDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _cDeptsOdbCommand.CommandType = CommandType.Text;
            _cDeptsOdbCommand.CommandText = cDeptsConString;
            _cDepartmentsDataAdapter.SelectCommand = _cDeptsOdbCommand;
            _cDepartmentsDataAdapter.Fill(_cDeptsDs, "tblCentralDepartments");
        }

        private void FrmAddInspection_Load(object sender, EventArgs e)
        {
            var cDepts = from cdpt in _cDeptsDs.Tables["tblCentralDepartments"].AsEnumerable()
                select cdpt;

            foreach (var cDept in cDepts)
            {
                cmbxDepartments.Items.Add(cDept.Field<string>("centralDepts_name"));
            }

            cmbxDepartments.SelectedIndex = 0;
            dtpAssignmentDate.Value = DateTime.Now;
            dTPickerIncomDate.Value = DateTime.Now;
            dtPkrInspectionYear.Value = DateTime.Now;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int intInsert = 0;
            string cmdString = "INSERT INTO tblSubjects (" +
                               "Subject_type," +
                               " Subject_num," +
                               " Subject_year," +
                               " Subject_about," +
                               " Subject_assignmentDate," +
                               " Subject_assignmentDept," +
                               " Subject_assignmentLetterDate," +
                               " Subject_assignmentLetterNum) " +

                               "VALUES (" +
                               "@Subject_type," +
                               " @Subject_num," +
                               " @Subject_year," +
                               " @Subject_about," +
                               " @Subject_assignmentDate," +
                               " @Subject_assignmentDept," +
                               " @Subject_assignmentLetterDate," +
                               " @Subject_assignmentLetterNum)";

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = cmdString;
            _subjectsDataAdapter.InsertCommand = _subjectsOdbCommand;

            _subjectsOdbCommand.Parameters.Add("@Subject_type", OleDbType.Char).Value = LetterSentences.Inspection;
            _subjectsOdbCommand.Parameters.Add("@Subject_num", OleDbType.Char).Value = mtxtInspectionNum.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_year", OleDbType.Char).Value = dtPkrInspectionYear.Value.Year.ToString();
            _subjectsOdbCommand.Parameters.Add("@Subject_about", OleDbType.Char).Value = txtAbout.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDate", OleDbType.Date).Value = dtpAssignmentDate.Value.Date;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDept", OleDbType.Char).Value = cmbxDepartments.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterDate", OleDbType.DBDate).Value = dTPickerIncomDate.Value.Date;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterNum", OleDbType.Char).Value = mtxtAssignmentLetter.Text;

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();

            intInsert = _subjectsOdbCommand.ExecuteNonQuery();
            if (intInsert == 0)
            {
                MessageBox.Show("The Data insertion is failed");
            }
        }
    }
}
