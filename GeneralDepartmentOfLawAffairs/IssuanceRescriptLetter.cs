using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs {
    public class IssuanceRescriptLetter : Letter {
        private readonly Word.Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public IssuanceRescriptLetter(Word.Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize()) {
                LetterSections();
            }
        }

        protected override bool Initialize() {
            FrmIssuanceRescriptLetter frmIssuance = new FrmIssuanceRescriptLetter();
            _dialogResult = frmIssuance.ShowDialog();
            _letterData = frmIssuance.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmIssuance.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical);
        }

        protected override void DirectionSection() {
            var strDirection = _letterData.MrMsVal +
                               _letterData.Receiver +
                               _letterData.ReceiverDeptName;

            var recParagraph = new Paragraph(_doc);
            recParagraph.AddFormatted(strDirection, "PT Bold Heading", 14);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void BodySection() {
            string strBody1 = LetterSentences.IssuanceRescript1 +
                              _letterData.ApVal + " " +
                              LetterSentences.Num + " " +
                              _letterData.ApLetterNum + " " +
                              LetterSentences.Dated + " " +
                              _letterData.ApLetterDate + " " +
                              LetterSentences.IssuanceRescript2 +
                              _letterData.DecisionNumber + " " +
                              _letterData.CaseDecisionDate +
                              LetterSentences.IssuanceRescript3 +
                              _letterData.CaseNumber + " " +
                              LetterSentences.ForYear + " " +
                              _letterData.CaseYear + " " +
                              (!_letterData.Guilty.Equals("")
                                  ? LetterSentences.RescriptSent4 + _letterData.Guilty
                                  : "");

            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(strBody1, "Times New Roman", 14, false, true);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();

            string strBody2 = LetterSentences.IssuanceRescript4;
            Paragraph body2Paragraph = new Paragraph(_doc);
            body2Paragraph.AddFormatted(strBody2, "Times New Roman", 14, false, true);
            body2Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(LetterSentences.IssuanceRescript5, "PT Bold Heading", 11, false);
        }

        protected override void SentPhotoCopy() {

            string lineSeparator = "___________________________________________________________________________________\n";
            var p = new Paragraph(_doc);
            p.AddFormatted(lineSeparator, "times new roman", 10);

            string strDirection;
            var advisorParagraph = new Paragraph(_doc);
            advisorParagraph.AddFormatted(LetterSentences.Advisor +
                                          LetterSentences.Advisor2,
                "PT Bold Heading", 11);

            var advisor2Paragraph = new Paragraph(_doc);
            advisor2Paragraph.AddFormatted(LetterSentences.Advisor3 +
                                           _letterData.SentPhotoCopyReceiver +
                                           _letterData.SentPhotoCopyReceiverDptName,
                "PT Bold Heading", 11);

            var index = _letterData.SentPhotoCopyApNames.IndexOf(_letterData.SentPhotoCopyReceiverDptName);
            strDirection = _letterData.SentPhotoCopyApAddresses[index];
            var advisor3Paragraph = new Paragraph(_doc);
            advisor3Paragraph.AddFormatted(strDirection, "PT Bold Heading", 11);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);

            var strBody = LetterSentences.IssuanceRescript6 +
                          _letterData.ApLetterNum + " " +
                          LetterSentences.Dated + " " +
                          _letterData.ApLetterDate + " " +
                          LetterSentences.IssuanceRescript7;

            Paragraph body = new Paragraph(_doc);
            body.AddFormatted(strBody, "PT Bold Heading", 11, false);
            body.GetRange().ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

            SignSection();
        }
    }
}