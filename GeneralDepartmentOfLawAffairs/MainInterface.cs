using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using DevExpress.XtraBars.Alerter;
using GeneralDepartmentOfLawAffairs.Letters;
using GeneralDepartmentOfLawAffairs.Properties;
using GeneralDepartmentOfLawAffairs.Temp;
using GeneralDepartmentOfLawAffairs.UI;
using GeneralDepartmentOfLawAffairs.Utils;
using Microsoft.Office.Tools.Ribbon;

namespace GeneralDepartmentOfLawAffairs {
    public partial class MainInterface {
        
        #region  DATABASE VARIABLES

        /*
        In LINQ to Object method, we must first build a DataSet and fill it with
            our Subjects data table.The reason for that is because there is no direct
            relationship between the LINQ and the Microsoft Access database, but we
            can set up an indirect relationship between them using the LINQ to ADO.NET
            since ADO.NET covers any kinds of database including the Microsoft Access
            20016. In order to set up this relationship, a DataSet must be built by
            filling it with the desired data table such as Subjects in this case.
            One point to note is that this DataSet is a nontyped DataSet if it is 
            built in this way, and you must use the field location, not field name,
            to identify each column in the data table.
        */
        private const string ConString = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _odbCommand = new OleDbCommand();

        private const string CasesConString = "SELECT * FROM tblCases";
        private readonly OleDbDataAdapter _casesDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _odbCasesCommand = new OleDbCommand();

        private const string LettersConString = "SELECT * FROM tblLetters";
        private readonly OleDbDataAdapter _lettersDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _odbLettersCommand = new OleDbCommand();

        /*
           The DataSet is used to query data using the LINQ to DataSet method since
           there is no direct way to connect LINQ to the Microsoft Access database.
        */
        private readonly DataSet _ds = new DataSet();
        private readonly DataSet _cDs = new DataSet();
        private readonly DataSet _lDs = new DataSet();

        #endregion

        private void MainInterface_Load(object sender, RibbonUIEventArgs e) {
            btn_report.Enabled = true;
            AcInitValues(acSubjectsAlert, Color.Bisque);

            #region QUERIES

            PreparingQueries();
            InvestigationsQueries();
            InspectionsQueries();
            LettersQueries();
            CasesQueries();

            #endregion

            // Display version text.
            btnVersion.Label = $"الاصدار {About.AssemblyVersion}";
        }

        #region QUERRY METHODS

        private void PreparingQueries() {
/*
            *Globals.ThisAddIn.SubjectsConnection used to access and get the original
             *Connection object in the add-in and we need to use that connection here.
             *The Command instance is initialized with the Connection object that is
            *created in the ThisAddIn_Startup event.
             */
            _odbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _odbCommand.CommandType = CommandType.Text;
            _odbCommand.CommandText = ConString;
            _subjectsDataAdapter.SelectCommand = _odbCommand;
            _subjectsDataAdapter.Fill(_ds, "tblSubjects");

            //
            _odbCasesCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _odbCasesCommand.CommandType = CommandType.Text;
            _odbCasesCommand.CommandText = CasesConString;
            _casesDataAdapter.SelectCommand = _odbCasesCommand;
            _casesDataAdapter.Fill(_cDs, "tblCases");

            //
            _odbLettersCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _odbLettersCommand.CommandType = CommandType.Text;
            _odbLettersCommand.CommandText = LettersConString;
            _lettersDataAdapter.SelectCommand = _odbLettersCommand;
            _lettersDataAdapter.Fill(_lDs, "tblLetters");
        }

        void InvestigationsQueries() {
            var subs = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("Subject_type") == "تحقيق"
                select sb;

            int s = subs.Count();
            if (s == 0) {
                mnuInvestigation.Enabled = false;
            }

            var subjects = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("Subject_type") == "تحقيق"
                where sb.Field<string>("Subject_procedureName") == "إضافة"
                where sb.Field<DateTime?>("Subject_procedureDate") <= DateTime.Today.AddDays(-2)
                select sb;

            foreach (var subjectRow in subjects) {
                QueryResultItem(subjectRow, QueryFormType.InvProc);
            }

            var invNotification = from na in _ds.Tables["tblSubjects"].AsEnumerable()
                where na.Field<string>("Subject_type") == "تحقيق"
                where na.Field<string>("Subject_procedureName") == "إخطار"
                where na.Field<DateTime?>("Subject_procedureDate") <= DateTime.Today.AddDays(-2) &&
                      na.Field<DateTime?>("subject_procedureOutComDate").Equals(null)
                      || na.Field<DateTime?>("subject_sessionDate") <= DateTime.Today.AddDays(-1)
                select na;

            foreach (var naRow in invNotification) {
                if (naRow.Field<DateTime?>("subject_procedureOutComDate").Equals(null)) {
                    QueryResultItem(naRow, QueryFormType.InvOut);
                }
                else {
                    QueryResultItem(naRow, QueryFormType.InvProc);
                }
            }

            var invInquiry = from ia in _ds.Tables["tblSubjects"].AsEnumerable()
                where ia.Field<string>("Subject_type") == "تحقيق"
                where ia.Field<string>("Subject_procedureName") == "إستيفاء"
                where ia.Field<DateTime?>("Subject_procedureDate") <= DateTime.Today.AddDays(-2) &&
                      ia.Field<DateTime?>("subject_procedureOutComDate").Equals(null)
                      || ia.Field<DateTime?>("subject_procedureOutComDate") <= DateTime.Today.AddDays(-14)
                select ia;

            foreach (var ia in invInquiry) {
                if (ia.Field<DateTime?>("subject_procedureOutComDate").Equals(null)) {
                    QueryResultItem(ia, QueryFormType.InvOut);
                }
                else {
                    QueryResultItem(ia, QueryFormType.InvProc);
                }
            }

            var invNoteAdd = from invNote in _ds.Tables["tblSubjects"].AsEnumerable()
                where invNote.Field<string>("Subject_type") == "تحقيق"
                where invNote.Field<string>("Subject_procedureName") == "مذكرة"
                where invNote.Field<DateTime?>("Subject_procedureDate") <= DateTime.Today.AddDays(-5)
                select invNote;

            foreach (var invNote in invNoteAdd) {
                QueryResultItem(invNote, QueryFormType.InvOut);
            }

            
        }

        void InspectionsQueries() {
            RibbonSeparator separator = Factory.CreateRibbonSeparator();
            mnuRush.Items.Add(separator);

            var ins = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("Subject_type") == "فحص"
                select sb;

            int i = ins.Count();
            if (i == 0) {
                mnuInspection.Enabled = false;
            }

            var inspectAdd = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("Subject_type") == "فحص"
                where sb.Field<string>("Subject_procedureName") == "إضافة"
                where sb.Field<DateTime>("Subject_procedureDate") <= DateTime.Today.AddDays(-2)
                select sb;

            foreach (var inspectRow in inspectAdd) {
                QueryResultItem(inspectRow, QueryFormType.InsProc);
            }

            var inspectInquiry = from ia in _ds.Tables["tblSubjects"].AsEnumerable()
                where ia.Field<string>("Subject_type") == "فحص"
                where ia.Field<string>("Subject_procedureName") == "إستيفاء"
                where ia.Field<DateTime?>("Subject_procedureDate") <= DateTime.Today.AddDays(-2) &&
                      ia.Field<DateTime?>("subject_procedureOutComDate").Equals(null)
                      || ia.Field<DateTime?>("subject_procedureOutComDate") <= DateTime.Today.AddDays(-14)
                select ia;

            foreach (var ia in inspectInquiry) {
                QueryResultItem(ia, QueryFormType.InsProc);
            }
        }

        void CasesQueries() {
            RibbonSeparator casesSeparator = Factory.CreateRibbonSeparator();
            mnuRush.Items.Add(casesSeparator);

            var cs = from sb in _cDs.Tables["tblCases"].AsEnumerable()
                select sb;

            int cas = cs.Count();
            if (cas == 0) {
                mnuCase.Enabled = false;
            }

            var caseAdd = from c in _cDs.Tables["tblCases"].AsEnumerable()
                where c.Field<string>("case_lastProcedureName").Equals(LetterSentences.Add)
                where c.Field<DateTime>("case_lastProcedureDate") <= DateTime.Today.AddDays(-2)
                select c;

            foreach (var ca in caseAdd) {
                CaseQueryResultItem(ca, QueryFormType.CaseProc);
            }

            var caseIssuanceRes = from c in _cDs.Tables["tblCases"].AsEnumerable()
                where c.Field<string>("case_lastProcedureName").Equals(LetterSentences.APIssuance)
                where c.Field<DateTime>("case_lastProcedureDate") <= DateTime.Today.AddDays(-2) &&
                      c.Field<DateTime?>("case_lastProcedureOutcomDate").Equals(null)
                      || c.Field<DateTime?>("case_lastProcedureOutcomDate") <= DateTime.Today.AddDays(-14)
                select c;

            foreach (var ci in caseIssuanceRes) {
                if (ci.Field<DateTime?>("case_lastProcedureOutcomDate").Equals(null)) {
                    CaseQueryResultItem(ci, QueryFormType.CaseOut);
                }
                else {
                    CaseQueryResultItem(ci, QueryFormType.CaseProc);
                }
            }

            var caseResSent = from c in _cDs.Tables["tblCases"].AsEnumerable()
                where c.Field<string>("case_lastProcedureName").Equals(LetterSentences.APResSent)
                where c.Field<DateTime>("case_lastProcedureDate") <= DateTime.Today.AddDays(-2) &&
                      c.Field<DateTime?>("case_lastProcedureOutcomDate").Equals(null)
                select c;

            foreach (var ci in caseResSent) {
                CaseQueryResultItem(ci, QueryFormType.CaseOut);
            }
        }

        void LettersQueries() {
            RibbonSeparator lettersSeparator = Factory.CreateRibbonSeparator();
            mnuRush.Items.Add(lettersSeparator);
        }

        void Refresh() {
            _ds.Clear();
            _cDs.Clear();
            _lDs.Clear();
            mnuRush.Items.Clear();
            PreparingQueries();
            InvestigationsQueries();
            InspectionsQueries();
            LettersQueries();
            CasesQueries();
        }

        private void QueryResultItem(DataRow subjectRow, QueryFormType frmType) {
            RibbonButton btnItem = Factory.CreateRibbonButton();
            btnItem.Label =
                $"{LetterSentences.ProcedureIn + subjectRow.Field<string>("subject_type") + " " + LetterSentences.Num + " [" + subjectRow.Field<string>("subject_num") + "] " + LetterSentences.ForYear + " " + subjectRow.Field<string>("subject_year")}";
            btnItem.Name = "btn" + subjectRow.Field<string>("subject_num");
            btnItem.Click += MnuRush_Click;
            LetterData letterData = new LetterData {
                SubjectId = subjectRow.Field<string>("subject_id"),
                SubjectType = subjectRow.Field<string>("subject_type"),
                SubjectNum = subjectRow.Field<string>("subject_num"),
                SubjectYear = subjectRow.Field<string>("subject_year"),
                InvType = subjectRow.Field<string>("subject_investigationType"),
                AssignmentDate = subjectRow.Field<DateTime>("subject_assignmentDate"),
                Subject = subjectRow.Field<string>("subject_about"),
                ProcedureName = subjectRow.Field<string>("Subject_procedureName"),
                ProcedureDate = subjectRow.Field<DateTime>("Subject_procedureDate"),
                DocPath = subjectRow.Field<string>("subject_docPath"),
                FormType = frmType
            };

            btnItem.Tag = letterData;
            mnuRush.Items.Add(btnItem);
        }

        private void CaseQueryResultItem(DataRow caseRow, QueryFormType frmType) {
            RibbonButton btnItem = Factory.CreateRibbonButton();
            btnItem.Label =
                $"{LetterSentences.ProcedureIn + LetterSentences.Case + " " + LetterSentences.Num + " [" + caseRow.Field<string>("case_num") + "] " + LetterSentences.ForYear + " " + caseRow.Field<int>("case_year")}";
            btnItem.Name = "btn" + caseRow.Field<string>("case_num");
            btnItem.Click += MnuRush_Click;

            LetterData letterData = new LetterData {
                CaseId = caseRow.Field<string>("case_id"),
                CaseNumber = caseRow.Field<string>("case_num"),
                CaseYear = caseRow.Field<int>("case_year").ToString(),
                ApVal = caseRow.Field<string>("case_ap"),
                ApLetterNum = caseRow.Field<string>("case_apLetterNum"),
                DtLetterDate = caseRow.Field<DateTime?>("case_apLetterDate"),
                CaseResNum = caseRow.Field<string>("case_resolutionNum"),
                CaseResDate = caseRow.Field<DateTime?>("case_resolutionDate"),
                CaseResYear = caseRow.Field<int>("case_resolutionYear"),
                Guilty = caseRow.Field<string>("case_guiltyName"),
                Subject = caseRow.Field<string>("case_about"),
                ProcedureName = caseRow.Field<string>("case_lastProcedureName"),
                ProcedureDate = caseRow.Field<DateTime?>("case_lastProcedureDate"),
                DocPath = caseRow.Field<string>("case_docPath"),
                SubjectType = LetterSentences.Case,
                SubjectNum = caseRow.Field<string>("case_num"),
                SubjectYear = caseRow.Field<int>("case_year").ToString(),
                FormType = frmType
            };

            btnItem.Tag = letterData;
            mnuRush.Items.Add(btnItem);
        }

        private void LetterQueryResultItem(DataRow letterRow, QueryFormType frmType) {
            RibbonButton btnItem = Factory.CreateRibbonButton();
            btnItem.Label =
                $"{LetterSentences.ProcedureIn + letterRow.Field<string>("subject_type") + " " + LetterSentences.Num + " [" + letterRow.Field<string>("subject_num") + "] " + LetterSentences.ForYear + " " + letterRow.Field<string>("subject_year")}";
            btnItem.Name = "btn" + letterRow.Field<string>("subject_num");
            btnItem.Click += MnuRush_Click;

            LetterData letterData = new LetterData {
                LetterId = "",
                LetterNumber = "",
                LetterDate = "",
                Subject = "",
                ProcedureName = "",
                ProcedureDate = DateTime.Today,
                DocPath = letterRow.Field<string>("letter_docPath"),
                FormType = frmType
            };

            btnItem.Tag = letterData;
            mnuRush.Items.Add(btnItem);
        }

        private void MnuRush_Click(object sender, RibbonControlEventArgs e) {
            if (!(sender is RibbonButton clickedItem)) return;
            if (((LetterData) clickedItem.Tag).DocPath != null && !((LetterData) clickedItem.Tag).DocPath.Equals(""))
                QueryDocument((LetterData) clickedItem.Tag);
            QueryForm((LetterData) clickedItem.Tag);
        }

        void QueryDocument(LetterData letterData) {
            if (!letterData.DocPath.Equals(Globals.ThisAddIn.Application.ActiveDocument.FullName)) {
                var doc = Globals.ThisAddIn.Application.Documents.Open(letterData.DocPath);
                doc.Activate();
            }
        }

        private void QueryForm(LetterData frmLetterData) {
            switch (frmLetterData.FormType) {
                case QueryFormType.InvProc:
                    XFrmInvestProcedure frmInvestProcedure = new XFrmInvestProcedure();
                    frmInvestProcedure.FrmLetterData = frmLetterData;
                    frmInvestProcedure.ShowDialog();
                    break;
                case QueryFormType.InvOut:
                    XFrmInvestProcOut frmInvestProcOut = new XFrmInvestProcOut();
                    frmInvestProcOut.FrmLetterData = frmLetterData;
                    frmInvestProcOut.ShowDialog();
                    break;
                case QueryFormType.InvNote:
                    MessageBox.Show("InvNote");
                    break;
                case QueryFormType.InsProc:
                    XFrmInspectProcedure frmInspectProcedure = new XFrmInspectProcedure();
                    frmInspectProcedure.FrmLetterData = frmLetterData;
                    frmInspectProcedure.ShowDialog();
                    break;
                case QueryFormType.InsOut:
                    XFrmInspectProcOut frmInspectProcOut = null;
                    frmInspectProcOut.FrmLetterData = frmLetterData;
                    frmInspectProcOut.ShowDialog();
                    break;
                case QueryFormType.InsNote:
                    MessageBox.Show("InsNote");
                    break;
                case QueryFormType.CaseProc:
                    XFrmCaseProcedure xFrmCaseProcedure = new XFrmCaseProcedure();
                    xFrmCaseProcedure.FrmLetterData = frmLetterData;
                    xFrmCaseProcedure.ShowDialog();
                    break;
                case QueryFormType.CaseOut:
                    XFrmCaseProcOut xFrmCaseProcOut = new XFrmCaseProcOut();
                    xFrmCaseProcOut.FrmLetterData = frmLetterData;
                    xFrmCaseProcOut.ShowDialog();
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region BUTTONS

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
            InspectInquiryLetter inspecl = new InspectInquiryLetter(document);
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
            var formAbout = new XfrmAbout();
            formAbout.ShowDialog();
        }

        private void btn_settings_Click(object sender, RibbonControlEventArgs e) {
            XFrmSettings xFrmSettings = new XFrmSettings();
            xFrmSettings.Show();
        }

        private void btnAddCeaseInvestigation_Click(object sender, RibbonControlEventArgs e) {
            XFrmAddCeaseInvestigation frmAddCeaseInvestigation = new XFrmAddCeaseInvestigation();
            frmAddCeaseInvestigation.ShowDialog();
        }

        private void btnAddInvestigation_Click(object sender, RibbonControlEventArgs e) {
            XFrmAddInvestigation xFrmAddInvestigation = new XFrmAddInvestigation();
            xFrmAddInvestigation.ShowDialog();
        }

        private void btnAddInspection_Click(object sender, RibbonControlEventArgs e) {
            XFrmAddInspection xFrmAddInspection = new XFrmAddInspection();
            xFrmAddInspection.ShowDialog();
        }

        private void MainInterface_Close(object sender, EventArgs e) {
            _subjectsDataAdapter?.Dispose();
            _odbCommand?.Dispose();

            _casesDataAdapter?.Dispose();
            _odbCasesCommand?.Dispose();

            _lettersDataAdapter?.Dispose();
            _odbLettersCommand?.Dispose();
        }

        private void btn_report_Click(object sender, RibbonControlEventArgs e) {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
        }

        private void btnHelp_Click(object sender, RibbonControlEventArgs e) {
            var document = Globals.ThisAddIn.Application.ActiveDocument;
            //FindHelper found = new FindHelper(document, "فحص رقم 43 لسنة 2019");
            //string str = found.ToString();
            /*
            Random rand = new Random();
            for (int i = 0; i < 40; i++)
            {
                Debug.WriteLine(rand.Next(1, 100));
            } */

            //DocManager.OpenDocSideBySide(document);
        }

        private void btnCase_Click(object sender, RibbonControlEventArgs e) {
            XFrmAddCase xFrmAddCase = new XFrmAddCase();
            xFrmAddCase.ShowDialog();
        }

        private void btnLetter_Click(object sender, RibbonControlEventArgs e) {
            XFrmAddLetter xFrmAddLetter = new XFrmAddLetter();
            xFrmAddLetter.ShowDialog();
        }

        #endregion

        private void AcInitValues(AlertControl alertControl, Color color) {
            acSubjectsAlert = alertControl;
            acSubjectsAlert.AutoFormDelay = 20000;
            acSubjectsAlert.ControlBoxPosition = AlertFormControlBoxPosition.Top;
            acSubjectsAlert.FormDisplaySpeed = AlertFormDisplaySpeed.Slow;
            acSubjectsAlert.FormLocation = AlertFormLocation.BottomRight;
            acSubjectsAlert.FormShowingEffect = AlertFormShowingEffect.MoveHorizontal;
            // acSubjectsAlert.AppearanceCaption.BackColor = color;
            acSubjectsAlert.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;
            acSubjectsAlert.AllowHtmlText = false;
            acSubjectsAlert.ShowCloseButton = true;
            acSubjectsAlert.ShowPinButton = true;
            acSubjectsAlert.ShowToolTips = false;
            acSubjectsAlert.AutoHeight = true;
            acSubjectsAlert.FormMaxCount = 20;
        }

        private void mnuRush_ItemsLoading(object sender, RibbonControlEventArgs e) {
            Refresh();
        }

        private void AlertsTimer_Tick(object sender, EventArgs e) {
            Refresh();

            foreach (var item in mnuRush.Items) {
                if (item.Tag == null) continue;
                var caption = ((LetterData) item.Tag).SubjectType + " " + LetterSentences.Num + " " +
                              ((LetterData) item.Tag).SubjectNum + " " + LetterSentences.ForYear + " " +
                              ((LetterData) item.Tag).SubjectYear;
                var text = ((LetterData) item.Tag).Subject;
                acSubjectsAlert.Show(null, caption, text);
            }
        }

        private void acSubjectsAlert_FormLoad(object sender, AlertFormLoadEventArgs e) {
        }

        private void acSubjectsAlert_BeforeFormShow(object sender, AlertFormEventArgs e) {
        }
    }
}