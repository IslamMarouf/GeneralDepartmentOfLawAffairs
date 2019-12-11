using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmHurryLetters : Form
    {
        private OleDbConnection _dbConn;
        private string _oldbStr;
        private OleDbCommand _oleDbCommand;
        private OleDbDataReader _oleDbDataReader;
        private string _sConnection;

        public FrmHurryLetters() {
            InitializeComponent();
        }

        private void FrmHurryLetters_Load(object sender, EventArgs e) {
            try {
                _sConnection = "Provider=Microsoft.ACE.OLEDB.16.0;" + "Data Source=InspectionSubjects.accdb";
                _dbConn = new OleDbConnection(_sConnection);
                _dbConn.Open();

                _oldbStr = "SELECT * FROM tblSubjects " +
                           "WHERE (Date() - [LastActionDate]) > 15 " +
                           "AND tblSubjects.InspectionDone = No;";

                _oleDbCommand = new OleDbCommand {
                    CommandText = _oldbStr,
                    Connection = _dbConn
                };

                _oleDbDataReader = _oleDbCommand.ExecuteReader();

                while ((_oleDbDataReader != null) && _oleDbDataReader.Read())
                    cmbxSubjects.Items.Add(_oleDbDataReader["Number"]);

                cmbxSubjects.SelectedItem = cmbxSubjects.Items[0];

                MessageBox.Show(cmbxSubjects.Items.Count.ToString());

                Tag = cmbxSubjects.Items.Count;

                _oleDbDataReader?.Close();
                _dbConn?.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message +
                                Environment.NewLine +
                                ex.Data.Keys + " " + ex.Data.Values + Environment.NewLine +
                                ex.Data, ex.Source);
            }

            try {
                _sConnection = "Provider=Microsoft.ACE.OLEDB.16.0;" + "Data Source=InspectionSubjects.accdb";
                _dbConn = new OleDbConnection(_sConnection);
                _dbConn.Open();

                _oldbStr = "SELECT * FROM tblSubjects " +
                           "WHERE (Date() - [LastActionDate]) > 15 " +
                           "AND tblSubjects.InspectionDone = No " +
                           "AND tblSubjects.Number=" + cmbxSubjects.SelectedItem + ";";

                _oleDbCommand = new OleDbCommand {
                    CommandText = _oldbStr,
                    Connection = _dbConn
                };

                _oleDbDataReader = _oleDbCommand.ExecuteReader();

                if ((_oleDbDataReader != null) && _oleDbDataReader.Read())
                    lblSubjectType.Text = _oleDbDataReader["SubjectType"] + " رقم: ";

                _oleDbDataReader?.Close();
                _dbConn?.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message +
                                Environment.NewLine +
                                ex.Data.Keys + " " + ex.Data.Values + Environment.NewLine +
                                ex.Data, ex.Source);
            }
        }

        private void cmbxSubjects_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                _sConnection = "Provider=Microsoft.ACE.OLEDB.16.0;" + "Data Source=InspectionSubjects.accdb";
                _dbConn = new OleDbConnection(_sConnection);
                _dbConn.Open();

                _oldbStr = "SELECT * FROM tblSubjects " +
                           "WHERE (Date() - [LastActionDate]) > 15 " +
                           "AND tblSubjects.InspectionDone = No " +
                           "AND tblSubjects.Number=" + cmbxSubjects.SelectedItem + ";";

                _oleDbCommand = new OleDbCommand {
                    CommandText = _oldbStr,
                    Connection = _dbConn
                };

                _oleDbDataReader = _oleDbCommand.ExecuteReader();

                if ((_oleDbDataReader != null) && _oleDbDataReader.Read()) {
                    lblSubjectType.Text = _oleDbDataReader["SubjectType"] + " رقم: ";
                    txtActionCount.Text = (Convert.ToInt32(_oleDbDataReader["LstActCount"]) + 1).ToString();
                    txtSubject.Text = _oleDbDataReader["Subject"].ToString();
                }
                _oleDbDataReader?.Close();
                _dbConn?.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message +
                                Environment.NewLine +
                                ex.Data.Keys + " " + ex.Data.Values + Environment.NewLine +
                                ex.Data, ex.Source);
            }
        }

        private void FrmHurryLetters_FormClosed(object sender, FormClosedEventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void btnOK_Click(object sender, EventArgs e) {
            try {
                _sConnection = "Provider=Microsoft.ACE.OLEDB.16.0;" +
                               "Data Source=InspectionSubjects.accdb";

                _dbConn = new OleDbConnection(_sConnection);
                _dbConn.Open();

                _oldbStr = "UPDATE tblSubjects " +
                           "SET tblSubjects.LastActionDate=#" + DateTime.Now.ToString("d") + "# " +
                           "WHERE tblSubjects.Number=" + cmbxSubjects.SelectedItem + ";";

                _oleDbCommand = new OleDbCommand {
                    CommandText = _oldbStr,
                    Connection = _dbConn
                };

                _oleDbDataReader = _oleDbCommand.ExecuteReader();

                _oleDbDataReader?.Close();
                _dbConn?.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message +
                                Environment.NewLine +
                                ex.Data.Keys + " " + ex.Data.Values + Environment.NewLine +
                                ex.Data, ex.Source);
            }

            if (cmbxSubjects.Items.Count == 0) Tag = cmbxSubjects.Items.Count;
        }
    }
}