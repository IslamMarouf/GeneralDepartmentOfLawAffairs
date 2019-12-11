using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GeneralDepartmentOfLawAffairs.UI {
    public partial class Direction : DevExpress.XtraEditors.XtraUserControl {
        private readonly OleDbConnection _apAddressesConnection = new OleDbConnection();

        public bool Filled { get; set; }
        public string MrMrsVal { get; set; }
        public string RecipientVal { get; set; }
        public string DeptNameVal { get; set; }
        public string ApAddressVal { get; set; }


        private List<string> RegonalsNames { get; }
        public List<string> ApAddresses { get; set; }public List<string> ApNames { get; set; }
        private List<string> GDeptNamesList { get; }
        private List<string> CDeptNamesList { get; }

        public Direction() {
            InitializeComponent();

            CDeptNamesList = new List<string>();
            GDeptNamesList = new List<string>();
            ApNames = new List<string>();
            ApAddresses = new List<string>();
            RegonalsNames = new List<string>();
            Filled = false;

            MrMrsVal = "";
            RecipientVal = "";
            DeptNameVal = "";
            ApAddressVal = "";

            CDeptNamesList.Add(LetterSentences.HGC);
            CDeptNamesList.Add(LetterSentences.CentralDepartName);
            CDeptNamesList.Add(LetterSentences.CDept1);
            CDeptNamesList.Add(LetterSentences.CDept2);
            CDeptNamesList.Add(LetterSentences.CDept3);
            CDeptNamesList.Add(LetterSentences.CDept4);
            CDeptNamesList.Add(LetterSentences.CDept5);
            CDeptNamesList.Add(LetterSentences.CDept6);
            CDeptNamesList.Add(LetterSentences.CDept7);

            GDeptNamesList.Add(LetterSentences.GeneralDepartName);
            GDeptNamesList.Add(LetterSentences.GDept1);
            GDeptNamesList.Add(LetterSentences.GDept10);
            GDeptNamesList.Add(LetterSentences.GDept11);
            GDeptNamesList.Add(LetterSentences.GDept12);
            GDeptNamesList.Add(LetterSentences.GDept13);
            GDeptNamesList.Add(LetterSentences.GDept14);
            GDeptNamesList.Add(LetterSentences.GDept15);
            GDeptNamesList.Add(LetterSentences.GDept16);
            GDeptNamesList.Add(LetterSentences.GDept17);
            GDeptNamesList.Add(LetterSentences.GDept18);
            GDeptNamesList.Add(LetterSentences.GDept19);
            GDeptNamesList.Add(LetterSentences.GDept2);
            GDeptNamesList.Add(LetterSentences.GDept20);
            GDeptNamesList.Add(LetterSentences.GDept21);
            GDeptNamesList.Add(LetterSentences.GDept22);
            GDeptNamesList.Add(LetterSentences.GDept23);
            GDeptNamesList.Add(LetterSentences.GDept24);
            GDeptNamesList.Add(LetterSentences.GDept25);
            GDeptNamesList.Add(LetterSentences.GDept26);
            GDeptNamesList.Add(LetterSentences.GDept27);
            GDeptNamesList.Add(LetterSentences.GDept28);
            GDeptNamesList.Add(LetterSentences.GDept29);
            GDeptNamesList.Add(LetterSentences.GDept3);
            GDeptNamesList.Add(LetterSentences.GDept30);
            GDeptNamesList.Add(LetterSentences.GDept31);
            GDeptNamesList.Add(LetterSentences.GDept32);
            GDeptNamesList.Add(LetterSentences.GDept33);
            GDeptNamesList.Add(LetterSentences.GDept4);
            GDeptNamesList.Add(LetterSentences.GDept5);
            GDeptNamesList.Add(LetterSentences.GDept6);
            GDeptNamesList.Add(LetterSentences.GDept7);
            GDeptNamesList.Add(LetterSentences.GDept8);
            GDeptNamesList.Add(LetterSentences.GDept9);

            RegonalsNames.Add(LetterSentences.Giza);
            RegonalsNames.Add(LetterSentences.BanySwaif);
            RegonalsNames.Add(LetterSentences.Menya);
            RegonalsNames.Add(LetterSentences.Asiut);
            RegonalsNames.Add(LetterSentences.Sohag);
            RegonalsNames.Add(LetterSentences.Quena);
            RegonalsNames.Add(LetterSentences.Luxor);
            RegonalsNames.Add(LetterSentences.Aswan);
            RegonalsNames.Add(LetterSentences.Cairo);
            RegonalsNames.Add(LetterSentences.Alexandria);
            RegonalsNames.Add(LetterSentences.Behera);
            RegonalsNames.Add(LetterSentences.Qalyobeya);
            RegonalsNames.Add(LetterSentences.Monofeya);
            RegonalsNames.Add(LetterSentences.Daqahleya);
            RegonalsNames.Add(LetterSentences.Sharqeya);
            RegonalsNames.Add(LetterSentences.Gharbeya);
            RegonalsNames.Add(LetterSentences.KafrElSheikh);
            RegonalsNames.Add(LetterSentences.PortSaid);
            RegonalsNames.Add(LetterSentences.Swez);
            RegonalsNames.Add(LetterSentences.Ismaeileya);
            RegonalsNames.Add(LetterSentences.MarsaMatrouh);
            RegonalsNames.Add(LetterSentences.RedSea);
            RegonalsNames.Add(LetterSentences.Fayoum);
            RegonalsNames.Add(LetterSentences.ElWadyElGadid);
            RegonalsNames.Add(LetterSentences.SouthSinai);
            RegonalsNames.Add(LetterSentences.NorthSinai);
        }

        private void Direction_Load(object sender, EventArgs e) {
            cmbxMrMrs.Properties.Items.Add(LetterSentences.MR);
            cmbxMrMrs.Properties.Items.Add(LetterSentences.MRS);

            cmbxRecipient.Properties.Items.Add(LetterSentences.Head);
            cmbxRecipient.Properties.Items.Add(LetterSentences.GM_Dept);
            cmbxRecipient.Properties.Items.Add(LetterSentences.RegonalManaget);
            cmbxRecipient.Properties.Items.Add(LetterSentences.AdministrativeProsecution);

            foreach (var item in GDeptNamesList) {
                cmbxRecipientDeptName.Properties.Items.Add(item);}

            
            
            string strAddressesCon = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                     "Data Source=C:\\Users\\manno\\Documents\\administrativeProsecutionAddresses.accdb;";
            _apAddressesConnection.ConnectionString = strAddressesCon;

            try {
                _apAddressesConnection.Open();
                //MessageBox.Show("administrativeProsecutionAddresses Database connection is successful.");
            }
            catch (OleDbException oleDbEx) {
                MessageBox.Show("Access Error:" +
                                "\n\nError Code = " + oleDbEx.ErrorCode +
                                "\n\nError Message = " + oleDbEx.Message);
            }
            catch (InvalidOperationException InvOpEx) {
                MessageBox.Show("Invalid Message = " + InvOpEx.Message);
            }

            if (_apAddressesConnection.State != ConnectionState.Open) {
                MessageBox.Show("administrativeProsecutionAddresses Database connection is failed.");
            }

            var query = "SELECT * FROM tblAdministrativeProsecution";

            using (var command = new OleDbCommand(query, _apAddressesConnection)) {
                using (var reader = command.ExecuteReader()) {
                    ApNames.Clear();
                    ApAddresses.Clear();
                    while ((reader != null) && reader.Read()) {
                        ApNames.Add(reader[1].ToString());
                        ApAddresses.Add(reader[2].ToString());
                    }
                }
            }

            _apAddressesConnection?.Close();
        }

        private void UpdaetComboBox(ComboBoxEdit src, ComboBoxEdit dest) {
            //dest.Properties.Items.BeginUpdate();
            dest.Properties.Items.Clear();
            if (src.Text == LetterSentences.GM_Dept) {
                foreach (var item in GDeptNamesList) {
                    dest.Properties.Items.Add(item);
                }

                dest.SelectedIndex = 0;
            }
            else if (src.Text == LetterSentences.Head) {
                foreach (var item in CDeptNamesList) {
                    dest.Properties.Items.Add(item);
                }

                dest.SelectedIndex = 0;
            }
            else if (src.Text == LetterSentences.AdministrativeProsecution) {
                foreach (var item in ApNames) {
                    dest.Properties.Items.Add(item);
                }

                dest.SelectedIndex = 0;
            }
            else if (src.Text == LetterSentences.RegonalManaget) {
                foreach (var item in RegonalsNames) {
                    dest.Properties.Items.Add(item);
                }

                dest.SelectedIndex = 0;
            }

            //dest.Properties.Items.EndUpdate();
        }

        private void cmbxMrMrs_SelectedIndexChanged(object sender, EventArgs e) {
            MrMrsVal = cmbxMrMrs.Text;
        }

        private void cmbxRecipient_SelectedIndexChanged(object sender, EventArgs e) {
            RecipientVal = cmbxRecipient.Text;

            UpdaetComboBox(cmbxRecipient,
                cmbxRecipientDeptName);

            if (cmbxRecipient.Text == LetterSentences.AdministrativeProsecution) {
                cmbxMrMrs.Text = "";
                cmbxMrMrs.Enabled = false;
            }
            else {
                cmbxMrMrs.Enabled = true;
                cmbxMrMrs.SelectedIndex = 0;}
        }

        private void cmbxRecipientDeptName_SelectedIndexChanged(object sender, EventArgs e) {
            DeptNameVal = cmbxRecipientDeptName.Text;
        }

        private void cmbxMrMrs_TextChanged(object sender, EventArgs e)
        {
            MrMrsVal = cmbxMrMrs.Text;
        }

        private void cmbxRecipient_TextChanged(object sender, EventArgs e)
        {
            RecipientVal = cmbxRecipient.Text + " ";
        }

        private void cmbxRecipientDeptName_TextChanged(object sender, EventArgs e)
        {
            DeptNameVal = cmbxRecipientDeptName.Text;
        }
    }
}