using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Temp;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters {
    public class InspectionLetter : Letter {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public InspectionLetter(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            var form = new FrmInspectionLetter();
            _dialogResult = form.ShowDialog();
            _letterData = form.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !form.FormHasEmptyFeilds;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical, _letterData.AttachmentsCount);
        }

        protected override void DirectionSection() {
            string strDirection;
            if (_letterData.Receiver == LetterSentences.AdministrativeProsecution) {
                var advisorParagraph = new Paragraph(_doc);
                advisorParagraph.AddFormatted(LetterSentences.Advisor + LetterSentences.Advisor2,
                    "PT Bold Heading", 14);

                var advisor2Paragraph = new Paragraph(_doc);
                advisor2Paragraph.AddFormatted(LetterSentences.Advisor3 + _letterData.Receiver +
                                               _letterData.ReceiverDeptName,
                    "PT Bold Heading", 14);

                var index = _letterData.ApNames.IndexOf(_letterData.ReceiverDeptName);
                strDirection = _letterData.ApAddresses[index];
                var advisor3Paragraph = new Paragraph(_doc);
                advisor3Paragraph.AddFormatted(strDirection, "PT Bold Heading", 14);
            }
            else {
                strDirection =
                    _letterData.MrMsVal +
                    _letterData.Receiver +
                    _letterData.ReceiverDeptName;

                var recParagraph = new Paragraph(_doc);
                recParagraph.AddFormatted(strDirection, "PT Bold Heading", 14);
            }

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void SentPhotoCopy() {
            if (_letterData.HasSentPhotoCopy)
                for (var i = 0; i < _letterData.SentPhotoCopyCount; i++) {
                    string strDirection;
                    string lineSeparator =
                        "___________________________________________________________________________________\n";
                    var p = new Paragraph(_doc);
                    p.AddFormatted(lineSeparator, "times new roman", 10);

                    if (_letterData.RecipientValList[i] == LetterSentences.AdministrativeProsecution) {
                        var advisorParagraph = new Paragraph(_doc);
                        advisorParagraph.AddFormatted(LetterSentences.Advisor + LetterSentences.Advisor2,
                            "PT Bold Heading", 11);

                        var advisor2Paragraph = new Paragraph(_doc);
                        advisor2Paragraph.AddFormatted(LetterSentences.Advisor3 +
                                                       _letterData.RecipientValList[i] +
                                                       _letterData.DeptNameValList[i],
                            "PT Bold Heading", 11);

                        var index = _letterData.ApNames.IndexOf(_letterData.DeptNameValList[i]);
                        strDirection = _letterData.ApAddresses[index];
                        var advisor3Paragraph = new Paragraph(_doc);
                        advisor3Paragraph.AddFormatted(strDirection, "PT Bold Heading", 11);
                    }
                    else {
                        strDirection = LetterSentences.sentPhotoCopyTo +
                                       _letterData.MrMrsValList[i] +
                                       _letterData.RecipientValList[i] +
                                       _letterData.DeptNameValList[i];

                        var recParagraph = new Paragraph(_doc);
                        recParagraph.AddFormatted(strDirection, "PT Bold Heading", 11);
                    }

                    var greetParagraph = new Paragraph(_doc);
                    greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);

                    var requestParagraph = new Paragraph(_doc);
                    requestParagraph.AddFormatted(LetterSentences.sentCopyText, "PT Bold Heading", 11, false);

                    SignSection();
                }
        }

        protected override void Register() {
            
        }

        protected override void BodySection() {
            var bodyString =
                "بمناسبة الفحص رقم " +
                _letterData.InspectionNumber +
                "والذي تجريه الإدارة " +
                _letterData.Subject + " " +
                "(مرفق صورة).";
            var bodyParagraph = new Paragraph(_doc);
            bodyParagraph.Add(bodyString, "Times New Roman", WdColorIndex.wdBlack, 14);
            bodyParagraph.GetRange().Font.BoldBi = 1;
            bodyParagraph.GetRange().ListFormat.ApplyBulletDefault();
            bodyParagraph.GetRange().ParagraphFormat.Alignment =
                WdParagraphAlignment.wdAlignParagraphJustifyLow;
        }

        protected override void RequestSection() {
            var requestParagraph = new Paragraph(_doc);
            requestParagraph.AddFormatted(LetterSentences.inspectionRequest,
                "PT Bold Heading", 12, false);
            requestParagraph.GetRange().Font.BoldBi = 1;
            requestParagraph.GetRange().ListFormat.ApplyBulletDefault();
        }
    }
}