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
    public partial class FrmDraftResolution : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmDraftResolution()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }

        private void FrmDraftResolution_Load(object sender, EventArgs e) {
            cmbxCompetentAuthority.SelectedIndex = 1;
            cmbxArticlesNum.SelectedIndex = 2;

            dpAPLetter.Value = DateTime.Today;
            dtCaseDecision.Value = DateTime.Today;

            dtCaseDecisionYear.Enabled = true;
            rdbtnDate.Checked = true;

            pbxStatus.Image = Properties.Resources.Sample3__2_;

            txtAPLetterNumber.BackColor = Color.Maroon;
            txtCaseDecisionNumber.BackColor = Color.Maroon;
            txtCaseNumber.BackColor = Color.Maroon;
        }

        private void DateType_CheckedChanged(object sender, EventArgs e) {
            if (sender == rdbtnDate) {
                FrmLetterData.CaseDecisionDate =
                    LetterSentences.Dated + " " + dtCaseDecision.Value.ToShortDateString() + " ";
                dtCaseDecisionYear.Enabled = !dtCaseDecisionYear.Enabled;
            }
            else if (sender == rdbtnYear) {
                FrmLetterData.CaseDecisionDate = LetterSentences.ForYear + " " + dtCaseDecisionYear.Value.Year + " ";
                dtCaseDecision.Enabled = !dtCaseDecision.Enabled;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.ApLetterNum = txtAPLetterNumber.Text;
            FrmLetterData.ApLetterDate = dpAPLetter.Value.ToShortDateString();
            FrmLetterData.DecisionNumber = txtCaseDecisionNumber.Text;
            FrmLetterData.CaseNumber = txtCaseNumber.Text;
            FrmLetterData.CaseYear = dtCase.Value.Year.ToString();
            FrmLetterData.Guilty = txtGuilty.Text;

            FrmLetterData.ApVal = cmbxAPList.Text;
            FrmLetterData.ArticlesNum = cmbxArticlesNum.SelectedIndex + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
