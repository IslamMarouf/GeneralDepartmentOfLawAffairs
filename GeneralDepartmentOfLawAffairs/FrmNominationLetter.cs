using System;
using System.Drawing;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmNominationLetter : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }
        public FrmNominationLetter()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }

        private void FrmNominationLetter_Load(object sender, System.EventArgs e)
        {
            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            dtLetterDate.Value = DateTime.Today;
            txtLetterNumber.BackColor = Color.Maroon;
            txtName.BackColor = Color.Maroon;

            ValidateFields();
        }

        private void ValidateFields() {
            if (txtLetterNumber.Text.Equals("")
                || txtName.Text.Equals(""))
            {
                btnOK.Enabled = false;
                lblMessage.Text = LetterSentences.LblMessage_8;
                pbxStatus.Image = Properties.Resources.Sample3__2_;
            }
            else
            {
                btnOK.Enabled = true;
                lblMessage.Text = string.Empty;
                pbxStatus.Image = Properties.Resources.Sample4__2_;
            }
        }

        private void txtLetterNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtLetterNumber.Text.Equals(""))
            {
                txtLetterNumber.BackColor = Color.Maroon;
                ValidateFields();
            }
            else
            {
                txtLetterNumber.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                txtName.BackColor = Color.Maroon;
                ValidateFields();
            }
            else
            {
                txtName.BackColor = Color.FromArgb(81, 83, 71);
                ValidateFields();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.IncomingLetterNumber = txtLetterNumber.Text;
            FrmLetterData.Name = txtName.Text;
            FrmLetterData.ApLetterDate = dtLetterDate.Value.ToShortDateString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }
    }
}
