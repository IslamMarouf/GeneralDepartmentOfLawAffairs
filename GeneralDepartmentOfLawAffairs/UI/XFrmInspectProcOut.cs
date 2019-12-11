using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Utils;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInspectProcOut : XFrmGeneralForm
    {
        public LetterData FrmLetterData { get; set; }

        public XFrmInspectProcOut()
        {
            InitializeComponent();
        }

        private void XFrmInspectProcOut_Load(object sender, EventArgs e)
        {
            grSbubjectData.Text =
                $@"{LetterSentences.Inspection} {LetterSentences.Num} {FrmLetterData.SubjectNum} {LetterSentences.ForYear} {FrmLetterData.SubjectYear}";
            txt_about.Text = FrmLetterData.Subject;
            txtLastProcedure.Text = FrmLetterData.ProcedureName;
            dtProcedureDate.EditValue = FrmLetterData.ProcedureDate;
            dTPickerOutcomDate.DateTime = DateTime.Today;
            vpInspectProcOut.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpInspectProcOut.Validate())
                return;

            SubjectsHelper.UpdateOutComDate(FrmLetterData.SubjectId, txtOutNum.Text, dTPickerOutcomDate.DateTime.Date);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void txtOutNum_EditValueChanged(object sender, EventArgs e) {
            vpInspectProcOut.Validate();
        }

        private void dTPickerOutcomDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dTPickerOutcomDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }
    }
}