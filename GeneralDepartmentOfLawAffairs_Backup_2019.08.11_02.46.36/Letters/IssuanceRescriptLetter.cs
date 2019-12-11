using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using GeneralDepartmentOfLawAffairs.Utils;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Letters {
    public class IssuanceRescriptLetter : Letter {
        private readonly Word.Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;
        private readonly List<string> _articlesList;

        public IssuanceRescriptLetter(Word.Document doc) : base(doc) {
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
            if (Initialize()) {
                LetterSections();
                DraftRes();
            }
        }

        protected override bool Initialize() {
            XFrmIssuanceRescriptLetter xFrmIssuanceRescriptLetter = new XFrmIssuanceRescriptLetter();
            _dialogResult = xFrmIssuanceRescriptLetter.ShowDialog();
            _letterData = xFrmIssuanceRescriptLetter.FrmLetterData;

            return _dialogResult == DialogResult.OK;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Typical);
        }

        protected override void DirectionSection() {
            var strDirection = _letterData.MrMsVal +
                               _letterData.Receiver +
                               _letterData.ReceiverDeptName;

            var recParagraph = new Paragraph(_doc);
            recParagraph.AddFormatted(strDirection, "PT Bold Heading", 14);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);
        }

        protected override void BodySection() {
            string strBody1 = LetterSentences.IssuanceRescript1 +
                              _letterData.ApVal + " " +
                              LetterSentences.Num + " " +
                              _letterData.ApLetterNum + " " +
                              LetterSentences.Dated + " " +
                              _letterData.ApLetterDate + " " +
                              LetterSentences.IssuanceRescript2 +
                              _letterData.DecisionNumber + " " +
                              _letterData.CaseDecisionDate +
                              LetterSentences.IssuanceRescript3 +
                              _letterData.CaseNumber + " " +
                              LetterSentences.ForYear + " " +
                              _letterData.CaseYear + " " +
                              (!_letterData.Guilty.Equals("")
                                  ? LetterSentences.RescriptSent4 + _letterData.Guilty
                                  : "");

            Paragraph body1Paragraph = new Paragraph(_doc);
            body1Paragraph.AddFormatted(strBody1, "Times New Roman", 14, false, true);
            body1Paragraph.GetRange().ListFormat.ApplyBulletDefault();

            string strBody2 = LetterSentences.IssuanceRescript4;
            Paragraph body2Paragraph = new Paragraph(_doc);
            body2Paragraph.AddFormatted(strBody2, "Times New Roman", 14, false, true);
            body2Paragraph.GetRange().ListFormat.ApplyBulletDefault();
        }

        protected override void RequestSection() {
            Paragraph request = new Paragraph(_doc);
            request.AddFormatted(LetterSentences.IssuanceRescript5, "PT Bold Heading", 11, false);
        }

        protected override void SentPhotoCopy() {

            string lineSeparator = "___________________________________________________________________________________\n";
            var p = new Paragraph(_doc);
            p.AddFormatted(lineSeparator, "times new roman", 10);

            string strDirection;
            var advisorParagraph = new Paragraph(_doc);
            advisorParagraph.AddFormatted(LetterSentences.Advisor +
                                          LetterSentences.Advisor2,
                "PT Bold Heading", 11);

            var advisor2Paragraph = new Paragraph(_doc);
            advisor2Paragraph.AddFormatted(LetterSentences.Advisor3 +
                                           _letterData.SentPhotoCopyReceiver +
                                           _letterData.SentPhotoCopyReceiverDptName,
                "PT Bold Heading", 11);

            var index = _letterData.SentPhotoCopyApNames.IndexOf(_letterData.SentPhotoCopyReceiverDptName);
            strDirection = _letterData.SentPhotoCopyApAddresses[index];
            var advisor3Paragraph = new Paragraph(_doc);
            advisor3Paragraph.AddFormatted(strDirection, "PT Bold Heading", 11);

            var greetParagraph = new Paragraph(_doc);
            greetParagraph.AddFormatted(LetterSentences.greet, "Bold Italic Art", 8);

            var strBody = LetterSentences.IssuanceRescript6 +
                          _letterData.ApLetterNum + " " +
                          LetterSentences.Dated + " " +
                          _letterData.ApLetterDate + " " +
                          LetterSentences.IssuanceRescript7;

            Paragraph body = new Paragraph(_doc);
            body.AddFormatted(strBody, "PT Bold Heading", 11, false);
            body.GetRange().ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

            SignSection();
        }

        private void TableParagraph(Word.Cell c, string text, string fontName, float size, int bold = 1)
        {
            c.Range.Text = text;
            c.Range.Font.NameBi = fontName;
            c.Range.Font.SizeBi = size;
            c.Range.Font.BoldBi = bold;
            c.Range.ParagraphFormat.SpaceAfter = 0;
            c.Range.ParagraphFormat.SpaceBefore = 0;
        }

        private void DraftRes()
        {
            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted(string.Empty, "Times New Roman", 1);
            separatorParagraph.GetRange().InsertBreak(Word.WdBreakType.wdPageBreak);

            Heading(HeadingType.DraftResolution, "", _letterData.CDptName);

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
                                                 + LetterSentences.Organisation + " "
                                                 + LetterSentences.AdministrativeProsecution
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

            for (int i = 0; i < _letterData.ArticlesNum; i++)
            {
                if (i == _letterData.ArticlesNum - 1)
                {
                    string draftResStr10 = _articlesList[i];
                    var draftResParagraph10 = new Paragraph(_doc);
                    draftResParagraph10.AddFormatted(draftResStr10, "pt bold heading", 12, true, true, true);

                    string draftResStr11 = LetterSentences.DraftResolution22;
                    var draftResParagraph11 = new Paragraph(_doc);
                    draftResParagraph11.AddFormatted(draftResStr11, "Times New Roman", 14, false, true);
                    //draftResParagraph17.GetRange().ListFormat.ApplyBulletDefault();
                }
                else
                {
                    string draftResStr10 = _articlesList[i];
                    var draftResParagraph10 = new Paragraph(_doc);
                    draftResParagraph10.AddFormatted(draftResStr10, "pt bold heading", 12, true, true, true);

                    string draftResStr11 = string.Empty;
                    var draftResParagraph11 = new Paragraph(_doc);
                    draftResParagraph11.AddFormatted(draftResStr11, "Times New Roman", 14, false, true);
                    //draftResParagraph11.GetRange().ListFormat.ApplyBulletDefault();
                }
            }

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

            var singTable = _doc.Paragraphs.Add();
            int clsCount = 3;
            int rsCount = 3;

            var singParagraph = singTable
                .Range.Tables.Add(singTable.Range, rsCount, clsCount);

            for (var i = 1; i <= rsCount; i++)
            {
                for (var j = 1; j <= clsCount; j++)
                {
                    var c = singParagraph.Cell(i, j);

                    if ((i == 1) && (j == 3))
                    {
                        TableParagraph(c, LetterSentences.Head + " " + _letterData.CDptName, "pt bold heading", 12);
                    }
                    else if ((i == 3) && (j == 3))
                    {
                        TableParagraph(c, _letterData.HeadName, "pt bold heading", 12);
                    }
                }
            }

            singParagraph.Range.ParagraphFormat.SpaceAfter = 0;
            singParagraph.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        }
    }
}