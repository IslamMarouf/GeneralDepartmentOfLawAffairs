using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    public class SpecialNotificationLetter : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public SpecialNotificationLetter(Document doc) : base(doc)
        {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
            {
                LetterSections();

                string lineSeparator =
                    "___________________________________________________________________________________\n";
                var p = new Paragraph(_doc);
                p.AddFormatted(lineSeparator, "times new roman", 10);

                LetterSections();
            }
        }

        protected override bool Initialize()
        {
            XFrmSpecialNotification frmSpecial = new XFrmSpecialNotification();
            _dialogResult = frmSpecial.ShowDialog();
            _letterData = frmSpecial.FrmLetterData;

            return _dialogResult == DialogResult.OK;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Notification, _letterData.InvestigationNumber 
                                              + " " + LetterSentences.ForYear 
                                              + " " + _letterData.InvYear);
        }

        protected override void DirectionSection()
        {
            string strDirection = _letterData.MrMsVal +
                                  _letterData.Receiver +
                                  _letterData.ReceiverDeptName;

            Paragraph typeParagraph = new Paragraph(_doc);
            typeParagraph.AddFormatted(LetterSentences.Summon, "PT Bold Heading", 11, true, true);

            Paragraph directionParagraph = new Paragraph(_doc);
            directionParagraph.AddFormatted(strDirection, "PT Bold Heading", 11, false);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void BodySection()
        {
            Paragraph stimulation = new Paragraph(_doc);
            stimulation.AddFormatted(LetterSentences.Stimulation, "Arial (Body CS)", 12, false);

            string reqStr = _letterData.WantedNamesList[0] + " - " + LetterSentences.With + " " + _letterData.WantedDocuments;
            Paragraph wantedParagraph1 = new Paragraph(_doc);
            wantedParagraph1.AddFormatted(reqStr, "pt bold heading", 10, false);
        }    

        protected override void RequestSection()
        {
            string str = LetterSentences.StimulationSummon
                + Paragraph.AddFullDate(_letterData.InvestigationDate)
                + LetterSentences.StimulationSummon_2
                + _letterData.InvestigationNumber + " "
                + LetterSentences.ForYear + " "
                + _letterData.InvYear + " "
                + LetterSentences.StimulationSummon_3
                + Properties.Settings.Default.ResearcherName
                + LetterSentences.StimulationSummon_4 + ".";

            Paragraph requestParagraph = new Paragraph(_doc);
            requestParagraph.AddFormatted(str, "times new roman", 12, false, true);
            requestParagraph.FormattedSentence(Paragraph.AddFullDate(_letterData.InvestigationDate), "pt bold heading", 11);
            requestParagraph.FormattedSentence(Properties.Settings.Default.ResearcherName, "pt bold heading", 11);
            requestParagraph.FormattedSentence(_letterData.InvestigationNumber + " " + LetterSentences.ForYear + " " + _letterData.InvYear, "pt bold heading", 11);
            requestParagraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void Greeting() {
            Paragraph greetingParagraph = new Paragraph(_doc);
            greetingParagraph.AddFormatted(LetterSentences.ThankYou, "arial", 12);

            Paragraph nameParagraph = new Paragraph(_doc);
            nameParagraph.AddFormatted(Properties.Settings.Default.researcherSign,
                "PT Bold Heading", 8, false);
        }

        protected override void SignSection() {
            Signature(SignType.GeneralManager);
        }
    }
}