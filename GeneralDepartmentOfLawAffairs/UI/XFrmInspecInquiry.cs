using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInspecInquiry : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; set; }

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public XFrmInspecInquiry()
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

        private void XFrmInspecInquiry_Load(object sender, EventArgs e) {
            dflInspecInquiry.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
            
            if (FrmLetterData.SubjectId.Equals("")) {
                var inspections = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                    where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                    select sb;

                foreach (var inspection in inspections)
                {
                    cmbxInspectionNum.Properties.Items.Add(inspection.Field<string>("subject_num"));
                }
            }
            else {
                var inspections = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                    where sb.Field<string>("subject_id").Equals(FrmLetterData.SubjectId)
                    select sb;

                foreach (var inspection in inspections)
                {
                    cmbxInspectionNum.Properties.Items.Add(inspection.Field<string>("subject_num"));
                }
            }

            cmbxInspectionNum.SelectedIndex = 0;

            ctrlDirection.cmbxMrMrs.SelectedIndex = 0;
            ctrlDirection.cmbxRecipient.SelectedIndex = 1;
            ctrlDirection.cmbxRecipientDeptName.SelectedIndex = 1;
            ctrlSentPhotoCopy.Enabled = false;
        }

        private void chkbxSentPhotoCopy_CheckedChanged(object sender, EventArgs e)
        {
            ctrlSentPhotoCopy.Enabled = !ctrlSentPhotoCopy.Enabled;
        }

        private void XFrmInspecInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
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

            DialogResult = DialogResult.OK;


        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void cmbxInspectionNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var inspectionInfo = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_num").Equals(cmbxInspectionNum.Text)
                select sb;

            foreach (var inspectInfoRow in inspectionInfo)
            {
                FrmLetterData.InspectionNumber = cmbxInspectionNum.Text;
                txtYear.Text = inspectInfoRow.Field<string>("subject_year");
                FrmLetterData.InspectYear = txtYear.Text;
                string str = inspectInfoRow.Field<string>("subject_about");
                txt_about.Text = str.Replace(',', '،');
                FrmLetterData.Subject = txt_about.Text;               
                FrmLetterData.DepartmentName = inspectInfoRow.Field<string>("subject_assignmentDept");
                DateTime date = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                dtpAssignmentDate.EditValue = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterDate = date.ToShortDateString();
                FrmLetterData.IncomingLetterNumber = inspectInfoRow.Field<string>("subject_assignmentLetterNum");
            }
        }
    }
}