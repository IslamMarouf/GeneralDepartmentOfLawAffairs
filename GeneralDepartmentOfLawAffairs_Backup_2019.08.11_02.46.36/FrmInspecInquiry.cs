using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmInspecInquiry : GeneralForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        private Point _pnlButtonsLocation;

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public FrmInspecInquiry()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FrmLetterData.HasSentPhotoCopy = false;

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = _subjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmInspecInquiry_Load(object sender, System.EventArgs e)
        {
            var inspections = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                select sb;

            foreach (var inspection in inspections)
            {
                cmbxInspectionNum.Items.Add(inspection.Field<string>("subject_num"));
            }

            cmbxInspectionNum.SelectedIndex = 0;

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;

            _pnlButtonsLocation = pnlButtons.Location;

            ctrlSentPhotoCopy.Visible = false;
            pnlButtons.Location = ctrlSentPhotoCopy.Location;
            Height -= ctrlSentPhotoCopy.Height;
        }

        private void FrmInspecInquiry_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            FrmLetterData.MrMsVal = ctrlDirection.MrMrsVal;
            FrmLetterData.Receiver = ctrlDirection.RecipientVal;
            FrmLetterData.ReceiverDeptName = ctrlDirection.DeptNameVal;
            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;
            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;

            if (chkbxSentPhotoCopy.Checked)
            {
                FrmLetterData.HasSentPhotoCopy = true;

                FrmLetterData.SentPhotoCopyCount = 0;

                foreach (var item in ctrlSentPhotoCopy.Directions)
                    if (!item.RecipientVal.Equals("")
                        && !item.DeptNameVal.Equals(""))
                    {
                        FrmLetterData.MrMrsValList
                            .Add(item.MrMrsVal);
                        FrmLetterData.RecipientValList
                            .Add(item.RecipientVal);
                        FrmLetterData.DeptNameValList
                            .Add(item.DeptNameVal);

                        FrmLetterData.SentPhotoCopyCount++;
                    }
            }

            string strUpdate = "UPDATE tblSubjects " +
                               "SET subject_procedureName = " +
                               $"'{LetterSentences.Inquiry}'," +
                               " subject_procedureDate = " +
                               $"'{DateTime.Now.ToShortDateString()}'" +                              
                               $" WHERE subject_num = '{cmbxInspectionNum.Text}'" +
                               $" And subject_type = '{LetterSentences.Inspection}'";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        MessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message, exception.Source);
                }

            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void chkbxSentPhotoCopy_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkbxSentPhotoCopy.Checked)
            {
                ctrlSentPhotoCopy.Visible = true;
                pnlButtons.Location = _pnlButtonsLocation;
                Height += ctrlSentPhotoCopy.Height;
            }
            else
            {
                ctrlSentPhotoCopy.Visible = false;
                pnlButtons.Location = ctrlSentPhotoCopy.Location;
                Height -= ctrlSentPhotoCopy.Height;
            }
        }

        private void cmbxInspectionNum_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var inspectionInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInspectionNum.Text)
                select sb;

            foreach (var inspectInfoRow in inspectionInfo)
            {
                FrmLetterData.InspectionNumber = cmbxInspectionNum.Text;
                txtYear.Text = inspectInfoRow.Field<string>("subject_year");
                FrmLetterData.InspectYear = txtYear.Text;
                txt_about.Text = inspectInfoRow.Field<string>("subject_about");
                FrmLetterData.Subject = txt_about.Text;               
                FrmLetterData.DepartmentName = inspectInfoRow.Field<string>("subject_assignmentDept");
                DateTime date = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                dtpAssignmentDate.Value = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterDate = date.ToShortDateString();
                FrmLetterData.IncomingLetterNumber = inspectInfoRow.Field<string>("subject_assignmentLetterNum");
            }
        }
    }
}
