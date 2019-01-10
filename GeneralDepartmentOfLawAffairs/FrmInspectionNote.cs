using System;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmInspectionNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmInspectionNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }

        private void FrmInspectionNote_Load(object sender, EventArgs e)
        {
            cmbxDirection.SelectedIndex = 0;
        }

        private void cmbxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmLetterData.Index = cmbxDirection.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.Subject = txtSubject.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
