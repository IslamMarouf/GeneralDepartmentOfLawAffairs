using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    public class RegularNotificationLetter : Letter
    {
        private readonly Word.Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public RegularNotificationLetter(Word.Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize()) {
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
            XFrmRegularNotification xFrmRegular = new XFrmRegularNotification();
            _dialogResult = xFrmRegular.ShowDialog();
            _letterData = xFrmRegular.FrmLetterData;

            return (_dialogResult == DialogResult.OK);}

        

        protected override void HeadingSection() {
            Heading(HeadingType.Notification, _letterData.InvestigationNumber + " " + LetterSentences.ForYear + " " + _letterData.InvYear);
        }

        protected override void DirectionSection() {
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

        protected override void BodySection() {

            Paragraph stimulation = new Paragraph(_doc);
            stimulation.AddFormatted(LetterSentences.Stimulation, "Arial (Body CS)", 12, false);

            // Table.
            var tableParagraph = _doc.Paragraphs.Add();
            Word.Table table;
            int columnsCount = 2;
            int rowsCount = ((_letterData.WantedNamesList.Count > 2) ? 2 : 1);
            int listIndexer = 0;

            table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

            for (int i = 1; i <= rowsCount; i++) {
                for (int j = 1; j <= columnsCount; j++) {
                    Word.Cell c = table.Cell(i, j);

                    if (listIndexer < _letterData.WantedNamesList.Count) {
                        c.Range.Text = (listIndexer + 1) + ") " + _letterData.WantedNamesList[listIndexer++];
                    }
                    
                }
            }

            table.Range.Font.NameBi = "PT Bold Heading";
            table.Range.Font.SizeBi = 10;
            table.Range.ParagraphFormat.SpaceAfter = 0;
        }

        protected override void RequestSection() {

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
        }

        protected override void Greeting() {
            Paragraph greetingParagraph = new Paragraph(_doc);
            greetingParagraph.AddFormatted(LetterSentences.ThankYou, "arial", 12);

            Paragraph nameParagraph = new Paragraph(_doc);
            nameParagraph.AddFormatted(Properties.Settings.Default.researcherSign,
                "PT Bold Heading", 8, false);
        }

        protected override void SignSection()
        {
            Signature(SignType.GeneralManager);
        }
    }
}