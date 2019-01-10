using System;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmApReferring : GeneralForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        public FrmApReferring() {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }

        private void FrmApReferring_Load_1(object sender, EventArgs e)
        {
            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;

            ValidateFields();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text;
            FrmLetterData.InvestDate = dtPkrInvestigationYear.Value.Year.ToString();
            FrmLetterData.Subject = txtSubject.Text;

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void ValidateFields()
        {
            if (cmbxInvestigationNum.Text.Equals(""))
            {
                btnOK.Enabled = false;
                lblMessage.Text = LetterSentences.LblMessage_9;
                pbxStatus.Image = Properties.Resources.Sample3__2_;
            }
            else
            {
                btnOK.Enabled = true;
                lblMessage.Text = string.Empty;
                pbxStatus.Image = Properties.Resources.Sample4__2_;
            }
        }

        private void cmbxInvestigationNum_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
    }
}