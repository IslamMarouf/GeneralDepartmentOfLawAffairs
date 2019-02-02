using System;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmCeaseNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }

        public bool FormHasDraftResolution { get; set; } 

        public LetterData FrmLetterData { get; set; }

        public FrmCeaseNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
            FormHasDraftResolution = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chbxDraftRes.Checked) {
                FrmLetterData.HasDraftResolution = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCeaseNote_Load(object sender, EventArgs e) {
            chbxDraftRes.Checked = true;
        }
    }
}
