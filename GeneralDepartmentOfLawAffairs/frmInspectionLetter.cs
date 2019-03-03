using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmInspectionLetter : Form
    {
        private Point _pnlButtonsLocation;

        public FrmInspectionLetter() {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFeilds = false;
            FrmLetterData.HasSentPhotoCopy = false;
        }

        public bool FormHasEmptyFeilds { get; set; }

        public LetterData FrmLetterData { get; set; }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.EmptyFields.Clear();
            if (txtInspectionNumber.Text.Length != 0)
                FrmLetterData.InspectionNumber =
                    txtInspectionNumber.Text + "/" + dtPkrInspectionYear.Text;
            else
                FrmLetterData.EmptyFields.Add(lblInspectionNum.Text);

            if (txtAttachmentsCount.Text.Length != 0)
                FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;
            else
                FrmLetterData.EmptyFields.Add(lblCompanionsCount.Text);

            if (txtSubject.Text.Length != 0)
                FrmLetterData.Subject = txtSubject.Text;
            else
                FrmLetterData.EmptyFields.Add(lblSubject.Text);

            FrmLetterData.MrMsVal = ctrlDirection.MrMrsVal;
            FrmLetterData.Receiver = ctrlDirection.RecipientVal;
            FrmLetterData.ReceiverDeptName = ctrlDirection.DeptNameVal;
            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;

            if (chkbxSentPhotoCopy.Checked) {
                FrmLetterData.HasSentPhotoCopy = true;

                FrmLetterData.SentPhotoCopyCount = 0;

                for (var i = 0; i < ctrlSentPhotoCopy.Directions.Count; i++)
                    if (!ctrlSentPhotoCopy.Directions[i].RecipientVal.Equals("")
                        && !ctrlSentPhotoCopy.Directions[i].DeptNameVal.Equals("")) {
                        FrmLetterData.MrMrsValList
                            .Add(ctrlSentPhotoCopy.Directions[i].MrMrsVal);
                        FrmLetterData.RecipientValList
                            .Add(ctrlSentPhotoCopy.Directions[i].RecipientVal);
                        FrmLetterData.DeptNameValList
                            .Add(ctrlSentPhotoCopy.Directions[i].DeptNameVal);

                        FrmLetterData.SentPhotoCopyCount++;
                    }
            }

            DisplayResult();
        }

        private void DisplayResult() {
            if (FrmLetterData.EmptyFields.Count != 0) {
                var str = "";

                foreach (var t in FrmLetterData.EmptyFields)
                    str += t + "\n";

                var result = MessageBox.Show(
                    LetterSentences.emptyFields
                    + Environment.NewLine
                    + Environment.NewLine
                    + str
                    + Environment.NewLine
                    + LetterSentences.doContinue,
                    LetterSentences.GeneralDepartName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                switch (result) {
                    case DialogResult.Yes:
                        FormHasEmptyFeilds = false;
                        break;

                    case DialogResult.No:
                        FormHasEmptyFeilds = true;
                        break;
                }
            }
            else {
                FormHasEmptyFeilds = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            FormHasEmptyFeilds = false;
        }

        private void FrmInspectionLetter_FormClosing(object sender, FormClosingEventArgs e) {
            if (FormHasEmptyFeilds && (e.CloseReason != CloseReason.UserClosing))
                e.Cancel = true;
            else
                FormHasEmptyFeilds = false;
        }

        private void txtSubject_TextChanged(object sender, EventArgs e) {
        }

        private void FrmInspectionLetter_Load(object sender, EventArgs e) {
            ctrlDirection.cmbxMrMrs.Text =
                ctrlDirection.cmbxMrMrs.Items[0].ToString();

            ctrlDirection.cmbxRecipient.Text =
                ctrlDirection.cmbxRecipient.Items[1].ToString();

            ctrlDirection.cmbxRecipientDeptName.Text =
                ctrlDirection.cmbxRecipientDeptName.Items[1].ToString();

            txtRequest.Text = LetterSentences.inspectionRequest;

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

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void ctrlSentPhotoCopy_Load(object sender, EventArgs e) {
        }
    }
}