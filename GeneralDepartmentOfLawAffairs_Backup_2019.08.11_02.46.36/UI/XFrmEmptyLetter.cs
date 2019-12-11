using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmEmptyLetter : XFrmGeneralForm
    {
        public XFrmEmptyLetter()
        {
            InitializeComponent();
        }

        private void XFrmEmptyLetter_Load(object sender, EventArgs e) {
            dflEmptyLetter.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}