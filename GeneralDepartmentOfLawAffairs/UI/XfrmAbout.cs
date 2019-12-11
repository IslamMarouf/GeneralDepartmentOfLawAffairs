using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GeneralDepartmentOfLawAffairs.Properties;
using GeneralDepartmentOfLawAffairs.Utils;

namespace GeneralDepartmentOfLawAffairs.UI {
    public partial class XfrmAbout : DevExpress.XtraEditors.XtraForm {
        public XfrmAbout() {
            InitializeComponent();
        }

        private void XfrmAbout_Load(object sender, EventArgs e) {
            dflAbout.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            txtProgrammer.Text = Author.Name;
            hlYahoo.Text = Author.Yahoo;
            hlGmail.Text = Author.Gmail;
            txtPhone.Text = Author.Phone;
            txtVersion.Text = About.AssemblyVersion;
            txtYear.Text = About.AssemblyCopyright;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if (e.Page.Name == "sysInfo") {
                SystemInfo sysInfo = new SystemInfo();

                txtOSName.Text = sysInfo.OsName;
                txtProcessorName.Text = sysInfo.ProcessorName;
                txtTotalMemory.Text = $"{(float) sysInfo.TotalMemory / 1000} جيجا بايت";
                txtOSVersion.Text = sysInfo.OsVersion;
                txtCSName.Text = sysInfo.CsName;
                txtOSArchitecture.Text = sysInfo.OsArchitecture;
                txtUserName.Text = Environment.UserName;
                txtFreePhysicalMemory.Text = sysInfo.FreeMemory + " ميجابايت";
                txtDescription.Text = sysInfo.ProcDescription;
                txtManufacturer.Text = sysInfo.ProcManufacturer;
                txtNumberOfCores.Text = sysInfo.ProcNumberOfCores.ToString();
                txtMaxClockSpeed.Text = sysInfo.ProcMaxClockSpeed.ToString();
                txtCurrentClockSpeed.Text = sysInfo.ProcCurrentClockSpeed.ToString();
                txtStatus.Text = sysInfo.ProcStatus;
                txtSocketDesignation.Text = sysInfo.ProcSocketDesignation;
                txtCsManufacturer.Text = sysInfo.CsManufacturer;
                txtCsModel.Text = sysInfo.CsModel;

            }
        }
    }
}