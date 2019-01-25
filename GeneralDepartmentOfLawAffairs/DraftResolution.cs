using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs {
    public class DraftResolution : Letter {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;
        private readonly List<string> _articlesList;

        public DraftResolution(Document doc) : base(doc) {
            _doc = doc;
            _articlesList = new List<string>();
            _articlesList.Add(LetterSentences.DraftResolution12);
            _articlesList.Add(LetterSentences.DraftResolution13);
            _articlesList.Add(LetterSentences.DraftResolution14);
            _articlesList.Add(LetterSentences.DraftResolution15);
            _articlesList.Add(LetterSentences.DraftResolution16);
            _articlesList.Add(LetterSentences.DraftResolution17);
            _articlesList.Add(LetterSentences.DraftResolution18);
            _articlesList.Add(LetterSentences.DraftResolution19);
            _articlesList.Add(LetterSentences.DraftResolution20);
            _articlesList.Add(LetterSentences.DraftResolution21);
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            FrmDraftResolution frmDraftResolution = new FrmDraftResolution();
            _dialogResult = frmDraftResolution.ShowDialog();
            _letterData = frmDraftResolution.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmDraftResolution.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.DraftResolution, "", _letterData.CDptName);
        }

        protected override void DirectionSection() {
        }

        protected override void BodySection() {
            string draftResStr1 = LetterSentences.DraftResolution1;
            var draftResParagraph1 = new Paragraph(_doc);
            draftResParagraph1.AddFormatted(draftResStr1, "pt bold heading", 12);

            string draftResStr2 = LetterSentences.Num + " (" + "      ) "
                                  + LetterSentences.OutCome + " "
                                  + LetterSentences.Dated + "      /      /" + DateTime.Now.Year;
            var draftResParagraph2 = new Paragraph(_doc);
            draftResParagraph2.AddFormatted(draftResStr2, "pt bold heading", 12, true, true, true);

            string draftResStr3 = LetterSentences.Head + " ";
            var draftResParagraph3 = new Paragraph(_doc);
            draftResParagraph3.AddFormatted(draftResStr3, "pt bold heading", 12, false, true, true);

            string draftResStr4 = LetterSentences.DraftResolution2;
            var draftResParagraph4 = new Paragraph(_doc);
            draftResParagraph4.AddFormatted(draftResStr4, "Times New Roman", 14, false, true);
            draftResParagraph4.GetRange().ListFormat.ApplyBulletDefault();

            string draftResStr5 = LetterSentences.DraftResolution3 + " "
                                                                   + LetterSentences.Num + " "
                                                                   + LetterSentences.DraftResolution4;
            var draftResParagraph5 = new Paragraph(_doc);
            draftResParagraph5.AddFormatted(draftResStr5, "Times New Roman", 14, false, true);
            draftResParagraph5.GetRange().ListFormat.ApplyBulletDefault();

            string draftResStr6 = LetterSentences.DraftResolution5;
            var draftResParagraph6 = new Paragraph(_doc);
            draftResParagraph6.AddFormatted(draftResStr6, "Times New Roman", 14, false, true);
            draftResParagraph6.GetRange().ListFormat.ApplyBulletDefault();

            string draftResStr7 =
                LetterSentences.DraftResolution6 + " "
                                                 + _letterData.ApVal + " "
                                                 + LetterSentences.Num + " "
                                                 + _letterData.ApLetterNum + " "
                                                 + LetterSentences.Dated + " "
                                                 + _letterData.ApLetterDate + " "
                                                 + LetterSentences.IssuanceRescript2
                                                 + _letterData.DecisionNumber + " "
                                                 + _letterData.CaseDecisionDate
                                                 + LetterSentences.IssuanceRescript3
                                                 + _letterData.CaseNumber + " "
                                                 + LetterSentences.ForYear + " "
                                                 + _letterData.CaseYear + " " +
                                                 (!_letterData.Guilty.Equals("")
                                                     ? LetterSentences.RescriptSent4 + _letterData.Guilty
                                                     : "");
            var draftResParagraph7 = new Paragraph(_doc);
            draftResParagraph7.AddFormatted(draftResStr7, "Times New Roman", 14, false, true);
            draftResParagraph7.GetRange().ListFormat.ApplyBulletDefault();

            string draftResStr8 = LetterSentences.DraftResolution10 + " "
                                                                    + _letterData.DepartmentName;
            var draftResParagraph8 = new Paragraph(_doc);
            draftResParagraph8.AddFormatted(draftResStr8, "Times New Roman", 14, false, true);
            draftResParagraph8.GetRange().ListFormat.ApplyBulletDefault();

            string draftResStr9 = LetterSentences.DraftResolution11;
            var draftResParagraph9 = new Paragraph(_doc);
            draftResParagraph9.AddFormatted(draftResStr9, "pt bold heading", 12);

            for (int i = 0; i < _letterData.ArticlesNum; i++) {
                if (i == _letterData.ArticlesNum - 1) {
                    string draftResStr10 = _articlesList[i];
                    var draftResParagraph10 = new Paragraph(_doc);
                    draftResParagraph10.AddFormatted(draftResStr10, "pt bold heading", 12, true, true, true);

                    string draftResStr11 = LetterSentences.DraftResolution22;
                    var draftResParagraph11 = new Paragraph(_doc);
                    draftResParagraph11.AddFormatted(draftResStr11, "Times New Roman", 14, false, true);
                    //draftResParagraph17.GetRange().ListFormat.ApplyBulletDefault();
                }
                else {
                    string draftResStr10 = _articlesList[i];
                    var draftResParagraph10 = new Paragraph(_doc);
                    draftResParagraph10.AddFormatted(draftResStr10, "pt bold heading", 12, true, true, true);

                    string draftResStr11 = string.Empty;
                    var draftResParagraph11 = new Paragraph(_doc);
                    draftResParagraph11.AddFormatted(draftResStr11, "Times New Roman", 14, false, true);
                    //draftResParagraph11.GetRange().ListFormat.ApplyBulletDefault();
                }
            }
        }

        protected override void RequestSection() {
        }

        protected override void Greeting() {
            var dateTableParagraph = _doc.Paragraphs.Add();
            int rCount = 1;
            int clCount = 2;

            var dateTable = dateTableParagraph
                .Range.Tables.Add(dateTableParagraph.Range, rCount, clCount);

            //var cResearcher = dateTable.Cell(1, 1);
            //TableParagraph(cResearcher, LetterSentences.Researcher, "pt bold heading", 8);

            //var cName = dateTable.Cell(2, 1);
            //TableParagraph(cName, Properties.Settings.Default.ResearcherName, "pt bold heading", 8);

            var cDate = dateTable.Cell(1, 1);
            cDate.Range.Text = LetterSentences.EditedIn + " " + DateTime.Today.ToShortDateString();
            cDate.Range.Font.NameBi = "PT Bold Heading";
            cDate.Range.Font.SizeBi = 8;
            cDate.Range.ParagraphFormat.SpaceAfter = 0;
            cDate.Range.ParagraphFormat.SpaceBefore = 0;

            var cName = dateTable.Cell(1, 2);
            cName.Range.Text = Properties.Settings.Default.researcherSign;
            cName.Range.Font.NameBi = "PT Bold Heading";
            cName.Range.Font.SizeBi = 8;
            cName.Range.ParagraphFormat.SpaceAfter = 0;
            cName.Range.ParagraphFormat.SpaceBefore = 0;

            dateTable.Columns.AutoFit();

            Paragraph separatorParagraph3 = new Paragraph(_doc);
            separatorParagraph3.AddFormatted(string.Empty, "Times New Roman", 1);
        }

        protected override void SignSection() {
            //Greeting();
            Signature(SignType.HAC, LetterSentences.Head + " " + _letterData.CDptName, _letterData.HeadName);
        }
    }
}
