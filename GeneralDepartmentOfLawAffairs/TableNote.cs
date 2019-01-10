using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Properties;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs {
    public class TableNote : Letter {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public TableNote(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
                LetterSections();
        }

        protected override bool Initialize() {
            FrmTableNote frmTableNote = new FrmTableNote();
            _dialogResult = frmTableNote.ShowDialog();
            _letterData = frmTableNote.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frmTableNote.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Full);
        }

        protected override void DirectionSection() {
            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted(LetterSentences.TableNote1, "pt bold heading", 14, true, true, true);
        }

        protected override void BodySection() {
            var tableParagraph = _doc.Paragraphs.Add();
            int columnsCount = 2;
            int rowsCount = 8;


            var missionTable = tableParagraph
                .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

            for (var i = 1; i <= rowsCount; i++) {
                for (var j = 1; j <= columnsCount; j++) {
                    var c = missionTable.Cell(i, j);

                    if (i == 1 && j == 1) {
                        TableParagraph(c, LetterSentences.To, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 1 && j == 2) {
                        string direction = (_letterData.Index == 0)
                            ? LetterSentences.MRS + " " +
                              Properties.Settings.Default.MinisterName + " - " +
                              LetterSentences.Minister
                            : LetterSentences.Head + " " + LetterSentences.HGC;
                        TableParagraph(c, direction, "pt bold heading", 12);
                    }
                    else if (i == 2 && j == 1) {
                        TableParagraph(c, LetterSentences.From, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 2 && j == 2) {
                        string direction = LetterSentences.CCDepartment + " - " +
                                           LetterSentences.GeneralDepartName;
                        TableParagraph(c, direction, "pt bold heading", 12);
                    }
                    else if (i == 3 && j == 1) {
                        TableParagraph(c, LetterSentences.History, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 3 && j == 2) {
                        string dateStr = "   /" + DateTime.Now.Month + "/" +
                                         DateTime.Now.Year;

                        TableParagraph(c, dateStr, "pt bold heading", 14);
                    }
                    else if (i == 4 && j == 1) {
                        TableParagraph(c, LetterSentences.Subject, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 4 && j == 2) {
                        TableParagraph(c, _letterData.Subject, "times new roman", 14);
                        c.Range.Font.BoldBi = 1;
                    }
                    else if (i == 5 && j == 1) {
                        TableParagraph(c, LetterSentences.Gazzette, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 5 && j == 2) {
                        TableParagraph(c, string.Empty, "times new roman", 14);
                        c.Range.Font.BoldBi = 1;
                    }
                    else if (i == 6 && j == 1) {
                        TableParagraph(c, LetterSentences.ProcAndResult, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 6 && j == 2) {
                        TableParagraph(c, string.Empty, "times new roman", 14);
                        c.Range.Font.BoldBi = 1;
                    }
                    else if (i == 7 && j == 1) {
                        TableParagraph(c, LetterSentences.Openion, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 7 && j == 2) {
                        TableParagraph(c, string.Empty, "times new roman", 14);
                        c.Range.Font.BoldBi = 1;
                    }
                    else if (i == 8 && j == 1) {
                        TableParagraph(c, LetterSentences.Agreement, "PT Bold Heading", 12);
                        c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else if (i == 8 && j == 2) {
                        string direction = (_letterData.Index == 0)
                            ? LetterSentences.TableNote2
                            : LetterSentences.TableNote3;
                        TableParagraph(c, direction, "pt bold heading", 12);
                    }
                }
            }

            //missionTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            missionTable.Range.ParagraphFormat.SpaceAfter = 0;
            missionTable.Columns[1].PreferredWidth = 55.0f;
            missionTable.Columns[2].PreferredWidth = 360.0f;
            missionTable.Borders.Enable = 1;

            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted("", "Times New Roman", 1);
        }

        private void TableParagraph(Cell c, string text, string fontName, float size) {
            c.Range.Text = text;
            c.Range.Font.NameBi = fontName;
            c.Range.Font.SizeBi = size;
            c.Range.ParagraphFormat.SpaceAfter = 0;
            c.Range.ParagraphFormat.SpaceBefore = 0;
        }

        protected override void RequestSection() {
            string requestStr = (_letterData.Index == 0)
                ? LetterSentences.TableNote4
                : LetterSentences.TableNote5;

            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted(requestStr, "pt bold heading", 10, true, true);
        }

        protected override void Greeting() {
            var greetingParagraph = new Paragraph(_doc);
            greetingParagraph.AddFormatted(LetterSentences.Thanks, "Bold Italic Art", 8);

            var tableParagraph = _doc.Paragraphs.Add();
            int rowsCount = 3;
            int columnsCount = 1;

            var dateTable = tableParagraph
                .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

            var cResearcher = dateTable.Cell(1, 1);
            TableParagraph(cResearcher, LetterSentences.Researcher,"pt bold heading", 8);

            var cName = dateTable.Cell(2, 1);
            TableParagraph(cName, Properties.Settings.Default.ResearcherName, "pt bold heading", 8);

            var cDate = dateTable.Cell(3, 1);
            cDate.Range.Text = LetterSentences.EditedIn + " " + DateTime.Today.ToShortDateString();
            cDate.Range.Font.NameBi = "PT Bold Heading";
            cDate.Range.Font.SizeBi = 8;
            cDate.Range.ParagraphFormat.SpaceAfter = 0;
            cDate.Range.ParagraphFormat.SpaceBefore = 0;

            dateTable.Columns.AutoFit();

            Paragraph separatorParagraph = new Paragraph(_doc);
            separatorParagraph.AddFormatted(string.Empty, "Times New Roman", 1);
        }

        protected override void SignSection() {
            base.SignSection();
        }
    }
}
