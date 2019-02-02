using System;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs {
    class MissionLetter : Letter {
        private readonly Document _doc;

        public MissionLetter(Document doc) : base(doc) {
            _doc = doc;
        }

        public override void Write() {
            LetterSections();
        }

        protected override bool Initialize() {
            return true;
        }

        protected override void HeadingSection() {
            Heading(HeadingType.Mission);
        }

        protected override void DirectionSection() {
            Paragraph typeParagraph = new Paragraph(_doc);
            typeParagraph.AddFormatted(LetterSentences.Mission, "PT Bold Heading", 11, true, true);
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
                        TableParagraph(c, LetterSentences.EmpName, "PT Bold Heading", 10);
                    }
                    else if (i == 2 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission1, "PT Bold Heading", 10);
                    }
                    else if (i == 3 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission2, "PT Bold Heading", 10);
                    }
                    else if (i == 4 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission3, "PT Bold Heading", 10);
                    }
                    else if (i == 5 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission4, "PT Bold Heading", 10);
                    }
                    else if (i == 6 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission5, "PT Bold Heading", 10);
                    }
                    else if (i == 7 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission6, "PT Bold Heading", 10);
                    }
                    else if (i == 8 && j == 1) {
                        TableParagraph(c, LetterSentences.Mission7, "PT Bold Heading", 10);
                    }
                    else if (i == 8 && j == 2) {
                        string periodStr = LetterSentences.From + " " + "   /" +
                                           DateTime.Now.Month + "/" +
                                           DateTime.Now.Year + "        " +
                                           LetterSentences.To + " " + "   /" +
                                           DateTime.Now.Month + "/" +
                                           DateTime.Now.Year;
                        TableParagraph(c, periodStr, "PT Bold Heading", 10);
                    }
                }
            }

            missionTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            missionTable.Range.ParagraphFormat.SpaceAfter = 0;
            missionTable.Columns[1].AutoFit();

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
            //
        }

        protected override void Greeting() {
            //
        }

        protected override void SignSection() {
            Signature(SignType.GeneralManager);
        }
    }
}
