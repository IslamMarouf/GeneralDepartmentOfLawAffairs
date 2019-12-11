using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.UI;
using Microsoft.Office.Interop.Word;
using Paragraph = GeneralDepartmentOfLawAffairs.Utils.Paragraph;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    public class CeaseNote : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public CeaseNote(Document doc) : base(doc)
        {
            _doc = doc;
        }

        public override void Write()
        {
            if (Initialize())
            {
                LetterSections();
                DraftResolution();
            }
        }

        protected override bool Initialize()
        {
            XFrmCeaseNote xFrmCeaseNote = new XFrmCeaseNote();
            _dialogResult = xFrmCeaseNote.ShowDialog();
            _letterData = xFrmCeaseNote.FrmLetterData;

            return _dialogResult == DialogResult.OK;
        }

        protected override void HeadingSection()
        {
            Heading(HeadingType.Note);
        }

        protected override void DirectionSection()
        {
            var noteParagraph1 = new Paragraph(_doc);
            noteParagraph1.AddFormatted(LetterSentences.Note, "pt bold heading", 12);

            string str = LetterSentences.CeaseNote1
                         + " "
                         + _letterData.InvestigationNumber + " "
                         + LetterSentences.ForYear + " "
                         + _letterData.InvYear;
            var noteParagraph2 = new Paragraph(_doc);
            noteParagraph2.AddFormatted(str, "pt bold heading", 12);
        }

        protected override void BodySection()
        {
            string str1 = LetterSentences.CeaseNote2
                          + " "
                          + _letterData.DepartmentName + " "
                          + LetterSentences.Num + " "
                          + _letterData.IncomingLetterNumber + " "
                          + LetterSentences.Dated + " "
                          + _letterData.IncomingLetterDate + " "
                          + LetterSentences.CeaseNote3 + " "
                          + _letterData.Subject + " "
                          + LetterSentences.CeaseNote8 + " "
                          + LetterSentences.CeaseNote9;
            var noteParagraph1 = new Paragraph(_doc);
            noteParagraph1.AddFormatted(str1, "Times New Roman", 14, false, true);

            string str2 = LetterSentences.CeaseNote4
                          + " "
                          + _letterData.Name + " - "
                          + LetterSentences.CeaseNote23
                          + _letterData.DepartmentName + " - "
                          + LetterSentences.CeaseNote24 + " "
                          + LetterSentences.CeaseNote7
                          + _letterData.CeaseDays + " "
                          + LetterSentences.CeaseNote8;
            var noteParagraph2 = new Paragraph(_doc);
            noteParagraph2.AddFormatted(str2, "Times New Roman", 14, false, true);
            noteParagraph2.FormattedSentence(
                LetterSentences.CeaseNote4
                + " "
                + _letterData.Name + " - "
                + LetterSentences.CeaseNote23
                + _letterData.DepartmentName + " - ",
                "pt bold heading", 12);

            string str3 = LetterSentences.CeaseNote5;
            var noteParagraph3 = new Paragraph(_doc);
            noteParagraph3.AddFormatted(str3, "pt bold heading", 12, false, true, true);

            var noteParagraph4 = new Paragraph(_doc);
            noteParagraph4.AddFormatted("", "Times New Roman", 14, false, true);
            noteParagraph4.GetRange().ListFormat.ApplyBulletDefault();

            string str5 = LetterSentences.CeaseNote6
                          + " "
                          + _letterData.Name + " "
                          + LetterSentences.CeaseNote7
                          + _letterData.CeaseDays + " "
                          + LetterSentences.CeaseNote8 + " "
                          + LetterSentences.CeaseNote18;
            var noteParagraph5 = new Paragraph(_doc);
            noteParagraph5.AddFormatted(str5, "Times New Roman", 14, false, true);

            string str6 = LetterSentences.CeaseNote25;
            var noteParagraph6 = new Paragraph(_doc);
            noteParagraph6.AddFormatted(str6, "Times New Roman", 14, false, true);

            string str7 = LetterSentences.CeaseNote10;
            var noteParagraph7 = new Paragraph(_doc);
            noteParagraph7.AddFormatted(str7, "Times New Roman", 14, false, true);

            string str8 = LetterSentences.CeaseNote11;
            var noteParagraph8 = new Paragraph(_doc);
            noteParagraph8.AddFormatted(str8, "pt bold heading", 12, false, true, true);

            string str9 = LetterSentences.CeaseNote12 + " " + LetterSentences.Head + _letterData.CDptName;
            var noteParagraph9 = new Paragraph(_doc);
            noteParagraph9.AddFormatted(str9, "Times New Roman", 14, false, true);

            string str10 = LetterSentences.CeaseNote13;
            var noteParagraph10 = new Paragraph(_doc);
            noteParagraph10.AddFormatted(str10, "pt bold heading", 12, true, true, true);

            string str11 = LetterSentences.First + LetterSentences.CeaseNote14;
            var noteParagraph11 = new Paragraph(_doc);
            noteParagraph11.AddFormatted(str11, "Times New Roman", 14, false, true);
            noteParagraph11.FormattedSentence(LetterSentences.First, "pt bold heading", 12);

            string str12 = LetterSentences.CeaseNote15;
            var noteParagraph12 = new Paragraph(_doc);
            noteParagraph12.AddFormatted(str12, "pt bold heading", 12, true, true, true);

            var tableParagraph = _doc.Paragraphs.Add();
            int columnsCount = 2;
            int rowsCount = 1;


            var noteTable = tableParagraph
                .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

            for (var i = 1; i <= rowsCount; i++)
            {
                for (var j = 1; j <= columnsCount; j++)
                {
                    var c = noteTable.Cell(i, j);

                    if (i == 1 && j == 1)
                    {
                        TableParagraph(c, _letterData.Name, "times new roman", 14);
                    }
                    else if (i == 1 && j == 2)
                    {
                        TableParagraph(c,
                            _letterData.GuiltyJob + " " + "ب" + _letterData.DepartmentName + " - " + "ب" +
                            _letterData.GuiltyRank, "times new roman", 14);
                    }
                }
            }

            noteTable.Range.ParagraphFormat.SpaceAfter = 0;

            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted("", "Times New Roman", 1);

            string str13 = LetterSentences.CeaseNote16
                           + " "
                           + _letterData.CeaseMonths + " "
                           + LetterSentences.CeaseNote17 + " "
                           + LetterSentences.CeaseNote26
                           + _letterData.CeaseDays + " "
                           + LetterSentences.CeaseNote8 + " "
                           + LetterSentences.CeaseNote18;
            var noteParagraph13 = new Paragraph(_doc);
            noteParagraph13.AddFormatted(str13, "Times New Roman", 14, false, true);

            string str14 = LetterSentences.Second + LetterSentences.CeaseNote19;
            var noteParagraph14 = new Paragraph(_doc);
            noteParagraph14.AddFormatted(str14, "Times New Roman", 14, false, true);
            noteParagraph14.FormattedSentence(LetterSentences.Second, "pt bold heading", 12);

            string str15 = LetterSentences.Third + LetterSentences.CeaseNote20 + " "
                           + _letterData.CeaseDays + " " + LetterSentences.CeaseNote21;
            var noteParagraph15 = new Paragraph(_doc);
            noteParagraph15.AddFormatted(str15, "Times New Roman", 14, false, true);
            noteParagraph15.FormattedSentence(LetterSentences.Third, "pt bold heading", 12);


            string str16 = LetterSentences.Fourth + LetterSentences.CeaseNote22;
            var noteParagraph16 = new Paragraph(_doc);
            noteParagraph16.AddFormatted(str16, "Times New Roman", 14, false, true);
            noteParagraph16.FormattedSentence(LetterSentences.Fourth, "pt bold heading", 12);
        }

        protected override void RequestSection()
        {
        }

        private void TableParagraph(Cell c, string text, string fontName, float size, int bold = 1)
        {
            c.Range.Text = text;
            c.Range.Font.NameBi = fontName;
            c.Range.Font.SizeBi = size;
            c.Range.Font.BoldBi = bold;
            c.Range.ParagraphFormat.SpaceAfter = 0;
            c.Range.ParagraphFormat.SpaceBefore = 0;
        }

        protected override void Greeting()
        {
            var greetingParagraph = new Paragraph(_doc);
            greetingParagraph.AddFormatted(LetterSentences.Thanks, "Bold Italic Art", 8);

            var tableParagraph = _doc.Paragraphs.Add();
            int rowsCount = 1;
            int columnsCount = 2;

            var dateTable = tableParagraph
                .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

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

            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted(string.Empty, "Times New Roman", 1);
        }

        protected override void SignSection()
        {
            Signature(SignType.ResearcherSign);
        }

        private void DraftResolution()
        {
            if (_letterData.HasDraftResolution)
            {
                Paragraph separatorParagraph = new Paragraph(_doc);
                separatorParagraph.AddFormatted(string.Empty, "Times New Roman", 1);
                separatorParagraph.GetRange().InsertBreak(WdBreakType.wdPageBreak);

                Heading(HeadingType.DraftResolution, "", _letterData.CDptName);

                string draftResStr1 = LetterSentences.DraftResolution1;
                var draftResParagraph1 = new Paragraph(_doc);
                draftResParagraph1.AddFormatted(draftResStr1, "pt bold heading", 12);

                string draftResStr2 = LetterSentences.Num + " (" + "      ) "
                                      + LetterSentences.OutCome + " "
                                      + LetterSentences.Dated + "      /      /" + DateTime.Now.Year;
                var draftResParagraph2 = new Paragraph(_doc);
                draftResParagraph2.AddFormatted(draftResStr2, "pt bold heading", 12, true, true, true);

                string draftResStr3 = LetterSentences.Head + _letterData.CDptName;
                var draftResParagraph3 = new Paragraph(_doc);
                draftResParagraph3.AddFormatted(draftResStr3, "pt bold heading", 12, false, true, true);

                string draftResStr4 = LetterSentences.DraftResolution2;
                var draftResParagraph4 = new Paragraph(_doc);
                draftResParagraph4.AddFormatted(draftResStr4, "Times New Roman", 14, false, true);
                draftResParagraph4.GetRange().ListFormat.ApplyBulletDefault();

                string draftResStr5 = LetterSentences.DraftResolution3
                                      + " "
                                      + LetterSentences.Num + " "
                                      + LetterSentences.DraftResolution4;
                var draftResParagraph5 = new Paragraph(_doc);
                draftResParagraph5.AddFormatted(draftResStr5, "Times New Roman", 14, false, true);
                draftResParagraph5.GetRange().ListFormat.ApplyBulletDefault();

                string draftResStr6 = LetterSentences.DraftResolution5;
                var draftResParagraph6 = new Paragraph(_doc);
                draftResParagraph6.AddFormatted(draftResStr6, "Times New Roman", 14, false, true);
                draftResParagraph6.GetRange().ListFormat.ApplyBulletDefault();

                string draftResStr7 = LetterSentences.DraftResolution6
                                      + " "
                                      + LetterSentences.GeneralDepartName + " "
                                      + LetterSentences.Num + "      "
                                      + LetterSentences.Dated + "  /  /" +
                                      DateTime.Now.Year + " "
                                      + LetterSentences.DraftResolution7 + " "
                                      + LetterSentences.Num + "   /" +
                                      DateTime.Now.Year
                                      + LetterSentences.DraftResolution8 + " "
                                      + _letterData.Name + " "
                                      + LetterSentences.DraftResolution9;
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

                string draftResStr10 = LetterSentences.DraftResolution12;
                var draftResParagraph10 = new Paragraph(_doc);
                draftResParagraph10.AddFormatted(draftResStr10, "pt bold heading", 12, true, true, true);


                string draftResStr11 = LetterSentences.CeaseNote14;
                var draftResParagraph11 = new Paragraph(_doc);
                draftResParagraph11.AddFormatted(draftResStr11, "Times New Roman", 14, false, true);
                //draftResParagraph11.GetRange().ListFormat.ApplyBulletDefault();

                string str12 = LetterSentences.CeaseNote15;
                var noteParagraph12 = new Paragraph(_doc);
                noteParagraph12.AddFormatted(str12, "pt bold heading", 12, true, true, true);

                var tableParagraph = _doc.Paragraphs.Add();
                int columnsCount = 2;
                int rowsCount = 1;


                var noteTable = tableParagraph
                    .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                for (var i = 1; i <= rowsCount; i++)
                {
                    for (var j = 1; j <= columnsCount; j++)
                    {
                        var c = noteTable.Cell(i, j);

                        if (i == 1 && j == 1)
                        {
                            TableParagraph(c, _letterData.Name, "times new roman", 14);
                        }
                        else if (i == 1 && j == 2)
                        {
                            TableParagraph(c,
                                _letterData.GuiltyJob + " " + "ب" + _letterData.DepartmentName + " - " + "ب" +
                                _letterData.GuiltyRank, "times new roman", 14);
                        }
                    }
                }

                noteTable.Range.ParagraphFormat.SpaceAfter = 0;

                Paragraph separatorParagraph1 = new Paragraph(_doc);
                separatorParagraph1.AddFormatted("", "Times New Roman", 1);

                string str13 = LetterSentences.CeaseNote16
                               + " "
                               + LetterSentences.CeaseNote17 + " "
                               + LetterSentences.CeaseNote26
                               + _letterData.CeaseDays + " "
                               + LetterSentences.CeaseNote8 + " "
                               + LetterSentences.CeaseNote18;
                var noteParagraph13 = new Paragraph(_doc);
                noteParagraph13.AddFormatted(str13, "Times New Roman", 14, false, true);


                string draftResStr12 = LetterSentences.DraftResolution13;
                var draftResParagraph12 = new Paragraph(_doc);
                draftResParagraph12.AddFormatted(draftResStr12, "pt bold heading", 12, true, true, true);

                string draftResStr13 = LetterSentences.DraftResolution23
                                       + LetterSentences.DraftResolution24;
                var draftResParagraph13 = new Paragraph(_doc);
                draftResParagraph13.AddFormatted(draftResStr13, "Times New Roman", 14, false, true);
                //draftResParagraph13.GetRange().ListFormat.ApplyBulletDefault();

                string draftResStr14 = LetterSentences.DraftResolution14;
                var draftResParagraph14 = new Paragraph(_doc);
                draftResParagraph14.AddFormatted(draftResStr14, "pt bold heading", 12, true, true, true);

                string draftResStr15 = LetterSentences.CeaseNote20
                                       + " "
                                       + _letterData.CeaseDays
                                       + LetterSentences.CeaseNote21;
                var draftResParagraph15 = new Paragraph(_doc);
                draftResParagraph15.AddFormatted(draftResStr15, "Times New Roman", 14, false, true);
                //draftResParagraph15.GetRange().ListFormat.ApplyBulletDefault();

                string draftResStr16 = LetterSentences.DraftResolution15;
                var draftResParagraph16 = new Paragraph(_doc);
                draftResParagraph16.AddFormatted(draftResStr16, "pt bold heading", 12, true, true, true);

                string draftResStr17 = LetterSentences.DraftResolution22;
                var draftResParagraph17 = new Paragraph(_doc);
                draftResParagraph17.AddFormatted(draftResStr17, "Times New Roman", 14, false, true);
                //draftResParagraph17.GetRange().ListFormat.ApplyBulletDefault();

                Paragraph separatorParagraph2 = new Paragraph(_doc);
                separatorParagraph2.AddFormatted(string.Empty, "Times New Roman", 1);

                var dateTaable = _doc.Paragraphs.Add();
                int rCount = 1;
                int clCount = 2;

                var dateTable = dateTaable
                    .Range.Tables.Add(dateTaable.Range, rCount, clCount);

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
                            TableParagraph(c, LetterSentences.Head + _letterData.CDptName, "pt bold heading", 12);
                        }
                        else if ((i == 3) && (j == 3))
                        {
                            TableParagraph(c, _letterData.HeadName, "pt bold heading", 12);
                        }
                    }
                }

                singParagraph.Range.ParagraphFormat.SpaceAfter = 0;
                singParagraph.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            }
        }
    }
}