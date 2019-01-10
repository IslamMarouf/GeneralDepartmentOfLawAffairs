using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class ThisAddIn
    {
        public readonly OleDbConnection ApAddressesConnection = new OleDbConnection();
        public readonly OleDbConnection InspectionSubjectConnection = new OleDbConnection();

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            const string strAddressesCon = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                           "Data Source=C:\\Users\\Soli\\Documents\\administrativeProsecutionAddresses.accdb;";

            const string strInsSubjectCon = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                            "Data Source=C:\\Users\\Soli\\Documents\\InspectionSubjects.accdb;";

            ApAddressesConnection.ConnectionString = strAddressesCon;
            InspectionSubjectConnection.ConnectionString = strInsSubjectCon;

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
                InspectionSubjectConnection.Open();
                //MessageBox.Show("InspectionSubjects Database connection is successful.");
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

            if (InspectionSubjectConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("InspectionSubjects Database connection is failed.");
            }

            if (File.Exists(@"C:\Windows\Temp\eagle.png")) return;
            object obj = Properties.Resources.eagle;
            var image = (Bitmap)obj;
            image.Save(@"C:\Windows\Temp\eagle.png");

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            ApAddressesConnection?.Close();
            ApAddressesConnection?.Dispose();

            InspectionSubjectConnection?.Close();
            InspectionSubjectConnection?.Dispose();
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
