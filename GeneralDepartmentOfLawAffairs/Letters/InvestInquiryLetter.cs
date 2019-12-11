using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using GeneralDepartmentOfLawAffairs.Utils;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    class InvestInquiryLetter : Letter
    {
        private readonly Document _doc;
        private readonly string _subjectId;
        private DialogResult _dialogResult;
        public LetterData LetterData;

        public InvestInquiryLetter(Document doc) : base(doc)
        {
            _doc = doc;
            _subjectId = string.Empty;
        }

        public InvestInquiryLetter(Form form, string subjectId) : base(form, subjectId) {
            KillForm(form);
            _doc = Globals.ThisAddIn.Application.ActiveDocument;
            _subjectId = subjectId;
        }

        public override void Write() {
            if (Initialize())
            {LetterSections();
            }
        }

        protected override bool Initialize()
        {
            XFrmInvestInquiry xfrmInvestInquiry = new XFrmInvestInquiry();
            xfrmInvestInquiry.FrmLetterData.SubjectId = _subjectId;
            _dialogResult = xfrmInvestInquiry.ShowDialog();
            LetterData = xfrmInvestInquiry.FrmLetterData;

            LetterData.ParentForm?.Close();

            return (_dialogResult == DialogResult.OK);

        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical, LetterData.AttachmentsCount);}

        protected override void BodySection()
        {
            string str1 = LetterSentences.InvestInquiry1
                          + " " + LetterData.InvestigationNumber
                          + " " + LetterSentences.ForYear
                          + " " + LetterData.InvYear
                          + " " + LetterSentences.InvestInquiry2+ " " + LetterData.Subject;

            Paragraph investInq1 = new Paragraph(_doc);
            investInq1.AddFormatted(str1, "times new roman", 14, false, true);
        }

        protected override void DirectionSection()
        {
            var strDirection = LetterData.MrMsVal +
                               LetterData.Receiver +
                               LetterData.ReceiverDeptName;

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

        protected override void Register() {
            SubjectsHelper.UpdateProcedure(_subjectId,
                LetterSentences.Inquiry,
                _doc.FullName);
        }
    }
}
