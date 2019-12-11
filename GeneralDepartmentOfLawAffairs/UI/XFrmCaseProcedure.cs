using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmCaseProcedure : XFrmGeneralForm
    {
        public LetterData FrmLetterData { get; set; }

        public XFrmCaseProcedure()
        {
            InitializeComponent();
        }

        private void XFrmCaseProcedure_Load(object sender, EventArgs e) {
            txtCaseNum.Text = FrmLetterData.CaseNumber;
            txtCaseYear.Text = FrmLetterData.CaseYear;
            txtAP.Text = FrmLetterData.ApVal;
            txtAPLetterNumber.Text = FrmLetterData.ApLetterNum;
            dpAPLetter.EditValue = FrmLetterData.DtLetterDate;
            txtCaseResNumber.Text = FrmLetterData.CaseResNum;
            txtCaseResYear.Text = FrmLetterData.CaseResYear.ToString();
            txtLastProcName.Text = FrmLetterData.ProcedureName;
            dtLastProcDate.EditValue = FrmLetterData.ProcedureDate;
            txtGuilty.Text = FrmLetterData.Guilty;
            txtAbout.Text = FrmLetterData.Subject;
        }

        private void btnIssuanceRes_Click(object sender, EventArgs e)
        {
            XFrmIssuanceRescriptLetter xFrmIssuance = new XFrmIssuanceRescriptLetter();
            xFrmIssuance.FrmLetterData.CaseId = FrmLetterData.CaseId;
            xFrmIssuance.ShowDialog();
        }

        private void btnUrgency_Click(object sender, EventArgs e)
        {

        }

        private void btnIssuanceResNote_Click(object sender, EventArgs e)
        {

        }

        private void btnResSent_Click(object sender, EventArgs e)
        {
            XFrmRescriptSentLetter xFrmRescriptSentLetter = new XFrmRescriptSentLetter();
            xFrmRescriptSentLetter.FrmLetterData.CaseId = FrmLetterData.CaseId;
            xFrmRescriptSentLetter.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}