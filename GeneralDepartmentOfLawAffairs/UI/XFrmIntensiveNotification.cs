﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmIntensiveNotification : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; }

        /*
               In LINQ to Object method, we must first build a DataSet and fill it with
               our Subjects data table. The reason for that is because there is no direct
               relationship between the LINQ and the Microsoft Access database, but we
               can set up an indirect relationship between them using the LINQ to ADO.NET
               since ADO.NET covers any kinds of database including the Microsoft Access
               20016. In order to set up this relationship, a DataSet must be built by
               filling it with the desired data table such as Subjects in this case.
               One point to note is that this DataSet is a nontyped DataSet if it is 
               built in this way, and you must use the field location, not field name,
               to identify each column in the data table.
        */

        private const string SubjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public XFrmIntensiveNotification()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = SubjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void XFrmIntensiveNotification_Load(object sender, EventArgs e) {
            dflIntensiveNotification.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            if (FrmLetterData.SubjectId.Equals("")) {
                var investigation = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                    where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation) &&
                          sb.Field<string>("subject_procedureName").Equals(LetterSentences.Notification)
                    select sb;


                foreach (var numRow in investigation) {
                    cmbxInvestigationNum.Properties.Items.Add(numRow.Field<string>("subject_num"));
                }
            }
            else {
                var investigation = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                    where sb.Field<string>("subject_id").Equals(FrmLetterData.SubjectId)
                    select sb;

                foreach (var numRow in investigation) {
                    cmbxInvestigationNum.Properties.Items.Add(numRow.Field<string>("subject_num"));
                }

            }
            cmbxInvestigationNum.SelectedIndex = 0;

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            deSessionDate.EditValue = DateTime.Today;
            dtpAssignmentDate.EditValue = DateTime.Today;

            cmbxNotificationType.SelectedIndex = 0;

            vpIntensiveNotification.Validate();
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var investigationInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInvestigationNum.Text) 
                select sb;

            foreach (var investInfoRow in investigationInfo) {
                FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text;
                txtYear.Text = investInfoRow.Field<string>("subject_year");
                txt_about.Text = investInfoRow.Field<string>("subject_about");
                FrmLetterData.DepartmentName = investInfoRow.Field<string>("subject_assignmentDept");
                dtpAssignmentDate.EditValue = investInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterNumber = investInfoRow.Field<string>("subject_assignmentLetterNum");
                FrmLetterData.Name = investInfoRow.Field<string>("subject_guiltyName");
                FrmLetterData.CeaseDays = investInfoRow.Field<string>("subject_ceaseDays");
                FrmLetterData.CeaseMonths = investInfoRow.Field<string>("subject_ceaseMonths");
                string lastProc = investInfoRow.Field<string>("subject_procedureName");
                if (lastProc != null && lastProc.Equals(LetterSentences.Notification)) {
                    txtNotificationOutcomNumber.Text = investInfoRow.Field<string>("subject_procedureOutComNum");
                    DateTime? procOutComDate = investInfoRow.Field<DateTime?>("subject_procedureOutComDate");
                    if (procOutComDate.HasValue) deLastNotification.EditValue = procOutComDate.Value;
                }
                else {
                    deLastNotification.EditValue = DateTime.Now;
                }

            }
        }

        private void txt_1_EditValueChanged(object sender, EventArgs e) {
            vpIntensiveNotification.Validate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpIntensiveNotification.Validate()) {
                return;
            }

            FrmLetterData.WantedNamesList.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;
            FrmLetterData.InvYear = txtYear.Text;

            FrmLetterData.InvestigationDate = deSessionDate.DateTime.Date;
            
            if (!txt_1.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_1.Text);

            FrmLetterData.LastNotificationOutcomDate = deLastNotification.DateTime;
            FrmLetterData.LastNotificationOutcomNumber = txtNotificationOutcomNumber.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void XFrmIntensiveNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
            _subjectsDs?.Dispose();
        }

        private void deSessionDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date < DateTime.Today)
                e.Cancel = true;
        }

        private void deSessionDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_3, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}