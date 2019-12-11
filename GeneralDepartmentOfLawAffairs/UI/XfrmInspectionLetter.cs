using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XfrmInspectionLetter : DevExpress.XtraEditors.XtraForm
    {
        public XfrmInspectionLetter()
        {
            InitializeComponent();
        }

        private void XfrmInspectionLetter_Load(object sender, EventArgs e) {
            dflInspectionLetter.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}