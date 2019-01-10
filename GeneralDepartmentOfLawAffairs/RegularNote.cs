using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs
{
    public class RegularNote : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;
        public RegularNote(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            FrmRegularNote frmRegularNote = new FrmRegularNote();
            _dialogResult = frmRegularNote.ShowDialog();
            _letterData = frmRegularNote.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmRegularNote.FormHasEmptyFeilds;
        }

        protected override void HeadingSection() {
            base.HeadingSection();
        }

        protected override void DirectionSection() {
            
        }

        protected override void BodySection() {
            
        }

        protected override void RequestSection() {
            
        }

        protected override void SignSection() {
            base.SignSection();
        }
    }
}