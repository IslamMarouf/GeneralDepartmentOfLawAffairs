using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmApReferring : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        private const string SubjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();
        public XFrmApReferring()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = SubjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void XFrmApReferring_Load(object sender, EventArgs e) {
            dflApReferring.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            if (FrmLetterData.SubjectId.Equals("")) {
                var investigation = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                    where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
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

            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;
        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var investigationInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInvestigationNum.Text)
                select sb;

            foreach (var investInfoRow in investigationInfo)
            {
                FrmLetterData.InvestigationNumber = cmbxInvestigationNum.Text;
                txtYear.Text = investInfoRow.Field<string>("subject_year");
                FrmLetterData.InvYear = txtYear.Text;
                string aboutStr = investInfoRow.Field<string>("subject_about");
                txt_about.Text = aboutStr.Replace(',', '،');
                FrmLetterData.Subject = txt_about.Text;
                FrmLetterData.DepartmentName = investInfoRow.Field<string>("subject_assignmentDept");
                DateTime date = investInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                dtpAssignmentDate.EditValue = investInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterDate = date.ToShortDateString();
                FrmLetterData.IncomingLetterNumber = investInfoRow.Field<string>("subject_assignmentLetterNum");
                FrmLetterData.Name = investInfoRow.Field<string>("subject_guiltyName");
                FrmLetterData.CeaseDays = investInfoRow.Field<string>("subject_ceaseDays");
                FrmLetterData.CeaseMonths = investInfoRow.Field<string>("subject_ceaseMonths");

                txtAttachmentsCount.Text = LetterSentences.InvestigationRefererring4 
                                + " " + FrmLetterData.InvestigationNumber 
                                + " " + LetterSentences.ForYear 
                                + " " + FrmLetterData.InvYear + " ";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;
            
            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void XFrmApReferring_FormClosing(object sender, FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }
    }
}