using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmRescriptSentLetter : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; set; }
        private const string CasesConStr = "SELECT * FROM tblCases";
        private readonly OleDbDataAdapter _casesDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _casesOdbCommand = new OleDbCommand();
        private readonly DataSet _casesDs = new DataSet();

        public XFrmRescriptSentLetter()  
        {
            InitializeComponent();

            FrmLetterData = new LetterData();
            _casesOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _casesOdbCommand.CommandType = CommandType.Text;
            _casesOdbCommand.CommandText = CasesConStr;
            _casesDataAdapter.SelectCommand = _casesOdbCommand;
            _casesDataAdapter.Fill(_casesDs, "tblCases");
        }

        private void XFrmRescriptSentLetter_Load(object sender, EventArgs e) {
            dflRescriptSentLetter.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            if (FrmLetterData.CaseId.Equals("")) {
                var cases = from cs in _casesDs.Tables["tblCases"].AsEnumerable()
                    select cs;
                foreach (var item in cases) {
                    cbxCaseNum.Properties.Items.Add(item.Field<string>("case_num"));
                }
            }
            else {
                var cases = from cs in _casesDs.Tables["tblCases"].AsEnumerable()
                    where cs.Field<string>("case_id").Equals(FrmLetterData.CaseId)
                    select cs;
                foreach (var item in cases) {
                    cbxCaseNum.Properties.Items.Add(item.Field<string>("case_num"));
                }
            }

            txtAttachmentsCount.Text = "1";

            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;

            cbxCaseNum.SelectedIndex = 0;
            deRescriptDate.EditValue = DateTime.Today;

            vpRescriptSentLetter.Validate();
        }

        private void cbxCaseNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cases = from c in _casesDs.Tables["tblCases"].AsEnumerable()
                where c.Field<string>("case_num").Equals(cbxCaseNum.Text)
                select c;

            foreach (var caseRow in cases) {
                
                txtCaseYear.Text = caseRow.Field<int>("case_year").ToString();
                txtAP.Text = caseRow.Field<string>("case_ap");
                txtAPLetterNumber.Text = caseRow.Field<string>("case_apLetterNum");
                dpAPLetter.EditValue = caseRow.Field<DateTime?>("case_apLetterDate");
                txtCaseResNumber.Text = caseRow.Field<string>("case_resolutionNum");
                txtCaseResYear.Text = caseRow.Field<int>("case_resolutionYear").ToString();
                txtGuilty.Text = caseRow.Field<string>("case_guiltyName");
                txtAbout.Text = caseRow.Field<string>("case_about");
            }
        }

        private void txtRescriptNum_EditValueChanged(object sender, EventArgs e) {
            vpRescriptSentLetter.Validate();
        }

        private void txtAttachmentsCount_EditValueChanged(object sender, EventArgs e) {
            vpRescriptSentLetter.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!vpRescriptSentLetter.Validate())
                return;

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.ApLetterNum = txtAPLetterNumber.Text;
            FrmLetterData.ApLetterDate = dpAPLetter.DateTime.ToShortDateString();
            FrmLetterData.DecisionNumber = txtCaseResNumber.Text;
            FrmLetterData.CaseNumber = cbxCaseNum.Text;
            FrmLetterData.CaseYear = txtCaseYear.Text;
            FrmLetterData.Guilty = txtGuilty.Text;

            FrmLetterData.ApVal = txtAP.Text;

            FrmLetterData.RescriptNum = txtRescriptNum.Text;
            FrmLetterData.RescriptDate = deRescriptDate.DateTime.ToShortDateString();

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;

            string strUpdate = "UPDATE tblCases SET case_lastProcedureName =" +
                               $" \"{LetterSentences.APResSent}\"," +
                               " case_lastProcedureDate =" +
                               $" #{DateTime.Today.ToShortDateString()}#," +
                               $" case_resolutionSent = Yes" +
                               $"\r\nWHERE case_num =\"{cbxCaseNum.Text}\"" +
                               $" AND case_year = {txtCaseYear.Text}";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        MessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}