using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmTableNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmTableNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }

        private void FrmTableNote_Load(object sender, EventArgs e) {
            cmbxDirection.SelectedIndex = 0;
        }

        private void cmbxDirection_SelectedIndexChanged(object sender, EventArgs e) {
            FrmLetterData.Index = cmbxDirection.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.Subject = txtSubject.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
