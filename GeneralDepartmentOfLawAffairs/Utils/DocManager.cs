/*
_______________________________________________________________________________________________________________
| Author: manno soli
| File Name: DocManager.cs
| Date Created: 15/8/2019  
| Usage: 
| Copy Right: C  2019
|________________________________________________________________________________________*/

using System.Diagnostics;
using System.Reflection;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Utils {
    public static class DocManager {
        private static Application _app = Globals.ThisAddIn.Application;
        private static Document _secondDoc ;
        private static readonly Document _doc = Globals.ThisAddIn.Application.ActiveDocument;
        private static object _missing = System.Type.Missing;

        public static void OpenDocSideBySide(Document doc) {
            
            //_app.NewWindow();
            //string path = @"C:\Users\manno\Documents\New.docx";
            _secondDoc = _app.Documents.Open(doc.FullName);
            //_app.Documents.Add();
            _app.Windows.Arrange();

            //_doc.Activate();

            object docObject = _secondDoc;
            _secondDoc.Windows.Add();
            _secondDoc.Windows.CompareSideBySideWith(_secondDoc);

            
            Debug.WriteLine(doc.FullName);
            Debug.WriteLine($"Windows count = {_app.Windows.Count}");
            Debug.WriteLine($"Documents count = {_app.Documents.Count}");
            
            //_app.Windows.CompareSideBySideWith(ref docObject);
            //_app.Windows.SyncScrollingSideBySide = false;
            _doc.Activate();

            Debug.WriteLine(doc.Path);
        }

        public static object Missing { get; set; }
    }
}