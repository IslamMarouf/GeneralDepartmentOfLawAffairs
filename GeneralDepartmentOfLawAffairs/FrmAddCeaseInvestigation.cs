
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmAddCeaseInvestigation : GeneralForm
    {
        private string gDeptsConString = "SELECT * FROM tblDepartments";
        private readonly OleDbDataAdapter _gDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _gDeptsOdbCommand = new OleDbCommand();
        private readonly DataSet _gDeptsDs = new DataSet();

        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        private string ceaseDays = string.Empty;

        public FrmAddCeaseInvestigation()
        {
            InitializeComponent();

            _gDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _gDeptsOdbCommand.CommandType = CommandType.Text;
            _gDeptsOdbCommand.CommandText = gDeptsConString;
            _gDepartmentsDataAdapter.SelectCommand = _gDeptsOdbCommand;
            _gDepartmentsDataAdapter.Fill(_gDeptsDs, "tblDepartments");           
        }     

        private void FrmAddCeaseInvestigation_Load(object sender, EventArgs e)
        {
            var gDepts = from gd in _gDeptsDs.Tables["tblDepartments"].AsEnumerable()
                select gd;

            foreach (var gDept in gDepts)
            {
                cmbxDepartments.Items.Add(gDept.Field<string>("Dept_name"));
            }

            cmbxDepartments.SelectedIndex = 0;
            dtpAssignmentDate.Value = DateTime.Now;
            dTPickerIncomDate.Value = DateTime.Now;
            dtPkrInvestigationYear.Value = DateTime.Now;
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
                               " Subject_investigationType," +
                               " Subject_assignmentDept," +
                               " Subject_assignmentLetterDate," +
                               " Subject_assignmentLetterNum," +
                               " Subject_guiltyName," +
                               " Subject_ceaseDays," +
                               " Subject_ceaseMonths) " +
                               
                               "VALUES (" +
                               "@Subject_type," +
                               " @Subject_num," +
                               " @Subject_year," +
                               " @Subject_about," +
                               " @Subject_assignmentDate," +
                               " @Subject_investigationType," +
                               " @Subject_assignmentDept," +
                               " @Subject_assignmentLetterDate," +
                               " @Subject_assignmentLetterNum," +
                               " @Subject_guiltyName," +
                               " @Subject_ceaseDays," +
                               " @Subject_ceaseMonths)";

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = cmdString;
            _subjectsDataAdapter.InsertCommand = _subjectsOdbCommand;

            _subjectsOdbCommand.Parameters.Add("@Subject_type", OleDbType.Char).Value = LetterSentences.Investigation;
            _subjectsOdbCommand.Parameters.Add("@Subject_num", OleDbType.Char).Value = mtxtInvestigationNum.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_year", OleDbType.Char).Value = dtPkrInvestigationYear.Value.Year.ToString();
            _subjectsOdbCommand.Parameters.Add("@Subject_about", OleDbType.Char).Value = LetterSentences.Cease + " " + txtGuiltyName.Text + " " + LetterSentences.CeaseNote23 + cmbxDepartments.Text + " " + LetterSentences.CeaseNote27 + " " + ceaseDays + " " + LetterSentences.CeaseNote8;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDate", OleDbType.Date).Value = dtpAssignmentDate.Value.Date;
            _subjectsOdbCommand.Parameters.Add("@Subject_investigationType", OleDbType.Char).Value = LetterSentences.Cease;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDept", OleDbType.Char).Value = cmbxDepartments.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterDate", OleDbType.DBDate).Value = dTPickerIncomDate.Value.Date;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterNum", OleDbType.Char).Value = mtxtAssignmentLetter.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_guiltyName", OleDbType.Char).Value = txtGuiltyName.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_ceaseDays", OleDbType.Char).Value = "";
            _subjectsOdbCommand.Parameters.Add("@Subject_ceaseMonths", OleDbType.Char).Value = "";

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();

            
            intInsert = _subjectsOdbCommand.ExecuteNonQuery();
            if (intInsert == 0)
            {
                MessageBox.Show("The Data insertion is failed");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dTPickerIncomDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddCeaseInvestigation_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _gDepartmentsDataAdapter?.Dispose();
            _gDeptsOdbCommand?.Dispose();
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }

        private void btnCeaseDays_Click(object sender, EventArgs e)
        {

        }
    }
}
