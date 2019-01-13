using System;
using Microsoft.Office.Interop.Word;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs
{
    public abstract class Letter {
        private readonly Document _doc;

        protected Letter(Document doc) {
            _doc = doc;
        }

        public virtual void Write() {
        }

        protected virtual void DisplayResult() {
        }

        protected abstract bool Initialize();

        protected virtual void HeadingSection() {
            Heading(HeadingType.Typical);
        }

        protected abstract void DirectionSection();

        protected abstract void BodySection();

        protected abstract void RequestSection();

        protected virtual void Greeting() {
            var greetingParagraph = new Paragraph(_doc);
            greetingParagraph.Add(LetterSentences.Greeting, "Bold Italic Art", WdColorIndex.wdBlack, 8);
            greetingParagraph.GetRange().ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            greetingParagraph.GetRange().ParagraphFormat.SpaceAfter = 0;

            var tableParagraph = _doc.Paragraphs.Add();
            int rowsCount = 3;
            int columnsCount = 1;

            var dateTable = tableParagraph
                .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

            var cResearcher = dateTable.Cell(1, 1);
            TableParagraph(cResearcher, LetterSentences.Researcher, 8);

            var cName = dateTable.Cell(2, 1);
            TableParagraph(cName, Settings.Default.ResearcherName, 8);

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

        protected virtual void SignSection() {
            Signature(SignType.RegularSign);
        }

        protected virtual void SentPhotoCopy() {
        }

        private void TableParagraph(Cell c, string text, float size) {
            c.Range.Text = text;
            c.Range.Font.NameBi = "PT Bold Heading";
            c.Range.Font.SizeBi = size;
            c.Range.ParagraphFormat.SpaceAfter = 0;
            c.Range.ParagraphFormat.SpaceBefore = 0;
        }

        protected void Signature(SignType sign) {
            Greeting();

            // Table.
            var tableParagraph = _doc.Paragraphs.Add();
            Table table;
            int columnsCount;
            int rowsCount;

            switch (sign) {
                case SignType.RegularSign:

                    columnsCount = 2;
                    rowsCount = 3;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if (i == 1 && j == 1) {
                                TableParagraph(c, LetterSentences.CDepartment, 12);
                            }
                            else if (i == 1 && j == 2) {
                                TableParagraph(c, LetterSentences.GeneralManager, 12);
                            }
                            else if (i == 3 && j == 1) {
                                TableParagraph(c, Settings.Default.ChDeptName, 12);
                            }
                            else if (i == 3 && j == 2) {
                                TableParagraph(c, Settings.Default.GMName, 12);
                            }
                        }

                    //table.TableDirection = WdTableDirection.wdTableDirectionLtr;

                    table.Columns[2].AutoFit();
                    table.Range.ParagraphFormat.Alignment =
                        WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Rows.HorizontalPosition = 0;
                    table.Rows.RelativeHorizontalPosition = 
                        WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin;
                    // 1 Centimeter = 28.34 Points so -1.42 cm = -40.251969 points.
                    // For an approximate result, divide the length value (in Points)
                    // by 28.346.

                    /* hint
                     1 pixel (X) = 0.0264583333 cm
                     1 cm = 37.7952755906 pixel (X)
                    */
                    table.Rows.VerticalPosition = -40.251969f; 
                    table.Rows.RelativeVerticalPosition =
                        WdRelativeVerticalPosition.wdRelativeVerticalPositionParagraph;

                    break;
                case SignType.ResearcherSign:
                    columnsCount = 3;
                    rowsCount = 3;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 3)) {
                                TableParagraph(c, LetterSentences.Researcher, 12);
                                c.Range.ParagraphFormat.Alignment =
                                    WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 3) && (j == 3)) {
                                TableParagraph(c, Settings.Default.ResearcherName, 12);
                                c.Range.ParagraphFormat.Alignment =
                                    WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                        }

                    break;
                case SignType.GmAndHca:

                    break;
                case SignType.GeneralManager:
                    columnsCount = 3;
                    rowsCount = 3;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 3)) {
                                TableParagraph(c, LetterSentences.GeneralManager, 10);
                                c.Range.ParagraphFormat.Alignment =
                                    WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 3) && (j == 3)) {
                                TableParagraph(c, Settings.Default.GMName, 10);
                                c.Range.ParagraphFormat.Alignment =
                                    WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                        }

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(sign), sign, null);
            }
        }

        private const string CentralDepartmentName = "الإدارة المركزية لشئون مكتب الوزير";

        protected void Heading(HeadingType hType, string attachmentsStr = "", string cDptName = CentralDepartmentName) {
            // Table.
            var tableParagraph = _doc.Paragraphs.Add();
            Table table;
            int columnsCount;
            int rowsCount;

            switch (hType) {
                case HeadingType.Typical:

                    columnsCount = 3;
                    rowsCount = 5;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 1)) {
                                c.Range.InlineShapes.AddPicture(@"C:\Windows\Temp\eagle.png");
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                c.Range.ParagraphFormat.SpaceAfter = 0;
                            }
                            else if ((i == 2) && (j == 1)) {
                                TableParagraph(c, LetterSentences.MinistryMame, 9);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if (i == 2 && j == 3) {
                                TableParagraph(c, LetterSentences.OutCome, 8);
                                c.Range.Borders.Enable = 1;
                            }
                            else if ((i == 3) && (j == 1)) {
                                TableParagraph(c, cDptName, 8);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if (i == 3 && j == 3) {
                                string date = LetterSentences.Dated + "       " + "/" + "       " + "/" +
                                              DateTime.Now.Year;
                                TableParagraph(c, date, 8);
                                c.Range.Borders.Enable = 1;
                            }
                            else if ((i == 4) && (j == 1)) {
                                TableParagraph(c, LetterSentences.GeneralDepartName, 8);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 4) && (j == 3)) {
                                var str = LetterSentences.Attachments + attachmentsStr;
                                TableParagraph(c, str, 8);
                                c.Range.Borders.Enable = 1;
                            }
                            else if ((i == 5) && (j == 1)) {
                                TableParagraph(c, LetterSentences.DepartmentName, 8);
                                c.Range.Font.Underline = WdUnderline.wdUnderlineSingle;
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                        }

                    //table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Range.ParagraphFormat.SpaceAfter = 0;
                    break;

                case HeadingType.Note:

                    columnsCount = 3;
                    rowsCount = 5;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++)
                        {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 1))
                            {
                                c.Range.InlineShapes.AddPicture(@"C:\Windows\Temp\eagle.png");
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                c.Range.ParagraphFormat.SpaceAfter = 0;
                            }
                            else if ((i == 2) && (j == 1))
                            {
                                TableParagraph(c, LetterSentences.MinistryMame, 9);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 3) && (j == 1))
                            {
                                TableParagraph(c, cDptName, 8);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 4) && (j == 1))
                            {
                                TableParagraph(c, LetterSentences.GeneralDepartName, 8);
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                            else if ((i == 5) && (j == 1))
                            {
                                TableParagraph(c, LetterSentences.DepartmentName, 8);
                                c.Range.Font.Underline = WdUnderline.wdUnderlineSingle;
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            }
                        }

                    //table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Range.ParagraphFormat.SpaceAfter = 0;
                    break;

                case HeadingType.Notification:

                    columnsCount = 3;
                    rowsCount = 4;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 1)) {
                                TableParagraph(c, LetterSentences.MinistryMame, 9);
                            }
                            else if ((i == 2) && (j == 1)) {
                                TableParagraph(c, LetterSentences.CentralDepartName, 8);
                            }
                            else if ((i == 3) && (j == 1)) {
                                TableParagraph(c, LetterSentences.GeneralDepartName, 8);
                            }
                            else if ((i == 4) && (j == 1)) {
                                TableParagraph(c, LetterSentences.DeptAddress, 8);
                                c.Range.Font.Underline = WdUnderline.wdUnderlineSingle;
                            }
                            else if ((i == 1) && (j == 3)) {
                                TableParagraph(c, LetterSentences.OutCome, 8);
                            }
                            else if ((i == 2) && (j == 3)) {
                                TableParagraph(c, LetterSentences.History, 8);
                            }
                            else if ((i == 2) && (j == 2)) {
                                TableParagraph(c, LetterSentences.InvNo + attachmentsStr, 8);
                            }
                        }

                    table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Range.ParagraphFormat.SpaceAfter = 0;

                    break;

                case HeadingType.Mission:

                    columnsCount = 3;
                    rowsCount = 4;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 1)) {
                                TableParagraph(c, LetterSentences.MinistryMame, 9);
                            }
                            else if ((i == 2) && (j == 1)) {
                                TableParagraph(c, LetterSentences.CentralDepartName, 8);
                            }
                            else if ((i == 3) && (j == 1)) {
                                TableParagraph(c, LetterSentences.GeneralDepartName, 8);
                            }
                            else if ((i == 4) && (j == 1)) {
                                TableParagraph(c, LetterSentences.DeptAddress, 8);
                                c.Range.Font.Underline = WdUnderline.wdUnderlineSingle;
                            }
                        }

                    table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Range.ParagraphFormat.SpaceAfter = 0;

                    break;

                case HeadingType.Full:

                    columnsCount = 3;
                    rowsCount = 6;
                    table = tableParagraph
                        .Range.Tables.Add(tableParagraph.Range, rowsCount, columnsCount);

                    for (var i = 1; i <= rowsCount; i++)
                        for (var j = 1; j <= columnsCount; j++) {
                            var c = table.Cell(i, j);

                            if ((i == 1) && (j == 1)) {
                                c.Range.InlineShapes.AddPicture(@"C:\Windows\Temp\eagle.png");
                                c.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                                c.Range.ParagraphFormat.SpaceAfter = 0;
                            }
                            else if ((i == 2) && (j == 1)) {
                                TableParagraph(c, LetterSentences.arabRepublicOfEgypt, 9);
                            }
                            else if ((i == 3) && (j == 1)) {
                                TableParagraph(c, LetterSentences.MinistryMame, 8);
                            }
                            else if ((i == 4) && (j == 1)) {
                                TableParagraph(c, LetterSentences.CentralDepartName, 8);
                            }
                            else if ((i == 4) && (j == 3)) {
                                var str = LetterSentences.Attachments + attachmentsStr;
                                TableParagraph(c, str, 8);
                            }
                            else if ((i == 5) && (j == 1)) {
                                TableParagraph(c, LetterSentences.GeneralDepartName, 8);
                            }
                            else if ((i == 6) && (j == 1)) {
                                TableParagraph(c, LetterSentences.DepartmentName, 8);
                                c.Range.Font.Underline = WdUnderline.wdUnderlineSingle;
                            }
                        }

                    table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Range.ParagraphFormat.SpaceAfter = 0;
                    break;
            }
        }

        protected void LetterSections() {
            HeadingSection();
            DirectionSection();
            BodySection();
            RequestSection();
            SignSection();
            SentPhotoCopy();
        }

        protected enum SignType {
            GmAndHca,
            ResearcherSign,
            GeneralManager,
            RegularSign
        }

        protected enum HeadingType {
            Typical,
            Note,
            Notification,
            Mission,
            Full
        }
    }
}
