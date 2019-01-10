namespace GeneralDepartmentOfLawAffairs {
    public partial class FrmInspectionRef : GeneralForm {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        public FrmInspectionRef() {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }

        private void FrmInspectionRef_Load(object sender, System.EventArgs e) {
            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;

            ValidateFields();
        }

        private void ValidateFields() {
            if (cmbxInspectionNum.Text.Equals("")) {
                btnOK.Enabled = false;
                lblMessage.Text = LetterSentences.LblMessage_10;
                pbxStatus.Image = Properties.Resources.Sample3__2_;
            }
            else {
                btnOK.Enabled = true;
                lblMessage.Text = string.Empty;
                pbxStatus.Image = Properties.Resources.Sample4__2_;
            }
        }

        private void cmbxInspectionNum_SelectedIndexChanged(object sender, System.EventArgs e) {
            ValidateFields();
        }

        private void cmbxInspectionNum_TextChanged(object sender, System.EventArgs e) {
            ValidateFields();
        }

        private void btnOK_Click(object sender, System.EventArgs e) {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.InspectionNumber = cmbxInspectionNum.Text;
            FrmLetterData.InspectionDate = dtPkrIInspectionYear.Value.Year.ToString();
            FrmLetterData.Subject = txtSubject.Text;

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            FormHasEmptyFields = false;
        }
    }
}