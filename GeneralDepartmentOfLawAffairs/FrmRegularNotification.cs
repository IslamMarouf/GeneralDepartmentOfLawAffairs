using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmRegularNotification : GeneralForm
    {
        public FrmRegularNotification() {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }

        public LetterData FrmLetterData { get; }
        public bool FormHasEmptyFields { get; set; }

        private void FrmRegularNotification_Load(object sender, EventArgs e) {
            if (cmbxInvestigationNum.Text.Equals("")) {
                lblMessage.Text = LetterSentences.LblMessage;
                ValidateNotification();
            }

            if (txt_1.Text.Equals("")) {
                lblMessage_2.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }

            if (txtSubject.Text.Equals("")) {
                lblMessage_1.Text = LetterSentences.LblMessage_1;
                ValidateNotification();
            }

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            dTPicker.Value = DateTime.Today;
            dTPickerIncomDate.Value = DateTime.Today;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.EmptyFields.Clear();
            FrmLetterData.WantedNamesList.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;
            FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text + "/" + dtPkrInvestigationYear.Text;          

            if (!txt_1.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_1.Text);

            if (!txt_2.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_2.Text);
           
            if (!txt_3.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_3.Text);
            
            if (!txt_4.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_4.Text);
            
            if (dTPicker.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_4);

            if (dTPickerIncomDate.Value.CompareTo(DateTime.Today) > 0) {
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_5);
            }

            DisplayResult();
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

        private void txt_1_TextChanged(object sender, EventArgs e) {
            if (txt_1.Text.Equals("")) {
                lblMessage_2.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }
            else {
                lblMessage_2.Text = "";
                ValidateNotification();
            }
        }

        private void dTPicker_ValueChanged(object sender, EventArgs e) {
            if (dTPicker.Value.CompareTo(DateTime.Today) < 0) {
                lblMessage_3.Text = LetterSentences.LblMessage_3;
                ValidateNotification();
            }
            else {
                FrmLetterData.InvestigationDate = dTPicker.Value;
                lblMessage_3.Text = "";
                ValidateNotification();
            }
        }

        private void ValidateNotification() {
            if (lblMessage.Text.Equals("")
                && lblMessage_1.Text.Equals("")
                && lblMessage_2.Text.Equals("")
                && lblMessage_3.Text.Equals("")
                && lblMessage_4.Text.Equals("")) {
                btnOK.Enabled = true;
                pbxStatus.BackgroundImage = Resources.Sample4__2_;
            }
            else {
                btnOK.Enabled = false;
                pbxStatus.BackgroundImage = Resources.Sample3__2_;
            }
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void cmbxInvestigationNum_TextChanged(object sender, EventArgs e) {
            if (cmbxInvestigationNum.Text.Equals("")) {
                lblMessage.Text = LetterSentences.LblMessage;
                ValidateNotification();
            }
            else {
                lblMessage.Text = "";
                ValidateNotification();
            }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e) {
            if (txtSubject.Text.Equals("")) {
                lblMessage_1.Text = LetterSentences.LblMessage_1;
                ValidateNotification();
            }
            else {
                lblMessage_1.Text = "";
                ValidateNotification();
            }
        }

        private void FrmRegularNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormHasEmptyFields && (e.CloseReason != CloseReason.UserClosing))
                e.Cancel = true;
            else
                FormHasEmptyFields = false;
        }

        private void dTPickerIncomDate_ValueChanged(object sender, EventArgs e)
        {
            if (dTPickerIncomDate.Value.CompareTo(DateTime.Today) > 0)
            {
                lblMessage_4.Text = LetterSentences.LblMessage_5;
                ValidateNotification();
            }
            else
            {
                FrmLetterData.InvestigationIncomDate = dTPickerIncomDate.Value;
                lblMessage_4.Text = "";
                ValidateNotification();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }
    }
}