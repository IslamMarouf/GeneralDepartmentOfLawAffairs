﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInvestProcOut : XFrmGeneralForm
    {
        public LetterData FrmLetterData { get; set; }

        public XFrmInvestProcOut()
        {
            InitializeComponent();
        }

        private void XFrmInvestProcOut_Load(object sender, EventArgs e) {
            grSbubjectData.Text =
                $@"{LetterSentences.Investigation} {LetterSentences.Num} {FrmLetterData.SubjectNum} {LetterSentences.ForYear} {FrmLetterData.SubjectYear}";
            txt_about.Text = FrmLetterData.Subject;
            txtLastProcedure.Text = FrmLetterData.ProcedureName;
            dtProcedureDate.EditValue = FrmLetterData.ProcedureDate;
            vpInvestProcOut.Validate();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpInvestProcOut.Validate())
                return;



            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void txtOutNum_EditValueChanged(object sender, EventArgs e) {
            vpInvestProcOut.Validate();
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