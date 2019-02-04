using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;

namespace GeneralDepartmentOfLawAffairs {
    public partial class MainInterface {
        private void MainInterface_Load(object sender, RibbonUIEventArgs e) {
            
            btn_report.Enabled = false;

            string conString = "SELECT * FROM tblSubjects";
            OleDbDataAdapter subjectsDataAdapter = new OleDbDataAdapter();
            OleDbCommand odbCommand = new OleDbCommand();
            DataSet ds = new DataSet();
            odbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            odbCommand.CommandType = CommandType.Text;
            odbCommand.CommandText = conString;
            subjectsDataAdapter.SelectCommand = odbCommand;
            subjectsDataAdapter.Fill(ds, "tblSubjects");

            var investigations = from sb in ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals("تحقيق")
                
                select sb;

            foreach (var invesRow in investigations)
            {
                RibbonButton btnItem = Factory.CreateRibbonButton();
                btnItem.Label = $"{invesRow.Field<string>("subject_type") + invesRow.Field<string>("subject_num") + "لسنة" + invesRow.Field<string>("subject_year")} استعجال في ";
                btnItem.Name = "btn" + invesRow.Field<string>("subject_num");
                mnuRush.Items.Add(btnItem);
            }

            /*
               If the user selected the LINQ to Object method, we must fi rst build a DataSet and fill it
               with our Faculty data table. The reason for that is because there is no direct relationship
               between the LINQ and the Microsoft Access database, but we can set up an indirect
               relationship between them using the LINQ to ADO.NET since ADO.NET covers any
               kinds of database including the Microsoft Access 2007. In order to set up this relationship,
               a DataSet must be built by fi lling it with the desired data table such as Faculty in this
               case. One point to note is that this DataSet is a nontyped DataSet if it is built in this way,
               and you must use the fi eld location, not fi eld name, to identify each column in the data
               table.
             */

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