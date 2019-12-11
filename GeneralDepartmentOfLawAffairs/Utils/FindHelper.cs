
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.Utils;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.Utils
{
    public class FindHelper {
        private readonly Document _doc;
        private readonly Range _range;
        private readonly Range _rangeEx;
        private FoundInfo _foundInfo;
        public readonly List<FoundInfo> FoundInfoList;


        public FindHelper(Document doc, string searchedForString) {
            _doc = doc ?? throw new ArgumentNullException(nameof(doc));
            _range = doc.Range();
            _rangeEx = doc.Range();
            var find = _range.Find;
            find.Text = searchedForString;
            FoundInfoList = new List<FoundInfo>();

            SetFound(find);
        }

        private void SetFound(Find find) {

            using (WaitDialogForm dlg = new WaitDialogForm("إنتظر من فضلك", ".....جار البحث في المستند")) {
                while (find.Execute()) {
                    _rangeEx.Start = _range.Start;
                    _rangeEx.End = _range.End;
                    _rangeEx.Expand(WdUnits.wdParagraph);
                    _foundInfo = new FoundInfo {
                        FoundInStr = _rangeEx.Text,
                        PageNum = (int) _range.Information[WdInformation.wdActiveEndPageNumber]
                    };

                    FoundInfoList.Add(_foundInfo);


                    //Window window = Globals.ThisAddIn.Application.NewWindow();
                    //window.WindowState = WdWindowState.wdWindowStateNormal;
                

                    /*
                    for (int i = 1; i < 27; i++) {
                        getInfo(_range, (WdInformation)i);
                    }
    
                    Debug.WriteLine("");
                    */
                }
            }
        }

        public override string ToString() {
            StringBuilder strb = new StringBuilder();
            int counter = 1;

            foreach (FoundInfo item in FoundInfoList)
            {
                strb.AppendLine("نتيجة رقم: " + counter);
                strb.AppendLine("النص: " + item.FoundInStr);
                strb.AppendLine("رقم الصفحة: " + item.PageNum);
                counter++;
            }
            
            Debug.WriteLine(strb.ToString());
            return strb.ToString();
        }

        private void GetInfo(Range range, WdInformation info) {
            string result = string.Empty;
            result += $"range.information({info.ToString()}) returns {range.Information[info]}.";
            Debug.WriteLine(result);
        }
    }
}