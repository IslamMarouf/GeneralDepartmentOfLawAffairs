using System;
using System.Data;
using System.Data.OleDb;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmTableNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        private const string SubjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public FrmTableNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = SubjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmTableNote_Load(object sender, EventArgs e) {
            var investigations = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                select sb;

            foreach (var investigation in investigations)
            {
                cmbxInvestigationNum.Items.Add(investigation.Field<string>("subject_num"));
            }

            cmbxInvestigationNum.SelectedIndex = 0;
            cmbxDirection.SelectedIndex = 0;
        }

        private void cmbxDirection_SelectedIndexChanged(object sender, EventArgs e) {
            FrmLetterData.Index = cmbxDirection.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;
            FrmLetterData.Subject = txt_about.Text;
            FrmLetterData.InvYear = txtYear.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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

        private void FrmTableNote_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }
    }
}
