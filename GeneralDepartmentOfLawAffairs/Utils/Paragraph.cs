using System;
using Word = Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Utils {
    internal class Paragraph {
        private readonly Word.Document _doc;
        private Word.Paragraph _paragraph;
        private Word.Range _range;

        public Paragraph(Word.Document doc) {
            _doc = doc;
            _paragraph = _doc.Paragraphs.Add();
            _range = _paragraph.Range;
        }

        public string Content { get; set; }

        public Word.WdParagraphAlignment Alignment { get; set; }

        public string FontName { get; set; }

        public float FontSize { get; set; }

        public Word.WdColorIndex FontColor { get; set; }

        public Word.Range GetRange() {
            return _range;
        }

        /// <summary>
        ///     Adds new paragraph containing the supplied text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="fontName"></param>
        /// <param name="fontColor"></param>
        /// <param name="fontSize"></param>
        /// <returns></returns>
        public void Add(string text, string fontName, Word.WdColorIndex fontColor,
            float fontSize) {
            Content = text;
            _range.Text = Content;
            _range.InsertParagraphAfter();
            FontSize = fontSize;
            _range.Font.SizeBi = FontSize;
            FontName = fontName;
            _range.Font.NameBi = FontName;
            FontColor = fontColor;
            _range.Font.ColorIndexBi = FontColor;
        }

        public void AddFormatted(
            string text,
            string fontName,
            float fontSize,
            bool centered = true,
            bool bold = false,
            bool underline = false,
            Word.WdColorIndex fontColor = Word.WdColorIndex.wdBlack,
            float spaceAfter = 0) {
            Content = text;
            _range.Text = Content;
            _range.InsertParagraphAfter();
            FontSize = fontSize;
            _range.Font.SizeBi = FontSize;
            FontName = fontName;
            _range.Font.NameBi = FontName;
            FontColor = fontColor;
            _range.Font.ColorIndexBi = FontColor;

            _range.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphJustify;

            if (centered) _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


            if (bold) {
                _range.Font.BoldBi = 1;
            }

            if (underline) _range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;

            _range.ParagraphFormat.SpaceAfter = spaceAfter;
        }

        /// <summary>
        ///     Adds new paragraph containing date.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="fontName"></param>
        /// <param name="fontColor"></param>
        /// <param name="fontSize"></param>
        /// <returns></returns>
        public void Date(Word.Range range, string fontName, Word.WdColorIndex fontColor, float fontSize) {
            _paragraph = _doc.Paragraphs.Add(range);
            _range = _paragraph.Range;
            _range.Font.NameBi = fontName;
            _range.Font.ColorIndexBi = fontColor;
            _range.Font.SizeBi = fontSize;
            _range.InsertDateTime();
        }

        public void FormattedSentence(
            string text,
            string fontName,
            float fontSize,
            Word.WdColorIndex fontColor = Word.WdColorIndex.wdBlack,
            bool underline = false,
            bool bold = false) {
            // Remember the paragraph's start and end position.
            int start = _range.Start;
            int end = _range.End;

            Word.Range range = _range;

            // MessageBox.Show(start + " " + end, "object");

            Word.Find find = range.Find;
            find.Text = text;

            find.MatchWholeWord = false;

            if (find.Execute()) {
                // MessageBox.Show($"start {range.Start}, end {range.End}");
            }

            range.Font.NameBi = fontName;
            range.Font.SizeBi = fontSize;
            range.Font.ColorIndexBi = fontColor;
            if (underline) range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
            if (bold) {
                range.Font.BoldBi = 1;
            }

            // Return back to the paragraph's original start and end position.
            _range.Start = start;
            _range.End = end;
        }

        public static string AddFullDate(DateTime date) {
            string dayName = "";

            switch (date.DayOfWeek.ToString()) {
                case "Saturday":
                    dayName = LetterSentences.Saturday;
                    break;
                case "Sunday":
                    dayName = LetterSentences.Sunday;
                    break;
                case "Monday":
                    dayName = LetterSentences.Monday;
                    break;
                case "Tuesday":
                    dayName = LetterSentences.Tuesday;
                    break;
                case "Wednesday":
                    dayName = LetterSentences.Wednesday;
                    break;
                case "Thursday":
                    dayName = LetterSentences.Thursday;
                    break;
                case "Friday":
                    dayName = LetterSentences.Friday;
                    break;
            }

            return dayName + "الموافق " + date.ToShortDateString() + " ";
        }
    }
}