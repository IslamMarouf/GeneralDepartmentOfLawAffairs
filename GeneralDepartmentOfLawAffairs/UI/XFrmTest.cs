using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    
    public partial class XFrmTest : DevExpress.XtraEditors.XtraForm {
        private int gHeight;

        public XFrmTest()
        {
            InitializeComponent();
        }

        private void XFrmTest_Load(object sender, EventArgs e) {
            

            //labelControl5.Text = Settings.Default.CurrentSkinName;
            dflXFrmTest.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
            gHeight = MainGroup.Height;
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e) {
            labelControl5.Text = textEdit4.Text;

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void layoutControlGroup1_Hidden(object sender, EventArgs e) {

        }
        private void layoutControlGroup1_Hiding(object sender, EventArgs e)
        {
           
        }

        private void layoutControlGroup1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            alertControl1.Show(this, "hello", "soli");
        }

        private void layoutControl1_GroupExpandChanged(object sender, DevExpress.XtraLayout.Utils.LayoutGroupEventArgs e)
        {
            if (e.Group.Expanded) {
                e.Group.Text = "Group (Expanded)";
                
            }
            else {
                e.Group.Text = "Group (Collapsed)";
                
            }
            
            
        }
    }
}