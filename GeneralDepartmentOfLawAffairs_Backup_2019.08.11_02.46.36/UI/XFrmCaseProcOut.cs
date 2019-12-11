using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmCaseProcOut : XFrmGeneralForm
    {
        public LetterData FrmLetterData { get; set; }

        public XFrmCaseProcOut()
        {
            InitializeComponent();
        }

        private void XFrmCaseProcOut_Load(object sender, EventArgs e)
        {
            txtCaseNum.Text = FrmLetterData.CaseNumber;
            txtCaseYear.Text = FrmLetterData.CaseYear;
            txtAP.Text = FrmLetterData.ApVal;
            txtLastProcedure.Text = FrmLetterData.ProcedureName;
            dtProcedureDate.EditValue = FrmLetterData.ProcedureDate;
            txtGuilty.Text = FrmLetterData.Guilty;
            txtAbout.Text = FrmLetterData.Subject;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpCaseProcOut.Validate())
                return;



            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void dTPickerOutcomDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dTPickerOutcomDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}