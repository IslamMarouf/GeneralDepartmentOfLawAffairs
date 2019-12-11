using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs.Temp {
    public partial class FrmReport : GeneralForm {
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

        private const string ConString = "SELECT * FROM tblSubjects";
        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _odbCommand = new OleDbCommand();

        /*
           The DataSet is used to query data using the LINQ to DataSet method since
           there is no direct way to connect LINQ to the Microsoft Access database.
        */
        private readonly DataSet _ds = new DataSet();

        private DataTable _dtInvestigations = new DataTable();
        private DataTable _dtInspections = new DataTable();

        public FrmReport() {
            InitializeComponent();

            /*
             * Globals.ThisAddIn.SubjectsConnection used to access and get the original
             * Connection object in the add-in and we need to use that connection here.
             * The Command instance is initialized with the Connection object that is
             * created in the ThisAddIn_Startup event.
             */
            _odbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _odbCommand.CommandType = CommandType.Text;
            _odbCommand.CommandText = ConString;
            _subjectsDataAdapter.SelectCommand = _odbCommand;
            _subjectsDataAdapter.Fill(_ds, "tblSubjects");
        }

        private void FrmReport_Load(object sender, EventArgs e) {
            rbtnAll.Checked = true;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void AllInspectionsQuery() {
            var inspections = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                orderby sb.Field<DateTime>("subject_assignmentDate")
                select new {
                    subject_num = sb.Field<string>("subject_num"),
                    subject_year = sb.Field<string>("subject_year"),
                    subject_about = sb.Field<string>("subject_about"),
                    subject_assignmentDate = sb.Field<DateTime>("subject_assignmentDate"),
                    subject_procedureName = sb.Field<string>("subject_procedureName"),
                    subject_procedureOutComNum = sb.Field<string>("subject_procedureOutComNum"),
                    //subject_procedureOutComDate = sb.Field<DateTime>("subject_procedureOutComDate")
                    
                };

            var inspectionsResult = inspections.ToList();
            
            dgvInspections.DataSource = inspectionsResult;
            dgvInspections.Columns[0].HeaderText = LetterSentences.Inspection + " " + LetterSentences.Num;
            dgvInspections.Columns[1].HeaderText = LetterSentences.ForYear;
            dgvInspections.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInspections.Columns[2].HeaderText = LetterSentences.about;
            dgvInspections.Columns[3].HeaderText = LetterSentences.AssignmentDate;
            dgvInspections.Columns[4].HeaderText = LetterSentences.LastProcedure;
            dgvInspections.Columns[5].HeaderText = LetterSentences.OutCome;
            //dgvInspections.Columns[6].HeaderText = LetterSentences.Dated;
        }

        private void AllInvestigationsQuery() {
            var investigations = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                orderby sb.Field<DateTime>("subject_assignmentDate")
                select new {
                    subject_num = sb.Field<string>("subject_num"),
                    subject_year = sb.Field<string>("subject_year"),
                    subject_about = sb.Field<string>("subject_about"),
                    subject_assignmentDate = sb.Field<DateTime>("subject_assignmentDate"),
                    subject_procedureName = sb.Field<string>("subject_procedureName"),
                    subject_procedureOutComNum = sb.Field<string>("subject_procedureOutComNum"),
                    //subject_procedureOutComDate = sb.Field<DateTime>("subject_procedureOutComDate")
                };

            var result = investigations.ToList();
            dgvInvestigations.DataSource = result;
            dgvInvestigations.Columns[0].HeaderText = LetterSentences.Investigation + " " + LetterSentences.Num;
            dgvInvestigations.Columns[1].HeaderText = LetterSentences.ForYear;
            dgvInvestigations.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInvestigations.Columns[2].HeaderText = LetterSentences.about;
            dgvInvestigations.Columns[3].HeaderText = LetterSentences.AssignmentDate;
            dgvInvestigations.Columns[4].HeaderText = LetterSentences.LastProcedure;
            dgvInvestigations.Columns[5].HeaderText = LetterSentences.OutCome;
            //dgvInvestigations.Columns[6].HeaderText = LetterSentences.Dated;
        }

        private void DgvInvestigationsOnDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
        }

        private void FrmReport_FormClosing(object sender, FormClosingEventArgs e) {
            _subjectsDataAdapter?.Dispose();
            _odbCommand?.Dispose();
        }

        private void ViewType_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbtnAll) {
                AllInvestigationsQuery();
                AllInspectionsQuery();
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
                btnViewSubjects.Enabled = false;
            }
            else if (sender == rbtnCustomView) {
                dtpFrom.Enabled = !dtpFrom.Enabled;
                dtpTo.Enabled = !dtpTo.Enabled;
                btnViewSubjects.Enabled = !btnViewSubjects.Enabled;
            }
        }

        private void InspectionsDateQuery() {
            var inspections = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Inspection)
                where sb.Field<DateTime>("subject_assignmentDate") >= dtpFrom.Value &&
                      sb.Field<DateTime>("subject_assignmentDate") <= dtpTo.Value
                orderby sb.Field<DateTime>("subject_assignmentDate")
                select new {
                    subject_num = sb.Field<string>("subject_num"),
                    subject_year = sb.Field<string>("subject_year"),
                    subject_about = sb.Field<string>("subject_about"),
                    subject_assignmentDate = sb.Field<DateTime>("subject_assignmentDate"),
                    subject_procedureName = sb.Field<string>("subject_procedureName"),
                    subject_procedureOutComNum = sb.Field<string>("subject_procedureOutComNum"),
                    //subject_procedureOutComDate = sb.Field<DateTime>("subject_procedureOutComDate")
                };

            var inspectionsResult = inspections.ToList();
            dgvInspections.DataSource = inspectionsResult;
            dgvInspections.Columns[0].HeaderText = LetterSentences.Inspection + " " + LetterSentences.Num;
            dgvInspections.Columns[1].HeaderText = LetterSentences.ForYear;
            dgvInspections.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInspections.Columns[2].HeaderText = LetterSentences.about;
            dgvInspections.Columns[3].HeaderText = LetterSentences.AssignmentDate;
            dgvInspections.Columns[4].HeaderText = LetterSentences.LastProcedure;
            dgvInspections.Columns[5].HeaderText = LetterSentences.OutCome;
            //dgvInspections.Columns[6].HeaderText = LetterSentences.Dated;
        }

        private void InvestigationsDateQuery() {
            var investigations = from sb in _ds.Tables["tblSubjects"].AsEnumerable()
                where sb.Field<string>("subject_type").Equals(LetterSentences.Investigation)
                where sb.Field<DateTime>("subject_assignmentDate") >= dtpFrom.Value &&
                      sb.Field<DateTime>("subject_assignmentDate") <= dtpTo.Value
                orderby sb.Field<DateTime>("subject_assignmentDate")
                select new {
                    subject_num = sb.Field<string>("subject_num"),
                    subject_year = sb.Field<string>("subject_year"),
                    subject_about = sb.Field<string>("subject_about"),
                    subject_assignmentDate = sb.Field<DateTime>("subject_assignmentDate"),
                    subject_procedureName = sb.Field<string>("subject_procedureName"),
                    subject_procedureOutComNum = sb.Field<string>("subject_procedureOutComNum"),
                    //subject_procedureOutComDate = sb.Field<DateTime>("subject_procedureOutComDate")
                };

            var result = investigations.ToList();
            dgvInvestigations.DataSource = result;
            dgvInvestigations.Columns[0].HeaderText = LetterSentences.Investigation + " " + LetterSentences.Num;
            dgvInvestigations.Columns[1].HeaderText = LetterSentences.ForYear;
            dgvInvestigations.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInvestigations.Columns[2].HeaderText = LetterSentences.about;
            dgvInvestigations.Columns[3].HeaderText = LetterSentences.AssignmentDate;
            dgvInvestigations.Columns[4].HeaderText = LetterSentences.LastProcedure;
            dgvInvestigations.Columns[5].HeaderText = LetterSentences.OutCome;
            //dgvInvestigations.Columns[6].HeaderText = LetterSentences.Dated;
        }

        private void btnViewSubjects_Click(object sender, EventArgs e) {
            InvestigationsDateQuery();
            InspectionsDateQuery();
        }

        private void btnPrint_Click(object sender, EventArgs e) {

            
        }
    }
}