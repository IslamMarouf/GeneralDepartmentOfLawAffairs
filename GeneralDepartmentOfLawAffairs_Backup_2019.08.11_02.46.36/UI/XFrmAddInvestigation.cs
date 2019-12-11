using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmAddInvestigation : DevExpress.XtraEditors.XtraForm
    {
        private string gDeptsConString = "SELECT * FROM tblDepartments";
        private readonly OleDbDataAdapter _gDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _gDeptsOdbCommand = new OleDbCommand();
        private readonly DataSet _gDeptsDs = new DataSet();

        readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        public XFrmAddInvestigation()
        {
            InitializeComponent();

            _gDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _gDeptsOdbCommand.CommandType = CommandType.Text;
            _gDeptsOdbCommand.CommandText = gDeptsConString;
            _gDepartmentsDataAdapter.SelectCommand = _gDeptsOdbCommand;
            _gDepartmentsDataAdapter.Fill(_gDeptsDs, "tblDepartments");
        }

        private void XFrmAddInvestigation_Load(object sender, EventArgs e) {
            dflAddInvestigation.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            var gDepts = from gd in _gDeptsDs.Tables["tblDepartments"].AsEnumerable()
                select gd;

            foreach (var gdept in gDepts)
            {
                cmbxDepartments.Properties.Items.Add(gdept.Field<string>("Dept_name"));
            }

            cmbxDepartments.SelectedIndex = 0;
            dtpAssignmentDate.EditValue = DateTime.Today;
            dTPickerIncomDate.EditValue = DateTime.Today;
            dtPkrInvestigationYear.EditValue = DateTime.Today;

            vpAddInvestigation.Validate();
        }

        private void mtxtInvestigationNum_EditValueChanged(object sender, EventArgs e) {
            vpAddInvestigation.Validate();
        }

        private void mtxtAssignmentLetter_EditValueChanged(object sender, EventArgs e) {
            vpAddInvestigation.Validate();
        }

        private void txtAbout_EditValueChanged(object sender, EventArgs e) {
            vpAddInvestigation.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!vpAddInvestigation.Validate())
                return;

            int intInsert = 0;
            string cmdString = "INSERT INTO tblSubjects (" +
                               "Subject_id," +
                               " Subject_type," +
                               " Subject_num," +
                               " Subject_year," +
                               " Subject_about," +
                               " Subject_assignmentDate," +
                               " Subject_investigationType," +
                               " Subject_assignmentDept," +
                               " Subject_assignmentLetterDate," +
                               " Subject_assignmentLetterNum," +
                               " Subject_procedureName," +
                               " Subject_procedureDate) " +

                               "VALUES (" +
                               "@Subject_id," +
                               " @Subject_type," +
                               " @Subject_num," +
                               " @Subject_year," +
                               " @Subject_about," +
                               " @Subject_assignmentDate," +
                               " @Subject_investigationType," +
                               " @Subject_assignmentDept," +
                               " @Subject_assignmentLetterDate," +
                               " @Subject_assignmentLetterNum," +
                               " @Subject_procedureName," +
                               " @Subject_procedureDate)";

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = cmdString;
            _subjectsDataAdapter.InsertCommand = _subjectsOdbCommand;

            _subjectsOdbCommand.Parameters.Add("@Subject_id", OleDbType.Char).Value = $"INV-{mtxtInvestigationNum.Text}-{dtPkrInvestigationYear.DateTime.Year.ToString()}";
            _subjectsOdbCommand.Parameters.Add("@Subject_type", OleDbType.Char).Value = LetterSentences.Investigation;
            _subjectsOdbCommand.Parameters.Add("@Subject_num", OleDbType.Char).Value = mtxtInvestigationNum.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_year", OleDbType.Char).Value = dtPkrInvestigationYear.DateTime.Year.ToString();
            _subjectsOdbCommand.Parameters.Add("@Subject_about", OleDbType.Char).Value = txtAbout.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDate", OleDbType.Date).Value = dtpAssignmentDate.DateTime;
            _subjectsOdbCommand.Parameters.Add("@Subject_investigationType", OleDbType.Char).Value = LetterSentences.Investigation;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDept", OleDbType.Char).Value = cmbxDepartments.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterDate", OleDbType.DBDate).Value = dTPickerIncomDate.DateTime;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterNum", OleDbType.Char).Value = mtxtAssignmentLetter.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_procedureName", OleDbType.Char).Value = LetterSentences.Add;
            _subjectsOdbCommand.Parameters.Add("@Subject_procedureDate", OleDbType.DBDate).Value = DateTime.Today;

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();

            intInsert = _subjectsOdbCommand.ExecuteNonQuery();
            if (intInsert == 0)
            {
                XtraMessageBox.Show("The Data insertion is failed");
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void dtPkrInvestigationYear_Validating(object sender, CancelEventArgs e)
        {
            //..........
        }

        private void dtPkrInvestigationYear_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            //..........
        }

        private void dtpAssignmentDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dtpAssignmentDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_5, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dTPickerIncomDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dTPickerIncomDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XFrmAddInvestigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gDepartmentsDataAdapter?.Dispose();
            _gDeptsOdbCommand?.Dispose();
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }
    }
}