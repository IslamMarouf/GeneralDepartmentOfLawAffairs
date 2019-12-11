using System;
using System.Collections.Generic;
using GeneralDepartmentOfLawAffairs.Utils;

namespace GeneralDepartmentOfLawAffairs.Letters
{
    public class LetterData
    {
        public LetterData() {
            EmptyFields = new List<string>();
            MrMrsValList = new List<string>();
            RecipientValList = new List<string>();
            DeptNameValList = new List<string>();
            ApAddressValList = new List<string>();
            WantedNamesList = new List<string>();
//            RegonalsNames = new List<string>();
            SentPhotoCopyCount = 0;

            SubjectId = string.Empty;
            CaseId = string.Empty;

//            CDeptNamesList = new List<string>(); //            GDeptNamesList = new List<string>();
//            ApNames = new List<string>();
//            ApAddresses = new List<string>();
//            RegonalsNames = new List<string>();
//
//            CDeptNamesList.Add(LetterSentences.CentralDepartName);
//            CDeptNamesList.Add(LetterSentences.CDept1);
//            CDeptNamesList.Add(LetterSentences.CDept2);
//            CDeptNamesList.Add(LetterSentences.CDept3);
//            CDeptNamesList.Add(LetterSentences.CDept4);
//            CDeptNamesList.Add(LetterSentences.CDept5);
//            CDeptNamesList.Add(LetterSentences.CDept6);
//            CDeptNamesList.Add(LetterSentences.CDept7);
//
//            GDeptNamesList.Add(LetterSentences.GeneralDepartName);
//            GDeptNamesList.Add(LetterSentences.GDept1);
//            GDeptNamesList.Add(LetterSentences.GDept10);
//            GDeptNamesList.Add(LetterSentences.GDept11);
//            GDeptNamesList.Add(LetterSentences.GDept12);
//            GDeptNamesList.Add(LetterSentences.GDept13);
//            GDeptNamesList.Add(LetterSentences.GDept14);
//            GDeptNamesList.Add(LetterSentences.GDept15);
//            GDeptNamesList.Add(LetterSentences.GDept16);
//            GDeptNamesList.Add(LetterSentences.GDept17);
//            GDeptNamesList.Add(LetterSentences.GDept18);
//            GDeptNamesList.Add(LetterSentences.GDept19);
//            GDeptNamesList.Add(LetterSentences.GDept2);
//            GDeptNamesList.Add(LetterSentences.GDept20);
//            GDeptNamesList.Add(LetterSentences.GDept21);
//            GDeptNamesList.Add(LetterSentences.GDept22);
//            GDeptNamesList.Add(LetterSentences.GDept23);
//            GDeptNamesList.Add(LetterSentences.GDept24);
//            GDeptNamesList.Add(LetterSentences.GDept25);
//            GDeptNamesList.Add(LetterSentences.GDept26);
//            GDeptNamesList.Add(LetterSentences.GDept27);
//            GDeptNamesList.Add(LetterSentences.GDept28);
//            GDeptNamesList.Add(LetterSentences.GDept29);
//            GDeptNamesList.Add(LetterSentences.GDept3);
//            GDeptNamesList.Add(LetterSentences.GDept30);
//            GDeptNamesList.Add(LetterSentences.GDept31);
//            GDeptNamesList.Add(LetterSentences.GDept32);
//            GDeptNamesList.Add(LetterSentences.GDept33);
//            GDeptNamesList.Add(LetterSentences.GDept4);
//            GDeptNamesList.Add(LetterSentences.GDept5);
//            GDeptNamesList.Add(LetterSentences.GDept6);
//            GDeptNamesList.Add(LetterSentences.GDept7);
//            GDeptNamesList.Add(LetterSentences.GDept8);
//            GDeptNamesList.Add(LetterSentences.GDept9);
//
//            RegonalsNames.Add(LetterSentences.Giza);
//            RegonalsNames.Add(LetterSentences.BanySwaif);
//            RegonalsNames.Add(LetterSentences.Menya);
//            RegonalsNames.Add(LetterSentences.Asiut);
//            RegonalsNames.Add(LetterSentences.Sohag);
//            RegonalsNames.Add(LetterSentences.Quena);
//            RegonalsNames.Add(LetterSentences.Luxor);
//            RegonalsNames.Add(LetterSentences.Aswan);
//            RegonalsNames.Add(LetterSentences.Cairo);
//            RegonalsNames.Add(LetterSentences.Alexandria);
//            RegonalsNames.Add(LetterSentences.Behera);
//            RegonalsNames.Add(LetterSentences.Qalyobeya);
//            RegonalsNames.Add(LetterSentences.Monofeya);
//            RegonalsNames.Add(LetterSentences.Daqahleya);
//            RegonalsNames.Add(LetterSentences.Sharqeya);
//            RegonalsNames.Add(LetterSentences.Gharbeya);
//            RegonalsNames.Add(LetterSentences.KafrElSheikh);
//            RegonalsNames.Add(LetterSentences.PortSaid);
//            RegonalsNames.Add(LetterSentences.Swez);
//            RegonalsNames.Add(LetterSentences.Ismaeileya);
//            RegonalsNames.Add(LetterSentences.MarsaMatrouh);
//            RegonalsNames.Add(LetterSentences.RedSea);
//            RegonalsNames.Add(LetterSentences.Fayoum);
//            RegonalsNames.Add(LetterSentences.ElWadyElGadid);
//            RegonalsNames.Add(LetterSentences.SouthSinai);
//            RegonalsNames.Add(LetterSentences.NorthSinai);

//            try
//            {
//                string sConnection = "Provider=Microsoft.ACE.OLEDB.16.0;" + "Data Source=administrativeProsecutionAddresses.accdb";
//                OleDbConnection dbConn = new OleDbConnection(sConnection);
//                dbConn.Open();
//
//                string oldbStr = "SELECT * FROM tblAdministrativeProsecution";
//
//                OleDbCommand oleDbCommand = new OleDbCommand();
//                oleDbCommand.CommandText = oldbStr;
//                oleDbCommand.Connection = dbConn;
//
//                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
//
//                while (oleDbDataReader != null && oleDbDataReader.Read())
//                {
//                    ApNames.Add(oleDbDataReader[1].ToString());
//                    ApAddresses.Add(oleDbDataReader[2].ToString());
//                }
//
//                oleDbDataReader?.Close();
//                dbConn.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message, ex.Source);
//            }
        } // 

        // ministry name. rscript 
        public bool HasSentPhotoCopy { get; set; }
        public bool HasDraftResolution { get; set; }
        public string AttachmentsCount { get; set; }
        public string LetterId { get; set; }
        public string OurNumber { get; set; }
        public string OurDate { get; set; }
        public string LetterNumber { get; set; }
        public string LetterDate { get; set; }
        public string IncomingLetterNumber { get; set; }
        public string IncomingLetterDate { get; set; }
        public string CaseId {get; set; }
        public string CaseNumber { get; set; }
        public string CaseYear { get; set; }
        public string CaseDecisionDate { get; set; }
        public string DecisionNumber { get; set; }
        public string RescriptNum { get; set; }
        public string RescriptDate { get; set; }
        public string InvestDate { get; set; }
        public string InspectionDate { get; set; }
        public string Guilty { get; set; }
        public string Name { get; set; }
        public string CDptName { get; set; }
        public string HeadName { get; set; }
        public string DepartmentName { get; set; }
        public string CeaseDays { get; set; }
        public string ApLetterNum { get; set; }
        public string ApLetterDate { get; set; }
        public string InvestigationId { get; set; }
        public string InvestigationNumber { get; set; }
        public string InspectionNumber { get; set; }
        public string Subject { get; set; }
        public string SubjectType { get; set; }
        public string Receiver { get; set; }
        public string ReceiverDeptName { get; set; }
        public string SentPhotoCopyReceiver { get; set; }
        public string SentPhotoCopyReceiverDptName { get; set; }
        public string MrMsVal { get; set; }
        public string RecMrMsVal { get; set; }
        public DateTime InvestigationDate { get; set; }
        public DateTime InvestigationIncomDate { get; set; }
        public DateTime LastNotificationOutcomDate { get; set; }
        public string LastNotificationOutcomNumber { get; set; }
        public string WantedDocuments { get; set; }
        public string ApVal { get; set; }
        public int Index { get; set; }
        public int ArticlesNum { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? ProcedureDate { get; set; }
        public DateTime ProcedureOutComDate { get; set; }
        public DateTime? DtLetterDate { get; set; }
        public string ProcedureName { get; set; }
        public string InvYear { get; set; }
        public string InspectYear { get; set; }
        public string CeaseMonths { get; set; }
        public string GuiltyRank { get; set; }
        public string GuiltyJob { get; set; }
        public string SubjectId { get; set; }
        public string InvType { get; set; }
        public QueryFormType FormType { get; set; }

        // regional 
        public List<string> EmptyFields { get; }
        public List<string> CDeptNamesList { get; }
        public List<string> GDeptNamesList { get; }
        public List<string> RegonalsNames { get; set; }

        public List<string> ApNames { get; set; }
        public List<string> SentPhotoCopyApNames { get; set; }
        public List<string> ApAddresses { get; set; }
        public List<string> SentPhotoCopyApAddresses { get; set; }
        public List<string> ApAddressValList { get; set; }

        public List<string> MrMrsValList { get; set; }
        public List<string> RecipientValList { get; set; }
        public List<string> DeptNameValList { get; set; }
        public List<string> WantedNamesList { get; set; }
        public int SentPhotoCopyCount { get; set; }
        public string SubjectNum { get; set; }
        public string SubjectYear { get; set; }
        public string CaseResNum { get; set; }
        public DateTime? CaseResDate { get; set; }
        public int CaseResYear { get; set; }
    }
}