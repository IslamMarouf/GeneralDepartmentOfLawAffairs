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
    public partial class XFrmAddInspection : DevExpress.XtraEditors.XtraForm
    {
        private string cDeptsConString = "SELECT * FROM tblCentralDepartments";
        private readonly OleDbDataAdapter _cDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _cDeptsOdbCommand = new OleDbCommand();

        readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        private readonly DataSet _cDeptsDs = new DataSet();

        public XFrmAddInspection()
        {
            InitializeComponent();

            _cDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _cDeptsOdbCommand.CommandType = CommandType.Text;
            _cDeptsOdbCommand.CommandText = cDeptsConString;
            _cDepartmentsDataAdapter.SelectCommand = _cDeptsOdbCommand;
            _cDepartmentsDataAdapter.Fill(_cDeptsDs, "tblCentralDepartments");
        }

        private void XFrmAddInspection_Load(object sender, EventArgs e) {
            dflAddInspection.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            var cDepts = from cdpt in _cDeptsDs.Tables["tblCentralDepartments"].AsEnumerable()
                select cdpt;

            foreach (var cDept in cDepts)
            {
                cmbxDepartments.Properties.Items.Add(cDept.Field<string>("centralDepts_name"));
            }

            cmbxDepartments.SelectedIndex = 0;
            dtpAssignmentDate.EditValue = DateTime.Today;
            dTPickerIncomDate.EditValue = DateTime.Today;
            dtPkrInspectionYear.EditValue = DateTime.Today;

            vpAddInspection.Validate();
        }

        private void mtxtInspectionNum_EditValueChanged(object sender, EventArgs e) {
            vpAddInspection.Validate();
        }

        private void mtxtAssignmentLetter_EditValueChanged(object sender, EventArgs e) {
            vpAddInspection.Validate();
        }

        private void txtAbout_EditValueChanged(object sender, EventArgs e) {
            vpAddInspection.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!vpAddInspection.Validate())
                return;

            int intInsert = 0;
            string cmdString = "INSERT INTO tblSubjects (" +
                               "Subject_id," +
                               " Subject_type," +
                               " Subject_num," +
                               " Subject_year," +
                               " Subject_about," +
                               " Subject_assignmentDate," +
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
                               " @Subject_assignmentDept," +
                               " @Subject_assignmentLetterDate," +
                               " @Subject_assignmentLetterNum," +
                               " @Subject_procedureName," +
                               " @Subject_procedureDate)";

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = cmdString;
            _subjectsDataAdapter.InsertCommand = _subjectsOdbCommand;

            _subjectsOdbCommand.Parameters.Add("@Subject_id", OleDbType.Char).Value = $"INS-{mtxtInspectionNum.Text}-{dtPkrInspectionYear.DateTime.Year.ToString()}";
            _subjectsOdbCommand.Parameters.Add("@Subject_type", OleDbType.Char).Value = LetterSentences.Inspection;
            _subjectsOdbCommand.Parameters.Add("@Subject_num", OleDbType.Char).Value = mtxtInspectionNum.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_year", OleDbType.Char).Value = dtPkrInspectionYear.DateTime.Year.ToString();
            _subjectsOdbCommand.Parameters.Add("@Subject_about", OleDbType.Char).Value = txtAbout.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDate", OleDbType.Date).Value = dtpAssignmentDate.DateTime;
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

        private void dtpAssignmentDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_5, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtpAssignmentDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dTPickerIncomDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dTPickerIncomDate_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XFrmAddInspection_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cDepartmentsDataAdapter?.Dispose();
            _cDeptsOdbCommand?.Dispose();
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }
    }
}