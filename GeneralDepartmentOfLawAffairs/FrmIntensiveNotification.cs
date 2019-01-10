using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmIntensiveNotification : GeneralForm
    {
        public LetterData FrmLetterData { get; }
        public bool FormHasEmptyFeilds { get; set; }

        public FrmIntensiveNotification() {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }

        private void FrmIntensiveNotification_Load(object sender, EventArgs e) {
            if (txtNotificationOutcomNumber.Text.Equals("")) {
                lblMessage.Text = LetterSentences.LblMessage_6;
                ValidateNotification();
            }

            if (txt_1.Text.Equals("")) {
                lblMessage_1.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            dTPicker.Value = DateTime.Today;
            dTPickerIncomDate.Value = DateTime.Today;
            dTPickerLastNotification.Value = DateTime.Today;
        }

        private void DisplayResult()
        {
            if (FrmLetterData.EmptyFields.Count != 0)
            {
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

                switch (result)
                {
                    case DialogResult.Yes:
                        FormHasEmptyFeilds = false;
                        break;

                    case DialogResult.No:
                        FormHasEmptyFeilds = true;
                        break;
                }
            }
            else
            {
                FormHasEmptyFeilds = false;
            }
        }

        private void ValidateNotification()
        {
            if (lblMessage.Text.Equals("")
                && lblMessage_1.Text.Equals("")
                && lblMessage_2.Text.Equals("")
                && lblMessage_3.Text.Equals(""))
            {
                btnOK.Enabled = true;
                pbxStatus.BackgroundImage = Resources.Sample4__2_;
            }
            else
            {
                btnOK.Enabled = false;
                pbxStatus.BackgroundImage = Resources.Sample3__2_;
            }
        }

        private void FrmIntensiveNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormHasEmptyFeilds && (e.CloseReason != CloseReason.UserClosing))
                e.Cancel = true;
            else
                FormHasEmptyFeilds = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.EmptyFields.Clear();
            FrmLetterData.WantedNamesList.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;
            FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text + "/" + dtPkrInvestigationYear.Text;

            if (!txt_1.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_1.Text);

            FrmLetterData.LastNotificationOutcomDate = dTPickerLastNotification.Value;
            FrmLetterData.LastNotificationOutcomNumber = txtNotificationOutcomNumber.Text;

            if (dTPicker.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_4);

            DisplayResult();
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            if (txt_1.Text.Equals(""))
            {
                lblMessage_1.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }
            else {
                lblMessage_1.Text = "";
                ValidateNotification();
            }
        }

        private void txtNotificationOutcomNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNotificationOutcomNumber.Text.Equals(""))
            {
                lblMessage.Text = LetterSentences.LblMessage_6;
                ValidateNotification();
            }
            else
            {
                lblMessage.Text = "";
                ValidateNotification();
            }
        }

        private void dTPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dTPicker.Value.CompareTo(DateTime.Today) < 0)
            {
                lblMessage_3.Text = LetterSentences.LblMessage_3;
                ValidateNotification();
            }
            else
            {
                FrmLetterData.InvestigationDate = dTPicker.Value;
                lblMessage_3.Text = "";
                ValidateNotification();
            }
        }

        private void dTPickerLastNotification_ValueChanged(object sender, EventArgs e)
        {
            if (dTPickerLastNotification.Value.CompareTo(DateTime.Today) >= 0)
            {
                lblMessage_2.Text = LetterSentences.LblMessage_7;
                ValidateNotification();
            }
            else {
                FrmLetterData.LastNotificationOutcomDate = dTPickerLastNotification.Value;
                lblMessage_2.Text = "";
                ValidateNotification();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFeilds = false;
        }
    }
}