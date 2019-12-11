using System;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;
using GeneralDepartmentOfLawAffairs.Utils;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInspectProcedure : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; set; }
        public Document Document { get; set; }

        public XFrmInspectProcedure()
        {
            InitializeComponent();
        }

        private void XFrmProcedure_Load(object sender, EventArgs e) {
            dflInspectProcedure.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            txtNum.Text = FrmLetterData.SubjectNum;
            txtYear.Text = FrmLetterData.SubjectYear;
            dtpAssignmentDate.EditValue = FrmLetterData.AssignmentDate;
            txt_about.Text = FrmLetterData.Subject;
            txtLastProcedure.Text = FrmLetterData.ProcedureName;
            dtProcedureDate.EditValue = FrmLetterData.ProcedureDate;

        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            XFrmInspecInquiry frmInspecInquiry = new XFrmInspecInquiry();
            frmInspecInquiry.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            frmInspecInquiry.ShowDialog();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            XFrmInspectionNote frmInspectionNote = new XFrmInspectionNote();
            frmInspectionNote.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            frmInspectionNote.ShowDialog();

        }

        private void btnInspectResult_Click(object sender, EventArgs e)
        {
            // ....
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            XFrmInspectionRef frmInspectionRef = new XFrmInspectionRef();
            frmInspectionRef.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            frmInspectionRef.ShowDialog();

        }

        private void btnUrgency_Click(object sender, EventArgs e) {
            Document = Globals.ThisAddIn.Application.Documents.Open(FrmLetterData.DocPath);

            if (Document != null) {
                string searchedForStr =
                    $"{LetterSentences.Inspection} {LetterSentences.Num}" +
                    $" {FrmLetterData.InspectionNumber} {LetterSentences.ForYear}" +
                    $" {FrmLetterData.InspectYear}";
                FindHelper findHelper = new FindHelper(Document, searchedForStr);

                if (findHelper.FoundInfoList.Count != 0) {
                    
                }
            }
                
        }
    }
}