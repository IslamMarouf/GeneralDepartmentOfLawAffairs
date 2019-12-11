using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmSettings : Form
    {
        private LetterData letterData;
        private List<Panel> panels = new List<Panel>();
        private Panel visiblePanel = null;


        public FrmSettings() {
            InitializeComponent();
            letterData = new LetterData();
        }

        private void FrmSettings_Load(object sender, EventArgs e) {

            // Move the panels out of the tabControl.
            tbSettingsPages.Visible = false;
            foreach (TabPage page in tbSettingsPages.TabPages) {
                // Add the panel to the list.
                Panel panel = page.Controls[0] as Panel;
                panels.Add(panel);

                // Re-parent and move the panel.
                panel.Parent = tbSettingsPages.Parent;
                panel.Location = tbSettingsPages.Location;
                panel.Visible = false;
            }

            // Display the first panel.
            DisplayPanel(0);
        }

        private void DisplayPanel(int index) {
            if (panels.Count < 1) return;

            // If this is the same panel, do nothing.
            if (visiblePanel == panels[index]) return;
            
            // Hide the previously visible panel.
            if (visiblePanel != null) visiblePanel.Visible = false;

            // Display the appropriate panel.
            panels[index].Visible = true;
            visiblePanel = panels[index];
        }


        private void btnOK_Click(object sender, EventArgs e) {
            Settings.Default.Save();

        }

        private void trvSettings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = int.Parse(e.Node.Tag.ToString());
            DisplayPanel(index);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}