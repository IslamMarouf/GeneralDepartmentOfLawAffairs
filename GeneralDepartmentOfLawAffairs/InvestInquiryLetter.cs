using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs
{
    class InvestInquiryLetter : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public InvestInquiryLetter(Document doc) : base(doc)
        {
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
            FrmInvestInquiry frmInvestInquiry = new FrmInvestInquiry();
            _dialogResult = frmInvestInquiry.ShowDialog();
            _letterData = frmInvestInquiry.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmInvestInquiry.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            base.HeadingSection();
        }

        protected override void BodySection()
        {
            string str1 = LetterSentences.InvestInquiry1
                          + " " + _letterData.InvestigationNumber
                          + " " + LetterSentences.ForYear
                          + " " + _letterData.InvYear
                          + " " + LetterSentences.about
                          + " " + _letterData.Subject;

            Paragraph investInq1 = new Paragraph(_doc);
            investInq1.AddFormatted(str1, "times new roman", 14, false, true);
        }

        protected override void DirectionSection()
        {
            var strDirection = _letterData.MrMsVal +
                               _letterData.Receiver +
                               _letterData.ReceiverDeptName;

            var recParagraph = new Paragraph(_doc);
            recParagraph.AddFormatted(strDirection, "PT Bold Heading", 14);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void RequestSection()
        {
            string str1 = LetterSentences.InvestInquiry3;

            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(str1, "PT Bold Heading", 11, false);
        }
    }
}
