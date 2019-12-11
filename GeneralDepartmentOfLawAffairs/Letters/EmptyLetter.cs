using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Temp;
using GeneralDepartmentOfLawAffairs.Utils;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Letters {
    class EmptyLetter : Letter {
        private readonly Word.Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public EmptyLetter(Word.Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            base.Write();
            if (Initialize()) {
                LetterSections();
            }
        }

        protected override bool Initialize() {
            FrmEmptyLetter frmEmptyLetter = new FrmEmptyLetter();
            _dialogResult = frmEmptyLetter.ShowDialog();
            _letterData = frmEmptyLetter.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmEmptyLetter.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical, _letterData.AttachmentsCount);
        }

        protected override void DirectionSection() {
            string strDirection;
            if (_letterData.Receiver == LetterSentences.AdministrativeProsecution)
            {
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
            else
            {
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

        protected override void BodySection() {
            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(_letterData.Subject, "Times New Roman", 14, false, true);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            var requestParagraph = new Paragraph(_doc);
            requestParagraph.AddFormatted(LetterSentences.GeneralRequest,
                "PT Bold Heading", 12, false);
            requestParagraph.GetRange().Font.BoldBi = 1;
            requestParagraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void SentPhotoCopy() {
            if (_letterData.HasSentPhotoCopy)
                for (var i = 0; i < _letterData.SentPhotoCopyCount; i++)
                {
                    string strDirection;
                    string lineSeparator =
                        "___________________________________________________________________________________\n";
                    var p = new Paragraph(_doc);
                    p.AddFormatted(lineSeparator, "times new roman", 10);

                    if (_letterData.RecipientValList[i] == LetterSentences.AdministrativeProsecution)
                    {
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
                    else
                    {
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
    }
}