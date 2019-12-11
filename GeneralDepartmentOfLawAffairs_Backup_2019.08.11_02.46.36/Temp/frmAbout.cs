using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmAbout : Form
    {
        public FrmAbout() {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            DocumentProperties builtInProps = document.BuiltInDocumentProperties;

            var sysInfoStringBuilder = new StringBuilder();

            sysInfoStringBuilder.AppendLine("Computer Name: " + Environment.MachineName);
            sysInfoStringBuilder.AppendLine("User Name: " + Environment.UserName);
            sysInfoStringBuilder.AppendLine("OS Version: " + Environment.OSVersion);
            sysInfoStringBuilder.AppendLine("Processor Count: " + Environment.ProcessorCount);
            sysInfoStringBuilder.AppendLine("Monitor Size:" + SystemInformation.PrimaryMonitorSize);
            sysInfoStringBuilder.AppendLine(" :");
            sysInfoStringBuilder.AppendLine(" :");
            sysInfoStringBuilder.AppendLine(" :");
            sysInfoStringBuilder.AppendLine(" :");
            sysInfoStringBuilder.AppendLine(" :");
            sysInfoStringBuilder.AppendLine(" :");

            txtSystemInfo.Text = sysInfoStringBuilder.ToString();

            var docInfoStringBuilder = new StringBuilder();

            foreach (DocumentProperty docProp in builtInProps) {
                var name = docProp.Name;
                object value;

                try {
                    value = docProp.Value;
                }
                catch (Exception ex) {
                    value = ex.Message;
                }

                docInfoStringBuilder.AppendLine($"{name} - {value}");
            }

            txtDocInfo.Text = docInfoStringBuilder.ToString();
        }

        private void tpAbout_Click(object sender, EventArgs e) {
        }

        private void label5_Click(object sender, EventArgs e) {
        }
    }
}