using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Filtering.Templates.DateTimeRange;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmAddLetter : XFrmGeneralForm
    {
        private readonly OleDbDataAdapter _lettersDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _lettersOdbCommand = new OleDbCommand();

        public XFrmAddLetter()
        {
            InitializeComponent();
        }

        private void XFrmAddLetter_Load(object sender, EventArgs e) {
            vpAddLetter.Validate();
            deLetterDate.EditValue = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpAddLetter.Validate())
                return;

            int insertValue = 0;
            string cmdString = "INSERT INTO tblLetters (" +
                               "letter_id," +
                               " letter_num, " +
                               " letter_type," +
                               " letter_date," +
                               " letter_subject," +
                               " letter_lastProcedureName," +
                               " letter_lastProcedureDate) " +
                               "VALUES (" +
                               "@letter_id," +
                               " @letter_num," +
                               " @letter_type," +
                               " @letter_year," +
                               " @letter_subject," +
                               " @letter_lastProcedureName," +
                               " @letter_lastProcedureDate)";

            _lettersOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _lettersOdbCommand.CommandType = CommandType.Text;
            _lettersOdbCommand.CommandText = cmdString;
            _lettersDataAdapter.InsertCommand = _lettersOdbCommand;

            _lettersOdbCommand.Parameters.Add("@letter_id", OleDbType.Char).Value = "LETTER" + "-" + txtLetterNumber.Text + "-" + deLetterDate.DateTime.Year;
            _lettersOdbCommand.Parameters.Add("@letter_num", OleDbType.Char).Value = txtLetterNumber.Text;
            _lettersOdbCommand.Parameters.Add("@letter_type", OleDbType.Char).Value = "";
            _lettersOdbCommand.Parameters.Add("@letter_date", OleDbType.DBDate).Value = deLetterDate.EditValue;
            _lettersOdbCommand.Parameters.Add("@letter_subject", OleDbType.Char).Value = txtAbout.Text;
            _lettersOdbCommand.Parameters.Add("@letter_lastProcedureName", OleDbType.Char).Value = LetterSentences.Add;
            _lettersOdbCommand.Parameters.Add("@letter_lastProcedureDate", OleDbType.DBDate).Value = DateTime.Today;

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();

            insertValue = _lettersOdbCommand.ExecuteNonQuery();
            if (insertValue == 0)
            {
                XtraMessageBox.Show("The Data insertion is failed");
            }

            DialogResult = DialogResult.OK;
        }

        private void deLetterDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void deLetterDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XFrmAddLetter_FormClosing(object sender, FormClosingEventArgs e)
        {
            _lettersDataAdapter?.Dispose();
            _lettersOdbCommand?.Dispose();
        }

        private void txtLetterNumber_EditValueChanged(object sender, EventArgs e) {
            vpAddLetter.Validate();
        }

        private void txtAbout_EditValueChanged(object sender, EventArgs e) {
            vpAddLetter.Validate();
        }
    }
}