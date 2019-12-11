using System;
using System.Windows.Forms;
using DevExpress.Skins;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI {
    public partial class XFrmSettings : DevExpress.XtraEditors.XtraForm {
        public XFrmSettings() {
            InitializeComponent();
        }

        private void XFrmSettings_Load(object sender, EventArgs e) {
            foreach (SkinContainer skin in SkinManager.Default.Skins) {
                cmbxSkins.Properties.Items.Add(skin.SkinName);
            }

            cmbxSkins.Text = Settings.Default.CurrentSkinName;
            txtResearcherName.Text = Settings.Default.ResearcherName;
            txtDepartmentName.Text = Settings.Default.DepartmentName;
            txtJobRank.Text = Settings.Default.JobRank;

            vpSettings.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (!vpSettings.Validate()) {
                return;
            }

            // 
            Settings.Default.CurrentSkinName = cmbxSkins.Text;
            Settings.Default.ResearcherName = txtResearcherName.Text;
            Settings.Default.DepartmentName = txtDepartmentName.Text;
            Settings.Default.JobRank = txtJobRank.Text;


            // Important to save changes.
            Settings.Default.Save();

            Close();
        }

        private void cmbxSkins_SelectedIndexChanged(object sender, EventArgs e) {
            dflSettings.LookAndFeel.SkinName = cmbxSkins.Text;
        }

        private void txtResearcherName_EditValueChanged(object sender, EventArgs e) {
            vpSettings.Validate();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void txtDepartmentName_EditValueChanged(object sender, EventArgs e) {
            vpSettings.Validate();
        }

        private void txtJobRank_EditValueChanged(object sender, EventArgs e) {
            vpSettings.Validate();
        }

        private void tpResearcher_Paint(object sender, PaintEventArgs e) {
        }
    }
}