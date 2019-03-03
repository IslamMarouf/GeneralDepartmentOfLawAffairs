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
            Heading(HeadingType.Typical, _letterData.AttachmentsCount);
        }     

        protected override void DirectionSection()
        {
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

        protected override void BodySection()
        {
            string str1 = LetterSentences.Inspection1
                          + " " + LetterSentences.Num
                          + " " + _letterData.InspectionNumber
                          + " " + LetterSentences.ForYear
                          + " " + _letterData.InspectYear
                          + " " + LetterSentences.InvestInquiry2
                          + " " + _letterData.Subject;

            Paragraph investInq1 = new Paragraph(_doc);
            investInq1.AddFormatted(str1, "times new roman", 14, false, true);
        }

        protected override void RequestSection()
        {
            string str1 = LetterSentences.inspectionRequest;

            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(str1, "PT Bold Heading", 11, false);
        }
        protected override void SentPhotoCopy()
        {
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

    }
}
