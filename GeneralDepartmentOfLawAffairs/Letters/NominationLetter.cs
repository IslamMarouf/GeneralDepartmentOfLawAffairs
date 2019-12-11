using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Temp;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    public class NominationLetter : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;
        public NominationLetter(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            FrmNominationLetter frmNominationLetter = new FrmNominationLetter();
            _dialogResult = frmNominationLetter.ShowDialog();
            _letterData = frmNominationLetter.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmNominationLetter.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical);
        }

        protected override void DirectionSection() {
            string strDirection = _letterData.MrMsVal +
                                  _letterData.Receiver +
                                  _letterData.ReceiverDeptName;

            Paragraph directionParagraph = new Paragraph(_doc);
            directionParagraph.AddFormatted(strDirection, "PT Bold Heading", 11);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void BodySection() {
            string bodyStr = LetterSentences.RescriptSent1 +
                             _letterData.IncomingLetterNumber + " " +
                             LetterSentences.Dated + " " +
                             _letterData.ApLetterDate + " " +
                             LetterSentences.about + " " +
                             LetterSentences.NominationLetter1;

            Paragraph bodyParagraph = new Paragraph(_doc);
            bodyParagraph.AddFormatted(bodyStr, "Times New Roman", 14, false, true);
            bodyParagraph.GetRange().ListFormat.ApplyBulletDefault();

            string body1Str = LetterSentences.NominationLetter2 + " " +
                              _letterData.Name + " " +
                              LetterSentences.NominationLetter3;
            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(body1Str, "Times New Roman", 14, false, true);
            body1Paragraph.FormattedSentence(_letterData.Name, "PT Bold Heading", 14);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            string request = LetterSentences.NominationLetter4;
            Paragraph requestParagraph = new Paragraph(_doc);
            requestParagraph.AddFormatted(request, "PT Bold Heading", 11, false, true);
        }

        protected override void Register() {
            
        }
    }
}