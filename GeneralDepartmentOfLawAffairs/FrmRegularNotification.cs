﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmRegularNotification : GeneralForm
    {
        public LetterData FrmLetterData { get; }
        public bool FormHasEmptyFields { get; set; }

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

        public FrmRegularNotification() {
            InitializeComponent();
            FrmLetterData = new LetterData();

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = SubjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmRegularNotification_Load(object sender, EventArgs e) {
            var investigation = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                                    where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                                    select sb;

            foreach (var numRow in investigation)
            {
                cmbxInvestigationNum.Items.Add(numRow.Field<string>("subject_num"));
            }

            cmbxInvestigationNum.SelectedIndex = 0;

            

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            dTPicker.Value = DateTime.Today;
            dtpAssignmentDate.Value = DateTime.Today;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.EmptyFields.Clear();
            FrmLetterData.WantedNamesList.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;
            FrmLetterData.InvYear = txtYear.Text;

            if (!txt_1.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_1.Text);

            if (!txt_2.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_2.Text);
           
            if (!txt_3.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_3.Text);
            
            if (!txt_4.Text.Equals(""))
                FrmLetterData.WantedNamesList.Add(txt_4.Text);
            
            if (dTPicker.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_4);

            if (dtpAssignmentDate.Value.CompareTo(DateTime.Today) > 0) {
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_5);
            }

            DisplayResult();

            string strUpdate = "UPDATE tblSubjects " +
                               "SET subject_procedureName = " +
                               $"'{LetterSentences.Notification}'," +
                               " subject_procedureDate = " +
                               $"'{DateTime.Now.ToShortDateString()}'," +
                               " subject_sessionDate = " +
                               $"'{dTPicker.Value.ToShortDateString()}'" +
                               $" WHERE subject_num = '{cmbxInvestigationNum.Text}'" +
                               $" And subject_type = '{LetterSentences.Investigation}'";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try
                {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0)
                    {
                        MessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void DisplayResult() {
            if (FrmLetterData.EmptyFields.Count != 0) {
                var str = "";

                foreach (var t in FrmLetterData.EmptyFields)
                    str += t + "\n";

                var result = MessageBox.Show(
                    str
                    + Environment.NewLine
                    + LetterSentences.doContinue,
                    LetterSentences.GeneralDepartName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                switch (result) {
                    case DialogResult.Yes:
                        FormHasEmptyFields = false;
                        break;

                    case DialogResult.No:
                        FormHasEmptyFields = true;
                        break;
                }
            }
            else {
                FormHasEmptyFields = false;
            }
        }

        private void txt_1_TextChanged(object sender, EventArgs e) {
            
        }

        private void dTPicker_ValueChanged(object sender, EventArgs e) {
            if (dTPicker.Value.CompareTo(DateTime.Today) < 0) {
                
                ValidateNotification();
            }
            else {
                FrmLetterData.InvestigationDate = dTPicker.Value;
                
                ValidateNotification();
            }
        }

        private void ValidateNotification() {
            
        }

        private void FrmRegularNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormHasEmptyFields && (e.CloseReason != CloseReason.UserClosing))
                e.Cancel = true;
            else
                FormHasEmptyFields = false;

            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
            _subjectsDs?.Dispose();
        }

        private void dTPickerIncomDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAssignmentDate.Value.CompareTo(DateTime.Today) > 0)
            {
                
                ValidateNotification();
            }
            else
            {
                FrmLetterData.InvestigationIncomDate = dtpAssignmentDate.Value;
                
                ValidateNotification();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Divide)
            {
                SendKeys.Send("{BACKSPACE}");

            }
        }

        private void txtSubject_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cmbxInvestigationNum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var investigationInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInvestigationNum.Text)
                select sb;

            foreach (var investInfoRow in investigationInfo)
            {
                FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text;
                txtYear.Text = investInfoRow.Field<string>("subject_year");
                txt_about.Text = investInfoRow.Field<string>("subject_about");
                FrmLetterData.DepartmentName = investInfoRow.Field<string>("subject_assignmentDept");
                DateTime date = investInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                dtpAssignmentDate.Value = investInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterDate = date.ToShortDateString();
                FrmLetterData.IncomingLetterNumber = investInfoRow.Field<string>("subject_assignmentLetterNum");
                FrmLetterData.Name = investInfoRow.Field<string>("subject_guiltyName");
                FrmLetterData.CeaseDays = investInfoRow.Field<string>("subject_ceaseDays");
                FrmLetterData.CeaseMonths = investInfoRow.Field<string>("subject_ceaseMonths");
            }
        }
    }
}