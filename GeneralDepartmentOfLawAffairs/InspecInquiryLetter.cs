using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs
{
    class InspecInquiryLetter : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public InspecInquiryLetter(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
            {
                LetterSections();
            }
        }

        protected override bool Initialize()
        {
            FrmInspecInquiry frmInspecInquiry = new FrmInspecInquiry();
            _dialogResult = frmInspecInquiry.ShowDialog();
            _letterData = frmInspecInquiry.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmInspecInquiry.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            base.HeadingSection();
        }

        protected override void BodySection()
        {
        }

        protected override void DirectionSection()
        {
        }

        protected override void RequestSection()
        {
        }
    }
}
