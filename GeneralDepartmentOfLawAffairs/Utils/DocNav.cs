/*
_______________________________________________________________________________________________________________
| Author: manno soli
| File Name: DocNav.cs
| Date Created: 16/8/2019  
| Usage: 
| Copy Right: C  2019
|_________________________________________________________________________________*/

using System.Diagnostics;
using DevExpress.XtraPrinting.Native;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Utils {
    public static class DocNav {
        private static Application Application { get; set; }
        private static Document Document { get; set; }
        private static object What {get; set;}

        private static object Which { get; set; }
        private static object PageNum { get; set; }
        private static object ParagraphNum { get; set; }

        public static void GoToLastPage(Document doc) {
            Document = doc;
            What = WdGoToItem.wdGoToPage;
            Which = WdGoToDirection.wdGoToAbsolute;
            PageNum = Document.Range().Information[WdInformation.wdNumberOfPagesInDocument];

            Application.Selection.GoTo(What, Which, PageNum);
        }

        public static void GoToPage(Document doc, int pageNumber) {
            Document = doc;
            What = WdGoToItem.wdGoToPage;
            Which = WdGoToDirection.wdGoToAbsolute;
            PageNum = pageNumber;
            
            Application.Selection.GoTo(What, Which, PageNum);
        }

        public static void GoToEnd() {
            var pageCount = (int)Document.Range().Information[WdInformation.wdNumberOfPagesInDocument];

            var count = (int)Application.Selection.EndKey(WdUnits.wdStory);

            Debug.WriteLine(count);
            if (pageCount == 1 && count == 0) 
                return;
            
            Application.Selection.InsertBreak(WdBreakType.wdPageBreak);
        }

        public static void GoToStart() {
            Application.Selection.HomeKey(WdUnits.wdStory);
        }

        public static void GoToLastParagraph(Document doc) {
            Document = doc;
        }

        static DocNav() {
            Application = Globals.ThisAddIn.Application;
            Document = Globals.ThisAddIn.Application.ActiveDocument;
        }
    }
}