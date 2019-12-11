using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;
using GeneralDepartmentOfLawAffairs.Utils;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInvestProcedure : XtraForm
    {
        public LetterData FrmLetterData { get; set; }
        Document Document => null;

        public XFrmInvestProcedure()
        {
            InitializeComponent();
        }

        private void XFrmProcedure_Load(object sender, EventArgs e) {
            dflInvestProcedure.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            txtNum.Text = FrmLetterData.SubjectNum;
            txtYear.Text = FrmLetterData.SubjectYear;
            dtpAssignmentDate.EditValue = FrmLetterData.AssignmentDate;
            txt_about.Text = FrmLetterData.Subject;
            txtLastProcedure.Text = FrmLetterData.ProcedureName;
            dtProcedureDate.EditValue = FrmLetterData.ProcedureDate;

            if (!FrmLetterData.InvType.Equals(LetterSentences.Cease)) {
                btnCaeseNote.Enabled = false;
            }

            if (!FrmLetterData.ProcedureName.Equals(LetterSentences.Notification)) {
                btnIntensiveNotification.Enabled = false;
            }

            txtRemid.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if(cbxFinished.Checked)
                SubjectsHelper.UpdateFinished(FrmLetterData.SubjectId);

            if(cbRemind.Checked)
                SubjectsHelper.UpdateInWait(FrmLetterData.SubjectId, Int32.Parse(txtRemid.Text));

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            RegularNotificationLetter regularNotification = 
                new RegularNotificationLetter(this, FrmLetterData.SubjectId);
            regularNotification.Write();
        }

        private void btnIntensiveNotification_Click(object sender, EventArgs e)
        {
            IntensiveNotificationLetter intensiveNotification = 
                new IntensiveNotificationLetter(this, FrmLetterData.SubjectId);
            intensiveNotification.Write();
        }

        private void btnSpecialNotification_Click(object sender, EventArgs e)
        {
            SpecialNotificationLetter specialNotification = 
                new SpecialNotificationLetter(this, FrmLetterData.SubjectId);
            specialNotification.Write();
        }

        private void btnInquiry_Click(object sender, EventArgs e) {
            InvestInquiryLetter inquiryLetter = 
                new InvestInquiryLetter(this, FrmLetterData.SubjectId);
            inquiryLetter.Write();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            ReferringLetter referringLetter = 
                new ReferringLetter(this, FrmLetterData.SubjectId);
            referringLetter.Write();
        }

        private void dbtnNote_Click(object sender, EventArgs e)
        {
            RegularNote regularNote = 
                new RegularNote(this, FrmLetterData.SubjectId);
            regularNote.Write();
        }

        private void btnCeaseNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            CeaseNote ceaseNote = new CeaseNote(this, FrmLetterData.SubjectId);
            ceaseNote.Write();
        }

        private void btnTableNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TableNote tableNote = new TableNote(this, FrmLetterData.SubjectId);
            tableNote.Write();
        }

        private void btnUrgency_Click(object sender, EventArgs e) {

            /*
            var doc = Globals.ThisAddIn.Application.Documents.Open(@"C:\Users\manno\Desktop\BookmarkTest.docx");
            doc.Windows.CompareSideBySideWith(doc);
            Globals.ThisAddIn.Application.Windows.SyncScrollingSideBySide = false;
            Globals.ThisAddIn.Application.Windows.get_Item(doc).Activate();
            */
            DialogResult = DialogResult.OK;
            var doc = Globals.ThisAddIn.Application.Documents.Open(@"C:\Users\manno\Documents\مكاتبات مختلفة.docx");
            FindHelper findHelper = new FindHelper(doc, "فحص رقم 43 لسنة 2018");
            int page = findHelper.FoundInfoList.Last().PageNum;
            DocNav.GoToPage(doc, page);
            
        }

        private void cbRemind_CheckedChanged(object sender, EventArgs e) {
            txtRemid.Enabled = !txtRemid.Enabled;
        }
    }
}