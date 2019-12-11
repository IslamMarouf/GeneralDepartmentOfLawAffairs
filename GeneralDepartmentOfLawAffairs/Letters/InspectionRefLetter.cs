using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using GeneralDepartmentOfLawAffairs.Utils;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters {
    class InspectionRefLetter : Letter {
        private readonly Document _doc;
        private readonly string _subjectId;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public InspectionRefLetter(Document doc) : base(doc) {
            _doc = doc;
            _subjectId = string.Empty;
        }

        public InspectionRefLetter(Form form, string subjectId) : base(form, subjectId) {
            KillForm(form);
            _doc = Globals.ThisAddIn.Application.ActiveDocument;
            _subjectId = subjectId;
        }

        public override void Write() {
            if (Initialize()) {
                LetterSections();
            }
        }

        protected override bool Initialize() {
            XFrmInspectionRef xFrmInspectionRef = new XFrmInspectionRef();
            xFrmInspectionRef.FrmLetterData.SubjectId = _subjectId;
            _dialogResult = xFrmInspectionRef.ShowDialog();
            _letterData = xFrmInspectionRef.FrmLetterData;

            return _dialogResult == DialogResult.OK;
        }

        protected override void HeadingSection() {
            string optStr = _letterData.AttachmentsCount;
            Heading(HeadingType.Typical, optStr);
        }

        protected override void DirectionSection() {
            string strDirection;
            var advisorParagraph = new Paragraph(_doc);
            advisorParagraph.AddFormatted(LetterSentences.Advisor +
                                          LetterSentences.Advisor2,
                "PT Bold Heading", 14);

            var advisor2Paragraph = new Paragraph(_doc);
            advisor2Paragraph.AddFormatted(LetterSentences.Advisor3 +
                                           _letterData.Receiver +
                                           _letterData.ReceiverDeptName,
                "PT Bold Heading", 14);

            var index = _letterData.ApNames.IndexOf(_letterData.ReceiverDeptName);
            strDirection = _letterData.ApAddresses[index];
            var advisor3Paragraph = new Paragraph(_doc);
            advisor3Paragraph.AddFormatted(strDirection, "PT Bold Heading", 14);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void BodySection() {
            string strBody = LetterSentences.InspctionRefererring1 
                             + " " + _letterData.InspectionNumber 
                             + " " + LetterSentences.ForYear 
                             + " " + _letterData.InspectYear
                             + " " + LetterSentences.about
                             + " " + _letterData.Subject 
                             + " " + LetterSentences.InspctionRefererring2;

            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(strBody, "Times New Roman", 14, false, true);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(LetterSentences.InspctionRefererring3, "PT Bold Heading", 11, false);
            request.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void Register() {
            SubjectsHelper.UpdateProcedure(_subjectId,
                LetterSentences.RefLetter,
                _doc.FullName);
        }
    }
}