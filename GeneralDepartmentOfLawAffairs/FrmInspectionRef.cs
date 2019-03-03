using System;
using System.Data;
using System.Data.OleDb;

namespace GeneralDepartmentOfLawAffairs {
    public partial class FrmInspectionRef : GeneralForm {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public FrmInspectionRef() {
            InitializeComponent();
            FrmLetterData = new LetterData();

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = _subjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmInspectionRef_Load(object sender, System.EventArgs e) {
            var inspections = from sb in _subjectsDs.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                select sb;

            foreach (var inspection in inspections)
            {
                cmbxInspectionNum.Items.Add(inspection.Field<string>("subject_num"));
            }

            cmbxInspectionNum.SelectedIndex = 0;

            ctrlDirection.cmbxMrMrs.Enabled = false;
            ctrlDirection.cmbxRecipient.SelectedIndex = 3;
            ctrlDirection.cmbxRecipient.Enabled = false;
        }

        private void btnOK_Click(object sender, System.EventArgs e) {
            FrmLetterData.EmptyFields.Clear();

            FrmLetterData.MrMsVal = ctrlDirection.cmbxMrMrs.Text;
            FrmLetterData.Receiver = ctrlDirection.cmbxRecipient.Text;
            FrmLetterData.ReceiverDeptName = ctrlDirection.cmbxRecipientDeptName.Text;

            FrmLetterData.InspectionNumber = cmbxInspectionNum.Text;
            

            FrmLetterData.ApNames = ctrlDirection.ApNames;
            FrmLetterData.ApAddresses = ctrlDirection.ApAddresses;
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            FormHasEmptyFields = false;
        }

        private void FrmInspectionRef_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
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