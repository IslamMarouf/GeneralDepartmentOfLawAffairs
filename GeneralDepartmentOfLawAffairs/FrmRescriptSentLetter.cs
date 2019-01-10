using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs {
    public partial class FrmRescriptSentLetter {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        public FrmRescriptSentLetter() {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }

        private void FrmRescriptSentLetter_Load(object sender, EventArgs e) {
            dpAPLetter.Value = DateTime.Today;
            dtCaseDecision.Value = DateTime.Today;
            dtRescriptDate.Value = DateTime.Today;

            dtCaseDecisionYear.Enabled = true;
            rdbtnDate.Checked = true;

            pbxStatus.Image = Properties.Resources.Sample3__2_;

            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;

            txtAPLetterNumber.BackColor = Color.Maroon;
            txtCaseDecisionNumber.BackColor = Color.Maroon;
            txtCaseNumber.BackColor = Color.Maroon;
            txtRescriptNum.BackColor = Color.Maroon;

            ValidateFields();
        }

        private void DateType_CheckedChanged(object sender, EventArgs e) {
            if (sender == rdbtnDate) {
                FrmLetterData.CaseDecisionDate =
                    LetterSentences.Dated + " " + dtCaseDecision.Value.ToShortDateString() + " ";
                dtCaseDecisionYear.Enabled = !dtCaseDecisionYear.Enabled;
            }
            else if (sender == rdbtnYear) {
                FrmLetterData.CaseDecisionDate = LetterSentences.ForYear + " " + dtCaseDecisionYear.Value.Year + " ";
                dtCaseDecision.Enabled = !dtCaseDecision.Enabled;
            }
        }

        private void DisplayResult() {
            if (FrmLetterData.EmptyFields.Count != 0) {
                var str = "";

                foreach (var t in FrmLetterData.EmptyFields)
                    str += t + "\n";

                var result = MessageBox.Show(
                    str
                    + Environment.NewLine
                    + LetterSentences.doContinue,
                    LetterSentences.GeneralDepartName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                switch (result) {
                    case DialogResult.Yes:
                        FormHasEmptyFields = false;
                        break;

                    case DialogResult.No:
                        FormHasEmptyFields = true;
                        break;
                }
            }
            else {
                FormHasEmptyFields = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.ApLetterNum = txtAPLetterNumber.Text;
            FrmLetterData.ApLetterDate = dpAPLetter.Value.ToShortDateString();
            FrmLetterData.DecisionNumber = txtCaseDecisionNumber.Text;
            FrmLetterData.CaseNumber = txtCaseNumber.Text;
            FrmLetterData.CaseYear = dtCase.Value.Year.ToString();
            FrmLetterData.Guilty = txtGuilty.Text;
            FrmLetterData.RescriptNum = txtRescriptNum.Text;
            FrmLetterData.RescriptDate = dtRescriptDate.Value.ToShortDateString();

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;

            //DisplayResult();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            FormHasEmptyFields = false;
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

        private void dpAPLetter_ValueChanged(object sender, EventArgs e) {
        }

        private void txtCaseDecisionNumber_TextChanged(object sender, EventArgs e) {
            if (txtCaseDecisionNumber.Text.Equals("")) {
                txtCaseDecisionNumber.BackColor = Color.Maroon;
                ValidateFields();
            }
            else {
                txtCaseDecisionNumber.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void dtCaseDecision_ValueChanged(object sender, EventArgs e) {
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

        private void txtRescriptNum_TextChanged(object sender, EventArgs e) {
            if (txtRescriptNum.Text.Equals("")) {
                txtRescriptNum.BackColor = Color.Maroon;
                ValidateFields();
            }
            else {
                txtRescriptNum.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void dtRescriptDate_ValueChanged(object sender, EventArgs e) {
        }

        private void txtGuilty_TextChanged(object sender, EventArgs e) {
        }

        private void ValidateFields() {
            if (txtAPLetterNumber.Text.Equals("")
                || txtCaseDecisionNumber.Text.Equals("")
                || txtCaseNumber.Text.Equals("")
                || txtRescriptNum.Text.Equals("")) {
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
    }
}