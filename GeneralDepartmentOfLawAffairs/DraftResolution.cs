using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs
{
    public class DraftResolution : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public DraftResolution(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            FrmDraftResolution frmDraftResolution = new FrmDraftResolution();
            _dialogResult = frmDraftResolution.ShowDialog();
            _letterData = frmDraftResolution.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmDraftResolution.FormHasEmptyFields;
        }

        protected override void DirectionSection() {
            
        }

        protected override void BodySection() {
            
        }

        protected override void RequestSection() {
            
        }
    }
}