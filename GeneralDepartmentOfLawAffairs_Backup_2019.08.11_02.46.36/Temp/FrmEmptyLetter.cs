using System;
using System.Drawing;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp {
    public partial class FrmEmptyLetter : GeneralForm {
        private Point _pnlButtonsLocation;
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }
        private bool Content { get; set; }

        public FrmEmptyLetter() {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
            FrmLetterData.HasSentPhotoCopy = false;
        }

        private void FrmEmptyLetter_Load(object sender, EventArgs e) {
            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;

            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            ctrlDirection.cmbxRecipientDeptName.SelectedIndex = 1;

            MessageBox.Show(ctrlDirection.cmbxRecipientDeptName.Properties.Items.Count.ToString());

            rbtnRef.Checked = true;
            dpLetterDate.Value = DateTime.Today;

            FrmLetterData.MrMsVal = ctrlDirection.MrMrsVal;
            FrmLetterData.Receiver = ctrlDirection.RecipientVal;
            FrmLetterData.ReceiverDeptName = ctrlDirection.DeptNameVal;

            _pnlButtonsLocation = pnlButtons.Location;

            ctrlSentPhotoCopy.Visible = false;
            pnlButtons.Location = ctrlSentPhotoCopy.Location;
            Height -= ctrlSentPhotoCopy.Height;
        }

        private void chkbxSentPhotoCopy_CheckedChanged(object sender, EventArgs e) {
            if (chkbxSentPhotoCopy.Checked) {
                ctrlSentPhotoCopy.Visible = true;
                pnlButtons.Location = _pnlButtonsLocation;
                Height += ctrlSentPhotoCopy.Height;
            }
            else {
                ctrlSentPhotoCopy.Visible = false;
                pnlButtons.Location = ctrlSentPhotoCopy.Location;
                Height -= ctrlSentPhotoCopy.Height;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.MrMsVal = ctrlDirection.MrMrsVal;
            FrmLetterData.Receiver = ctrlDirection.RecipientVal;
            FrmLetterData.ReceiverDeptName = ctrlDirection.DeptNameVal;
            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;

            if (Content) {
                FrmLetterData.Subject =
                    LetterSentences.RescriptSent1 +
                    txtAPLetterNumber.Text + " " +
                    LetterSentences.Dated + " " +
                    dpLetterDate.Value.ToShortDateString() + " " +
                    LetterSentences.about;
            }
            else {
                FrmLetterData.Subject = "";
            }

            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;

            if (chkbxSentPhotoCopy.Checked) {
                FrmLetterData.HasSentPhotoCopy = true;

                FrmLetterData.SentPhotoCopyCount = 0;

                foreach (var element in ctrlSentPhotoCopy.Directions)
                    if (!element.RecipientVal.Equals("")
                        && !element.DeptNameVal.Equals("")) {
                        FrmLetterData.MrMrsValList
                            .Add(element.MrMrsVal);
                        FrmLetterData.RecipientValList
                            .Add(element.RecipientVal);
                        FrmLetterData.DeptNameValList
                            .Add(element.DeptNameVal);

                        FrmLetterData.SentPhotoCopyCount++;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            FormHasEmptyFields = false;
        }

        private void LetterContent_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbtnRef) {
                Content = true;
            }
            else if (sender == rbtnEmpty) {
                Content = false;
            }
        }
    }
}