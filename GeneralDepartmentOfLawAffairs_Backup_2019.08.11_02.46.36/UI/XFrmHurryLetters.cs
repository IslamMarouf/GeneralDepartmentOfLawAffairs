using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmHurryLetters : DevExpress.XtraEditors.XtraForm
    {
        public XFrmHurryLetters()
        {
            InitializeComponent();
        }

        private void XFrmHurryLetters_Load(object sender, EventArgs e) {
            dflHurryLetters.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}