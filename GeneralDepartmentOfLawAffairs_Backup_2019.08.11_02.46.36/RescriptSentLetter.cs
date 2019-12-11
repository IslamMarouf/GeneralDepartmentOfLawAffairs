using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Letters {
    public class RescriptSentLetter : Letter {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public RescriptSentLetter(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize()) {
                LetterSections();
            }
        }

        protected override bool Initialize() {
            XFrmRescriptSentLetter xFrmRescriptSentLetter = new XFrmRescriptSentLetter();
            _dialogResult = xFrmRescriptSentLetter.ShowDialog();
            _letterData = xFrmRescriptSentLetter.FrmLetterData;

            return _dialogResult == DialogResult.OK;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical);
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
            string strBody1 = LetterSentences.RescriptSent1 +
                              _letterData.ApLetterNum + " " +
                              LetterSentences.Dated + " " +
                              _letterData.ApLetterDate + " " +
                              LetterSentences.RescriptSent2 +
                              _letterData.DecisionNumber + " " +
                              _letterData.CaseDecisionDate +
                              LetterSentences.RescriptSent3 +
                              _letterData.CaseNumber + " " +
                              LetterSentences.ForYear + " " +
                              _letterData.CaseYear + " " +
                              (!_letterData.Guilty.Equals("")
                                  ? LetterSentences.RescriptSent4 + _letterData.Guilty
                                  : "");

            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(strBody1, "Times New Roman", 14, false, true);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();

            string strBody2 = LetterSentences.RescriptSent5 +
                              _letterData.RescriptNum + " " +
                              LetterSentences.Dated + " " +
                              _letterData.RescriptDate + " " +
                              LetterSentences.RescriptSent6;
            Paragraph body2Paragraph = new Paragraph(_doc);
            body2Paragraph.AddFormatted(strBody2, "Times New Roman", 14, false, true);
            body2Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(LetterSentences.RescriptSent7, "PT Bold Heading", 11, false);
        }
    }
}