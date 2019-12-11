using System;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmGeneralForm : DevExpress.XtraEditors.XtraForm
    {
        public XFrmGeneralForm()
        {
            InitializeComponent();
        }

        private void XFrmGeneralForm_Load(object sender, EventArgs e)
        {
            dflGeneralForm.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
        }
    }
}