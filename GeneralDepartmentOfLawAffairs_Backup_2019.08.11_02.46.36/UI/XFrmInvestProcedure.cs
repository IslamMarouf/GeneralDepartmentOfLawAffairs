using System;
using System.Windows.Forms;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmInvestProcedure : DevExpress.XtraEditors.XtraForm
    {
        public LetterData FrmLetterData { get; set; }

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
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            XFrmRegularNotification xFrmRegular = new XFrmRegularNotification();
            xFrmRegular.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            xFrmRegular.ShowDialog();
        }

        private void btnIntensiveNotification_Click(object sender, EventArgs e)
        {
            XFrmIntensiveNotification xFrmIntensiveNotification = new XFrmIntensiveNotification();
            xFrmIntensiveNotification.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            xFrmIntensiveNotification.ShowDialog();
        }

        private void btnSpecialNotification_Click(object sender, EventArgs e)
        {
            XFrmSpecialNotification xFrmSpecialNotification = new XFrmSpecialNotification();
            xFrmSpecialNotification.FrmLetterData.SubjectId = FrmLetterData.SubjectId;
            xFrmSpecialNotification.ShowDialog();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            XFrmInvestInquiry xfrmInvestInquiry =
                new XFrmInvestInquiry {
                    FrmLetterData = {SubjectId = FrmLetterData.SubjectId}
                };
            xfrmInvestInquiry.ShowDialog();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            XFrmApReferring xFrmApReferring = new XFrmApReferring {
                FrmLetterData = {SubjectId = FrmLetterData.SubjectId}
            };
            xFrmApReferring.ShowDialog();

        }

        private void dbtnNote_Click(object sender, EventArgs e)
        {
            XFrmRegularNote xFrmRegularNote = new XFrmRegularNote {
                FrmLetterData = {SubjectId = FrmLetterData.SubjectId}
            };
            xFrmRegularNote.ShowDialog();
        }

        private void btnCeaseNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            
            XFrmCeaseNote xFrmCeaseNote = new XFrmCeaseNote {
                FrmLetterData = {SubjectId = FrmLetterData.SubjectId}
            };
            xFrmCeaseNote.ShowDialog();
        }

        private void btnTableNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmTableNote xFrmTableNote = new XFrmTableNote {
                FrmLetterData = {SubjectId = FrmLetterData.SubjectId}
            };
            xFrmTableNote.ShowDialog();
        }

        private void btnUrgency_Click(object sender, EventArgs e)
        {
            // ... 
        }
    }
}