using System;
using System.Data;
using System.Data.OleDb;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmInspectionNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public FrmInspectionNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = _subjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmInspectionNote_Load(object sender, EventArgs e)
        {
            var inspections = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                select sb;

            foreach (var inspection in inspections)
            {
                cmbxInspectionNum.Items.Add(inspection.Field<string>("subject_num"));
            }

            cmbxInspectionNum.SelectedIndex = 0;
            cmbxDirection.SelectedIndex = 0;
        }

        private void cmbxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmLetterData.Index = cmbxDirection.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
                txt_about.Text = inspectInfoRow.Field<string>("subject_about");
                FrmLetterData.Subject = txt_about.Text;
                FrmLetterData.DepartmentName = inspectInfoRow.Field<string>("subject_assignmentDept");
                DateTime date = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                dtpAssignmentDate.Value = inspectInfoRow.Field<DateTime>("subject_assignmentLetterDate");
                FrmLetterData.IncomingLetterDate = date.ToShortDateString();
                FrmLetterData.IncomingLetterNumber = inspectInfoRow.Field<string>("subject_assignmentLetterNum");
            }
        }

        private void FrmInspectionNote_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }
    }
}
