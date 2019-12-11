using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmDraftResolution : DevExpress.XtraEditors.XtraForm
    {
        public XFrmDraftResolution()
        {
            InitializeComponent();
        }

        private void XFrmDraftResolution_Load(object sender, EventArgs e) {
            dflDraftResolution.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}