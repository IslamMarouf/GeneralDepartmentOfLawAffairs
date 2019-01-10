using System;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class frmTest : Form
    {
        private string str = "";

        public frmTest() {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e) {
        }

        private void frmTest_MouseMove(object sender, MouseEventArgs e) {
            str = "";
            for (var i = 0; i < sentPhotoCopy1.Directions.Count; i++)
                str += sentPhotoCopy1.Directions[i].MrMrsVal + " "
                       + sentPhotoCopy1.Directions[i].RecipientVal + " "
                       + sentPhotoCopy1.Directions[i].DeptNameVal + Environment.NewLine;

            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e) {
        }
    }
}