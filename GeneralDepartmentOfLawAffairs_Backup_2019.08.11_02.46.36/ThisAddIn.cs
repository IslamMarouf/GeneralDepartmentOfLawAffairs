using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class ThisAddIn
    {
        public readonly OleDbConnection ApAddressesConnection = new OleDbConnection();
        public readonly OleDbConnection DepartmentsConnection = new OleDbConnection();
        public readonly OleDbConnection SubjectsConnection = new OleDbConnection();

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // Enable DevExpress skins.
            SkinManager.EnableFormSkins();
            BonusSkins.Register();

            const string strAddressesCon = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                           "Data Source=C:\\Users\\manno\\Documents\\administrativeProsecutionAddresses.accdb;";

            const string strDepartmentsCon = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                             "Data Source=C:\\Users\\manno\\Documents\\Departments.accdb;" +
                                             "Jet OLEDB:Database Password=0163575879";


            /*

               This is an encrypted access 2016 database to work properly open access 
               2016 and do the follow.
               
            Under File - Options - Client Settings (scroll to the bottom)...
               
            Default Open Mode = Shared
               
            Default record locking = No Locks
               
            Encryption Method = Use legacy
               
            Unencrypt and re-encrypt the database

             */
            const string strSubjectsCon =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Users\\manno\\Documents\\Subjects.accdb;" +
                "Jet OLEDB:Database Password=0163575879";

            ApAddressesConnection.ConnectionString = strAddressesCon;
            DepartmentsConnection.ConnectionString = strDepartmentsCon;
            SubjectsConnection.ConnectionString = strSubjectsCon;

            try
            {
                ApAddressesConnection.Open();
                //MessageBox.Show("administrativeProsecutionAddresses Database connection is successful.");
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show("Access Error:" +
                                "\n\nError Code = " + oleDbEx.ErrorCode +
                                "\n\nError Message = " + oleDbEx.Message);
            }
            catch (InvalidOperationException invOpEx)
            {
                MessageBox.Show("Invalid Message = " + invOpEx.Message);
            }

            if (ApAddressesConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("administrativeProsecutionAddresses Database connection is failed.");
            }

            try
            {
                DepartmentsConnection.Open();
                //MessageBox.Show("Departments Database connection is successful.");
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show("Access Error:" +
                                "\n\nError Code = " + oleDbEx.ErrorCode +
                                "\n\nError Message = " + oleDbEx.Message);
            }
            catch (InvalidOperationException invOpEx)
            {
                MessageBox.Show("Invalid Message = " + invOpEx.Message);
            }

            if (DepartmentsConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Departments Database connection is failed.");
            }

            try
            {
                SubjectsConnection.Open();
                //MessageBox.Show("Subjects Database connection is successful.");
            }
            catch (OleDbException oleDbEx)
            {
                MessageBox.Show("Access Error:" +
                                "\n\nError Code = " + oleDbEx.ErrorCode +
                                "\n\nError Message = " + oleDbEx.Message);
            }
            catch (InvalidOperationException invOpEx)
            {
                MessageBox.Show("Invalid Message = " + invOpEx.Message);
            }

            if (SubjectsConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Subjects Database connection is failed.");
            }

            if (File.Exists(@"C:\Windows\Temp\eagle.png")) return;
            object obj = Properties.Resources.eagle;
            var image = (Bitmap)obj;
            image.Save(@"C:\Windows\Temp\eagle.png");

            if (File.Exists(@"eagle.png"))
            {
                MessageBox.Show("file was found!");
            }

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            ApAddressesConnection?.Close();
            ApAddressesConnection?.Dispose();

            DepartmentsConnection?.Close();
            DepartmentsConnection?.Dispose();

            SubjectsConnection?.Close();
            SubjectsConnection?.Dispose();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
