using System;
using System.Drawing;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp {
    public partial class FrmIssuanceRescriptLetter : GeneralForm {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }
        

        public FrmIssuanceRescriptLetter() {
            InitializeComponent();
            FrmLetterData = new LetterData(); 
        }

        private void FrmIssuanceRescriptLetter_Load(object sender, EventArgs e) {
            foreach (string item in ctrlDirection.ApNames) {
                cmbxAPList.Items.Add(item);
            }

            direction1.cmbxMrMrs.Enabled = false;
            direction1.cmbxRecipient.SelectedIndex = 3;
            direction1.cmbxRecipient.Enabled = false;

            dpAPLetter.Value = DateTime.Today;
            dtCaseDecision.Value = DateTime.Today;

            seCaseResYear.Enabled = true;
            rdbtnDate.Checked = true;

            pbxStatus.Image = Properties.Resources.Sample3__2_;

            txtAPLetterNumber.BackColor = Color.Maroon;
            txtCaseResNumber.BackColor = Color.Maroon;
            txtCaseNumber.BackColor = Color.Maroon;

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;
            cmbxAPList.SelectedIndex = 0;

            cmbxCompetentAuthority.SelectedIndex = 1;
            cmbxArticlesNum.SelectedIndex = 2;

            ValidateFields();
        }

        private void DateType_CheckedChanged(object sender, EventArgs e) {
            if (sender == rdbtnDate) {
                FrmLetterData.CaseDecisionDate =
                    LetterSentences.Dated + " " + dtCaseDecision.Value.ToShortDateString() + " ";
                seCaseResYear.Enabled = !seCaseResYear.Enabled;
            }
            else if (sender == rdbtnYear) {
                FrmLetterData.CaseDecisionDate = LetterSentences.ForYear + " " + seCaseResYear.Value.Year + " ";
                dtCaseDecision.Enabled = !dtCaseDecision.Enabled;
            }
        }

        private void ValidateFields() {
            if (txtAPLetterNumber.Text.Equals("")
                || txtCaseResNumber.Text.Equals("")
                || txtCaseNumber.Text.Equals("")) {
                btnOK.Enabled = false;
                lblMessage.Text = LetterSentences.LblMessage_8;
                pbxStatus.Image = Properties.Resources.Sample3__2_;
            }
            else {
                btnOK.Enabled = true;
                lblMessage.Text = string.Empty;
                pbxStatus.Image = Properties.Resources.Sample4__2_;
            }
        }

        private void txtAPLetterNumber_TextChanged(object sender, EventArgs e) {
            if (txtAPLetterNumber.Text.Equals("")) {
                txtAPLetterNumber.BackColor = Color.Maroon;
                ValidateFields();
            }
            else {
                txtAPLetterNumber.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void txtCaseDecisionNumber_TextChanged(object sender, EventArgs e) {
            if (txtCaseResNumber.Text.Equals("")) {
                txtCaseResNumber.BackColor = Color.Maroon;
                ValidateFields();
            }
            else {
                txtCaseResNumber.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void txtCaseNumber_TextChanged(object sender, EventArgs e) {
            if (txtCaseNumber.Text.Equals("")) {
                txtCaseNumber.BackColor = Color.Maroon;
                ValidateFields();
            }
            else {
                txtCaseNumber.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void cmbxAPList_SelectedIndexChanged(object sender, EventArgs e) {
            direction1.cmbxRecipientDeptName.SelectedIndex = cmbxAPList.SelectedIndex;
        }

        private void dpAPLetter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtCaseDecision_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.ApLetterNum = txtAPLetterNumber.Text;
            FrmLetterData.ApLetterDate = dpAPLetter.Value.ToShortDateString();
            FrmLetterData.DecisionNumber = txtCaseResNumber.Text;
            FrmLetterData.CaseNumber = txtCaseNumber.Text;
            FrmLetterData.CaseYear = seCaseYear.Value.Year.ToString();
            FrmLetterData.Guilty = txtGuilty.Text;

            FrmLetterData.ApVal = cmbxAPList.Text;

            FrmLetterData.RecMrMsVal = direction1.MrMrsVal;
            FrmLetterData.SentPhotoCopyReceiver = direction1.RecipientVal;
            FrmLetterData.SentPhotoCopyReceiverDptName = direction1.DeptNameVal;
            FrmLetterData.SentPhotoCopyApNames = direction1.ApNames;
            FrmLetterData.SentPhotoCopyApAddresses = direction1.ApAddresses;

            FrmLetterData.ArticlesNum = cmbxArticlesNum.SelectedIndex + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }
    }
}