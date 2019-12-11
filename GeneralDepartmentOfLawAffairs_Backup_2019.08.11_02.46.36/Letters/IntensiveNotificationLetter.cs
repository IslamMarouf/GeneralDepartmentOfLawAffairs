using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using GeneralDepartmentOfLawAffairs.Utils;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Letters {
    public class IntensiveNotificationLetter : Letter {
        private readonly Word.Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public IntensiveNotificationLetter(Word.Document doc) : base(doc) {
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

        protected override bool Initialize() {
            var xFrmIntensive = new XFrmIntensiveNotification();
            _dialogResult = xFrmIntensive.ShowDialog();
            _letterData = xFrmIntensive.FrmLetterData;

            return _dialogResult == DialogResult.OK;}

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
        }

        protected override void RequestSection() {
            string requestStr = LetterSentences.append
                                + _letterData.LastNotificationOutcomNumber + " "
                                + LetterSentences.Dated_1
                                + _letterData.LastNotificationOutcomDate.ToShortDateString() + " "
                                + LetterSentences.intensive
                                + _letterData.WantedNamesList[0];

            string requestStr1 = LetterSentences.intensive_1
                                 + Paragraph.AddFullDate(_letterData.InvestigationDate)
                                 + LetterSentences.StimulationSummon_3
                                 + Properties.Settings.Default.ResearcherName
                                 + LetterSentences.StimulationSummon_4 + " "
                                 + LetterSentences.intensive_2;


            Paragraph requestParagraph = new Paragraph(_doc);
            requestParagraph.AddFormatted(requestStr, "times new roman", 12, false);
            requestParagraph.GetRange().ListFormat.ApplyBulletDefault();

            Paragraph requestParagraph2 = new Paragraph(_doc);
            requestParagraph2.AddFormatted(requestStr1, "times new roman", 12, false);
            requestParagraph2.GetRange().ListFormat.ApplyBulletDefault();
            requestParagraph2.FormattedSentence(Paragraph.AddFullDate(_letterData.InvestigationDate), "times new roman",
                13, Word.WdColorIndex.wdBlack, false, true);
            requestParagraph2.FormattedSentence(Properties.Settings.Default.ResearcherName, "times new roman", 13,
                Word.WdColorIndex.wdBlack, false, true);
            requestParagraph2.FormattedSentence(LetterSentences.intensive_2, "times new roman", 13,
                Word.WdColorIndex.wdBlack, false, true);
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