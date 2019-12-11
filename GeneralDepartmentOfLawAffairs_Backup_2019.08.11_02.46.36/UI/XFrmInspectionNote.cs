using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInspectionNote : DevExpress.XtraEditors.XtraForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public XFrmInspectionNote()
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

        private void XFrmInspectionNote_Load(object sender, EventArgs e) {
            dflInspectionNote.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

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
            cmbxDirection.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            FrmLetterData.AttachmentsCount = txtAttachmentsCount.Text;

            string strUpdate = "UPDATE tblSubjects " +
                               "SET subject_procedureName = " +
                               $"'{LetterSentences.Note}'," +
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

        private void cmbxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmLetterData.Index = cmbxDirection.SelectedIndex;
        }

        private void XFrmInspectionNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();}
    }
}