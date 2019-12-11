using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmNominationLetter : DevExpress.XtraEditors.XtraForm
    {
        public XFrmNominationLetter()
        {
            InitializeComponent();
        }

        private void XFrmNominationLetter_Load(object sender, EventArgs e) {
            dflNominationLetter.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}