using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmIssuanceRescriptLetter : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; }
        private const string CasesConStr = "SELECT * FROM tblCases";
        private readonly OleDbDataAdapter _casesDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _casesOdbCommand = new OleDbCommand();
        private readonly DataSet _casesDs = new DataSet();

        public XFrmIssuanceRescriptLetter()
        {
            InitializeComponent();

            FrmLetterData = new LetterData();
            _casesOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _casesOdbCommand.CommandType = CommandType.Text;
            _casesOdbCommand.CommandText = CasesConStr;
            _casesDataAdapter.SelectCommand = _casesOdbCommand;
            _casesDataAdapter.Fill(_casesDs, "tblCases");
        }

        private void XFrmIssuanceRescriptLetter_Load(object sender, EventArgs e) {
            dflIssuanceRescriptLetter.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

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

            cbxCaseNum.SelectedIndex = 0;
            direction1.cmbxMrMrs.Enabled = false;
            direction1.cmbxRecipient.SelectedIndex = 3;
            direction1.cmbxRecipient.Enabled = false;

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;
            ctrlDirection.cmbxRecipientDeptName.SelectedIndex = 1;
            cmbxCompetentAuthority.SelectedIndex = 1;
            cmbxArticlesNum.SelectedIndex = 2;
        }

        private void cbxCaseNum_SelectedIndexChanged(object sender, EventArgs e) {
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

        private void btnOK_Click(object sender, EventArgs e) {
            
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

            FrmLetterData.RecMrMsVal = direction1.MrMrsVal;
            FrmLetterData.SentPhotoCopyReceiver = direction1.RecipientVal;
            FrmLetterData.SentPhotoCopyReceiverDptName = direction1.DeptNameVal;
            FrmLetterData.SentPhotoCopyApNames = direction1.ApNames;
            FrmLetterData.SentPhotoCopyApAddresses = direction1.ApAddresses;

            FrmLetterData.ArticlesNum = cmbxArticlesNum.SelectedIndex + 1;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}