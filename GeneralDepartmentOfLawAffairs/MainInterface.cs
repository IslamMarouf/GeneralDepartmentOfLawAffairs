using Microsoft.Office.Tools.Ribbon;

namespace GeneralDepartmentOfLawAffairs {
    public partial class MainInterface {
        private void MainInterface_Load(object sender, RibbonUIEventArgs e) {
            btnHurry.Enabled = false;
            btn_report.Enabled = false;
        }

        private void btnNormalNotification_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RegularNotificationLetter rnl = new RegularNotificationLetter(document);
            rnl.Write();
        }

        private void btnConfNotification_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            IntensiveNotificationLetter inl = new IntensiveNotificationLetter(document);
            inl.Write();
        }

        private void btnSpecialNotification_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            SpecialNotificationLetter snl = new SpecialNotificationLetter(document);
            snl.Write();
        }

        private void btnInvestInquiry_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InvestInquiryLetter iql = new InvestInquiryLetter(document);
            iql.Write();
        }

        private void btnCeaseNote_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            CeaseNote cnl = new CeaseNote(document);
            cnl.Write();
        }

        private void btnRegularNote_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RegularNote rnl = new RegularNote(document);
            rnl.Write();
        }

        private void btnTableNote_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            TableNote tnl = new TableNote(document);
            tnl.Write();
        }

        private void btnInvestigationReferringLetter_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            ReferringLetter rl = new ReferringLetter(document);
            rl.Write();
        }

        private void btnInspectionLetter_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionLetter inspectionLetter = new InspectionLetter(document);
            inspectionLetter.Write();
        }

        private void btnInspecInquiry_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspecInquiryLetter inspecl = new InspecInquiryLetter(document);
            inspecl.Write();
        }

        private void btnInspectionNote_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionNote inl = new InspectionNote(document);
            inl.Write();
        }

        private void btnInspectionReferringLetter_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionRefLetter irl = new InspectionRefLetter(document);
            irl.Write();
        }

        private void btnGeneralLetter_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            EmptyLetter el = new EmptyLetter(document);
            el.Write();
        }

        private void btnIssuanceRescript_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            IssuanceRescriptLetter irl = new IssuanceRescriptLetter(document);
            irl.Write();
        }

        private void btnRescriptSent_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RescriptSentLetter rsl = new RescriptSentLetter(document);
            rsl.Write();
        }

        private void btnNominationLetter_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            NominationLetter nl = new NominationLetter(document);
            nl.Write();
        }

        private void btnMission_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            MissionLetter missionLetter = new MissionLetter(document);
            missionLetter.Write();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e) {
            var formAbout = new FrmAbout();
            formAbout.ShowDialog();
        }

        private void btn_settings_Click(object sender, RibbonControlEventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void btnAddCeaseInvestigation_Click(object sender, RibbonControlEventArgs e)
        {
            FrmAddCeaseInvestigation frmAddCeaseInvestigation = new FrmAddCeaseInvestigation();
            frmAddCeaseInvestigation.ShowDialog();
        }

        private void btnAddInvestigation_Click(object sender, RibbonControlEventArgs e)
        {
            FrmAddInvestigation frmAddInvestigation = new FrmAddInvestigation();
            frmAddInvestigation.ShowDialog();
        }

        private void btnAddInspection_Click(object sender, RibbonControlEventArgs e)
        {
            FrmAddInspection frmAddInspection = new FrmAddInspection();
            frmAddInspection.ShowDialog();
        }
    }
}