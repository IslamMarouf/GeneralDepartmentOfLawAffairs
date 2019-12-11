using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI {
    public partial class XFrmAddCase : DevExpress.XtraEditors.XtraForm {
        private readonly OleDbDataAdapter _casesDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _casesOdbCommand = new OleDbCommand();

        private const string ApConStr = "SELECT * FROM tblAdministrativeProsecution";
        private readonly OleDbDataAdapter _apDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _apOdbCommand = new OleDbCommand();
        private readonly DataSet _apDs = new DataSet();

        public XFrmAddCase() {
            InitializeComponent();

            _apOdbCommand.Connection = Globals.ThisAddIn.ApAddressesConnection;
            _apOdbCommand.CommandType = CommandType.Text;
            _apOdbCommand.CommandText = ApConStr;
            _apDataAdapter.SelectCommand = _apOdbCommand;
            _apDataAdapter.Fill(_apDs, "tblAdministrativeProsecution");
        }

        private void XFrmAddCase_Load(object sender, EventArgs e) {
            dflAddCase.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
            vpAddCase.Validate();

            var ap = from a in _apDs.Tables["tblAdministrativeProsecution"].AsEnumerable()
                select a;

            foreach (var a in ap) {
                cmbxAPList.Properties.Items.Add(a.Field<string>("name"));
            }

            //DateTime date = new DateTime((int)seCaseYear.Value, 1, 1);

            dpAPLetter.DateTime = DateTime.Today;
            seCaseYear.Value = DateTime.Today.Year;
            seCaseResYear.Value = DateTime.Today.Year;
            cmbxAPList.SelectedIndex = 0;

        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!vpAddCase.Validate())
                return;

            int insertValue = 0;
            string cmdString = "INSERT INTO tblCases (" +
                               "case_id," +
                               " case_num," +
                               " case_year," +
                               " case_ap," +
                               " case_apLetterNum," +
                               " case_apLetterDate," +
                               " case_about," +
                               " case_guiltyName," +
                               " case_resolutionNum," +
                               " case_resolutionYear," +
                               " case_lastProcedureName," +
                               " case_lastProcedureDate) " +
                               "VALUES (" +
                               "@case_id," +
                               " @case_num," +
                               " @case_year," +
                               " @case_ap," +
                               " @case_apLetterNum," +
                               " @case_apLetterDate," +
                               " @case_about," +
                               " @case_guiltyName," +
                               " @case_resolutionNum," +
                               " @case_resolutionYear," +
                               " @case_lastProcedureName," +
                               " @case_lastProcedureDate)";

            _casesOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _casesOdbCommand.CommandType = CommandType.Text;
            _casesOdbCommand.CommandText = cmdString;
            _casesDataAdapter.InsertCommand = _casesOdbCommand;

            _casesOdbCommand.Parameters.Add("@case_id", OleDbType.Char).Value = "CASE" + "-" + txtCaseNumber.Text + "-" + seCaseYear.Value + "-" + txtAPLetterNumber.Text;
            _casesOdbCommand.Parameters.Add("@case_num", OleDbType.Char).Value = txtCaseNumber.Text;
            _casesOdbCommand.Parameters.Add("@case_year", OleDbType.Integer).Value = seCaseYear.Value;
            _casesOdbCommand.Parameters.Add("@case_ap", OleDbType.Char).Value = cmbxAPList.Text;
            _casesOdbCommand.Parameters.Add("@case_apLetterNum", OleDbType.Char).Value = txtAPLetterNumber.Text;
            _casesOdbCommand.Parameters.Add("@case_apLetterDate", OleDbType.DBDate).Value = dpAPLetter.DateTime;
            _casesOdbCommand.Parameters.Add("@case_about", OleDbType.Char).Value = txtAbout.Text;
            _casesOdbCommand.Parameters.Add("@case_guiltyName", OleDbType.Char).Value = txtGuilty.Text;
            _casesOdbCommand.Parameters.Add("@case_resolutionNum", OleDbType.Char).Value = txtCaseResNumber.Text;
            _casesOdbCommand.Parameters.Add("@case_resolutionYear", OleDbType.Integer).Value = seCaseResYear.Value;
            _casesOdbCommand.Parameters.Add("@case_lastProcedureName", OleDbType.Char).Value = LetterSentences.Add;
            _casesOdbCommand.Parameters.Add("@case_lastProcedureDate", OleDbType.DBDate).Value = DateTime.Today;

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();
            
            insertValue = _casesOdbCommand.ExecuteNonQuery();
            if (insertValue == 0)
            {
                XtraMessageBox.Show("The Data insertion is failed");
            }

            DialogResult = DialogResult.OK;
        }

        private void txtCaseNumber_EditValueChanged(object sender, EventArgs e) {
            vpAddCase.Validate();
        }

        private void txtAPLetterNumber_EditValueChanged(object sender, EventArgs e) {
            vpAddCase.Validate();
        }

        private void txtCaseResNumber_EditValueChanged(object sender, EventArgs e) {
            vpAddCase.Validate();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void XFrmAddCase_FormClosing(object sender, FormClosingEventArgs e)
        {
            _apDataAdapter?.Dispose();
            _apOdbCommand?.Dispose();
            _apDs?.Dispose();
            _casesDataAdapter?.Dispose();
            _casesOdbCommand?.Dispose();
        }

        private void dpAPLetter_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dpAPLetter_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}