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

        private void FrmApReferring_Load(object sender, EventArgs e)
        {
            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;

            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }

        
    }
}