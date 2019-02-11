using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class MainInterface
    {
        private void MainInterface_Load(object sender, RibbonUIEventArgs e)
        {
            btn_report.Enabled = false;

            /*
               In LINQ to Object method, we must first build a DataSet and fill it with
               our Subjects data table. The reason for that is because there is no direct
               relationship between the LINQ and the Microsoft Access database, but we
               can set up an indirect relationship between them using the LINQ to ADO.NET
               since ADO.NET covers any kinds of database including the Microsoft Access
               20016. In order to set up this relationship, a DataSet must be built by
               filling it with the desired data table such as Subjects in this case.
               One point to note is that this DataSet is a nontyped DataSet if it is 
               built in this way, and you must use the field location, not field name,
               to identify each column in the data table.
             */

            string conString = "SELECT * FROM tblSubjects";
            OleDbDataAdapter subjectsDataAdapter = new OleDbDataAdapter();
            OleDbCommand odbCommand = new OleDbCommand();

            /*
               The DataSet is used to query data using the LINQ to DataSet method since
               there is no direct way to connect LINQ to the Microsoft Access database.
             */
            DataSet ds = new DataSet();

            /*
             * Globals.ThisAddIn.SubjectsConnection used to access and get the original
             * Connection object in the add-in and we need to use that connection here.
             * The Command instance is initialized with the Connection object that is
             * created in the ThisAddIn_Startup event.
             */
            odbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            odbCommand.CommandType = CommandType.Text;
            odbCommand.CommandText = conString;
            subjectsDataAdapter.SelectCommand = odbCommand;
            subjectsDataAdapter.Fill(ds, "tblSubjects");

            var investigations = from sb in ds.Tables["tblSubjects"].AsEnumerable()
                                select sb;
            

            foreach (var invesRow in investigations)
            {
                RibbonButton btnItem = Factory.CreateRibbonButton();
                btnItem.Label =
                    $"{LetterSentences.Rush + invesRow.Field<string>("subject_type") + " " + LetterSentences.Num + " [" + invesRow.Field<string>("subject_num") + "] " + LetterSentences.ForYear + " " + invesRow.Field<string>("subject_year")}";
                btnItem.Name = "btn" + invesRow.Field<string>("subject_num");
                btnItem.Click += MnuRush_Click;
                mnuRush.Items.Add(btnItem);
            }
            subjectsDataAdapter?.Dispose();
            odbCommand?.Dispose();
        }


        private void MnuRush_Click(object sender, RibbonControlEventArgs e)
        {
            if (!(sender is RibbonButton clickedItem)) return;
            var text = clickedItem.Label;
            var subjectNum = text.Substring(text.IndexOf('[') + 1, (text.IndexOf(']') - text.IndexOf('[')) - 1);
            var subjectType = text.Substring(13, text.IndexOf('ر') - 14);
            FrmProcedure frmProc = new FrmProcedure();
            frmProc.Text = text;
            frmProc._LetterData.Subject = text;
            frmProc.Show();
        }

        private void btnNormalNotification_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RegularNotificationLetter rnl = new RegularNotificationLetter(document);
            rnl.Write();
        }

        private void btnConfNotification_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            IntensiveNotificationLetter inl = new IntensiveNotificationLetter(document);
            inl.Write();
        }

        private void btnSpecialNotification_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            SpecialNotificationLetter snl = new SpecialNotificationLetter(document);
            snl.Write();
        }

        private void btnInvestInquiry_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InvestInquiryLetter iql = new InvestInquiryLetter(document);
            iql.Write();
        }

        private void btnCeaseNote_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            CeaseNote cnl = new CeaseNote(document);
            cnl.Write();
        }

        private void btnRegularNote_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RegularNote rnl = new RegularNote(document);
            rnl.Write();
        }

        private void btnTableNote_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            TableNote tnl = new TableNote(document);
            tnl.Write();
        }

        private void btnInvestigationReferringLetter_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            ReferringLetter rl = new ReferringLetter(document);
            rl.Write();
        }

        private void btnInspectionLetter_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionLetter inspectionLetter = new InspectionLetter(document);
            inspectionLetter.Write();
        }

        private void btnInspecInquiry_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspecInquiryLetter inspecl = new InspecInquiryLetter(document);
            inspecl.Write();
        }

        private void btnInspectionNote_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionNote inl = new InspectionNote(document);
            inl.Write();
        }

        private void btnInspectionReferringLetter_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            InspectionRefLetter irl = new InspectionRefLetter(document);
            irl.Write();
        }

        private void btnGeneralLetter_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            EmptyLetter el = new EmptyLetter(document);
            el.Write();
        }

        private void btnIssuanceRescript_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            IssuanceRescriptLetter irl = new IssuanceRescriptLetter(document);
            irl.Write();
        }

        private void btnRescriptSent_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            RescriptSentLetter rsl = new RescriptSentLetter(document);
            rsl.Write();
        }

        private void btnNominationLetter_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            NominationLetter nl = new NominationLetter(document);
            nl.Write();
        }

        private void btnMission_Click(object sender, RibbonControlEventArgs e)
        {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            MissionLetter missionLetter = new MissionLetter(document);
            missionLetter.Write();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
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

        private void MainInterface_Close(object sender, EventArgs e)
        {

        }
    }
}