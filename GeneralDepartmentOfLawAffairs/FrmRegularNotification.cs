using System;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmRegularNotification : GeneralForm
    {
        public FrmRegularNotification() {
            InitializeComponent();
            FrmLetterData = new LetterData();

            /*
             * Globals.ThisAddIn.SubjectsConnection used to access and get the original
             * Connection object in the add-in and we need to use that connection here.
             * The Command instance is initialized with the Connection object that is
             * created in the ThisAddIn_Startup event.
             */
            odbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            odbCommand.CommandType = CommandType.Text;
            odbCommand.CommandText = conString;
            subjectsDataAdapter.SelectCommand = odbCommand;
            subjectsDataAdapter.Fill(ds, "tblSubjects");
        }

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

        string conString = "SELECT * FROM tblSubjects";
        OleDbDataAdapter subjectsDataAdapter = new OleDbDataAdapter();
        OleDbCommand odbCommand = new OleDbCommand();

        /*
           The DataSet is used to query data using the LINQ to DataSet method since
           there is no direct way to connect LINQ to the Microsoft Access database.
         */
        DataSet ds = new DataSet();


        private void FrmRegularNotification_Load(object sender, EventArgs e) {
            var ivestigationsNums = from sb in ds.Tables["tblSubjects"].AsEnumerable()
                                    where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                                    select sb;

            foreach (var numRow in ivestigationsNums)
            {
                cmbxInvestigationNum.Items.Add(numRow.Field<string>("subject_num"));
            }


            if (cmbxInvestigationNum.Text.Equals("")) {
                lblMessage.Text = LetterSentences.LblMessage;
                ValidateNotification();
            }

            if (txt_1.Text.Equals("")) {
                lblMessage_2.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }

            if (txtSubject.Text.Equals("")) {
                lblMessage_1.Text = LetterSentences.LblMessage_1;
                ValidateNotification();
            }

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            dTPicker.Value = DateTime.Today;
            dTPickerAssignmentDate.Value = DateTime.Today;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.EmptyFields.Clear();
            FrmLetterData.WantedNamesList.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;
            FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text + "/" + dtPkrInvestigationYear.Text;          

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

            if (dTPickerAssignmentDate.Value.CompareTo(DateTime.Today) > 0) {
                FrmLetterData.EmptyFields.Add(LetterSentences.LblMessage_5);
            }

            DisplayResult();
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
            if (txt_1.Text.Equals("")) {
                lblMessage_2.Text = LetterSentences.LblMessage_2;
                ValidateNotification();
            }
            else {
                lblMessage_2.Text = "";
                ValidateNotification();
            }
        }

        private void dTPicker_ValueChanged(object sender, EventArgs e) {
            if (dTPicker.Value.CompareTo(DateTime.Today) < 0) {
                lblMessage_3.Text = LetterSentences.LblMessage_3;
                ValidateNotification();
            }
            else {
                FrmLetterData.InvestigationDate = dTPicker.Value;
                lblMessage_3.Text = "";
                ValidateNotification();
            }
        }

        private void ValidateNotification() {
            if (lblMessage.Text.Equals("")
                && lblMessage_1.Text.Equals("")
                && lblMessage_2.Text.Equals("")
                && lblMessage_3.Text.Equals("")
                && lblMessage_4.Text.Equals("")) {
                btnOK.Enabled = true;
                pbxStatus.BackgroundImage = Resources.Sample4__2_;
            }
            else {
                btnOK.Enabled = false;
                pbxStatus.BackgroundImage = Resources.Sample3__2_;
            }
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e) {
            
            var investigationInfo = from sb in ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInvestigationNum.SelectedItem.ToString())
                select sb;

            foreach (var investInfoRow in investigationInfo)
            {
                txtSubject.Text = investInfoRow.Field<string>("subject_about");
                dTPickerAssignmentDate.Value = investInfoRow.Field<DateTime>("subject_assignmentDate");
            }
        }

        private void cmbxInvestigationNum_TextChanged(object sender, EventArgs e) {
            if (cmbxInvestigationNum.Text.Equals("")) {
                lblMessage.Text = LetterSentences.LblMessage;
                ValidateNotification();
            }
            else {
                lblMessage.Text = "";
                ValidateNotification();
            }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e) {
            if (txtSubject.Text.Equals("")) {
                lblMessage_1.Text = LetterSentences.LblMessage_1;
                ValidateNotification();
            }
            else {
                lblMessage_1.Text = "";
                ValidateNotification();
            }
        }

        private void FrmRegularNotification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormHasEmptyFields && (e.CloseReason != CloseReason.UserClosing))
                e.Cancel = true;
            else
                FormHasEmptyFields = false;
        }

        private void dTPickerIncomDate_ValueChanged(object sender, EventArgs e)
        {
            if (dTPickerAssignmentDate.Value.CompareTo(DateTime.Today) > 0)
            {
                lblMessage_4.Text = LetterSentences.LblMessage_5;
                ValidateNotification();
            }
            else
            {
                FrmLetterData.InvestigationIncomDate = dTPickerAssignmentDate.Value;
                lblMessage_4.Text = "";
                ValidateNotification();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormHasEmptyFields = false;
        }
    }
}