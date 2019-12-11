using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmReport : DevExpress.XtraEditors.XtraForm
    {
        public XFrmReport()
        {
            InitializeComponent();
        }

        private void XFrmReport_Load(object sender, EventArgs e) {
            dflReport.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}