/*
_________________________________________________________________________________________
| Author: manno soli
| File Name: SubjectsHelper.cs
| Date Created: 24/8/2019  
| Usage: 
| Copy Right: C  2019
|________________________________________________________________________________________*/

using System;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraEditors;

namespace GeneralDepartmentOfLawAffairs.Utils {
    public static class SubjectsHelper {
        static string SubjectsConStr { get; } = "SELECT * FROM tblSubjects";
        static OleDbDataAdapter SubjectsDataAdapter { get; } = new OleDbDataAdapter();
        static OleDbCommand SubjectsOdbCommand { get; } = new OleDbCommand();
        static DataSet SubjectsDs { get; } = new DataSet();

        static SubjectsHelper() {
            SubjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            SubjectsOdbCommand.CommandType = CommandType.Text;
            SubjectsOdbCommand.CommandText = SubjectsConStr;
            SubjectsDataAdapter.SelectCommand = SubjectsOdbCommand;
            SubjectsDataAdapter.Fill(SubjectsDs, "tblSubjects");
        }

        public static void UpdateProcedure(string id, string procedureName, string docPath) {
            string strUpdate = "UPDATE tblSubjects SET " +
                               $"subject_procedureName = \"{procedureName}\"," +
                               " subject_procedureDate =" +
                               $" #{DateHelper(DateTime.Today)}#," + 
                               " subject_procedureOutComNum =" +
                               $" \"{string.Empty}\"," +
                               " subject_docPath =" +
                               $" \"{docPath}\"," +
                               " subject_procedureOutComDate = Null" +
                               $"\r\nWHERE subject_id =\"{id}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateFinished(string subjectId) {
            string strUpdate = "UPDATE tblSubjects SET" +
                               " subject_finished = Yes" +
                               $"\r\nWHERE subject_id =\"{subjectId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateInWait(string subjectId, int daysOffset) {
            string strUpdate = "UPDATE tblSubjects SET" +
                               $" subject_inWaitOffset = {daysOffset}," +
                               " subject_inWait = Yes" +
                               $"\r\nWHERE subject_id =\"{subjectId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateOutComDate(string subjectId, string outComNum, DateTime outComDate) {
            string strUpdate = "UPDATE tblSubjects SET " +
                               $"subject_procedureOutComNum = \"{outComNum}\"," +
                               " subject_procedureOutComDate =" +
                               $" #{DateHelper(outComDate)}#" +
                               $"\r\nWHERE subject_id =\"{subjectId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateCaseProcedure(string id, string procedureName, string docPath) {
            string strUpdate = "UPDATE tblCases SET " +
                               $"case_lastProcedureName = \"{procedureName}\"," +
                               " case_lastProcedureDate =" +
                               $" #{DateHelper(DateTime.Today)}#," + 
                               " case_lastProcedureOutcomNum =" +
                               $" \"{string.Empty}\"," +
                               " case_docPath =" +
                               $" \"{docPath}\"," +
                               " case_lastProcedureOutcomDate = Null" +
                               $"\r\nWHERE case_id =\"{id}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateCaseFinished(string caseId) {
            string strUpdate = "UPDATE tblCases SET" +
                               " case_finished = Yes" +
                               $"\r\nWHERE case_id =\"{caseId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateCaseInWait(string caseId, int daysOffset) {
            string strUpdate = "UPDATE tblCases SET" +
                               $" case_inWaitOffset = {daysOffset}," +
                               " case_inWait = Yes" +
                               $"\r\nWHERE case_id =\"{caseId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateCaseOutComDate(string caseId, string outComNum, DateTime outComDate) {
            string strUpdate = "UPDATE tblCases SET " +
                               $"case_lastProcedureOutcomNum = \"{outComNum}\"," +
                               " case_lastProcedureOutcomDate =" +
                               $" #{DateHelper(outComDate)}#" +
                               $"\r\nWHERE case_id =\"{caseId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateLetterProcedure(string letterId, string procedureName, string docPath) {
            string strUpdate = "UPDATE tblLetters SET " +
                               $"letter_lastProcedureName = \"{procedureName}\"," +
                               " letter_lastProcedureDate =" +
                               $" #{DateHelper(DateTime.Today)}#," + 
                               " letter_lastProcedureOutcomNum =" +
                               $" \"{string.Empty}\"," +
                               " letter_docPath =" +
                               $" \"{docPath}\"," +
                               " letter_lastProcedureOutcomDate = Null" +
                               $"\r\nWHERE letter_id =\"{letterId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateLetterFinished(string letterId) {
            string strUpdate = "UPDATE tblLetters SET" +
                               " letter_finished = Yes" +
                               $"\r\nWHERE letter_id =\"{letterId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateLetterInWait(string letterId, int daysOffset) {
            string strUpdate = "UPDATE tblLetters SET" +
                               $" letter_inWaitOffset = {daysOffset}," +
                               " letter_inWait = Yes" +
                               $"\r\nWHERE letter_id =\"{letterId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateLetterOutComDate(string letterId, string outComNum, DateTime outComDate) {
            string strUpdate = "UPDATE tblLetters SET " +
                               $"letter_lastProcedureOutcomNum = \"{outComNum}\"," +
                               " letter_lastProcedureOutcomDate =" +
                               $" #{DateHelper(outComDate)}#" +
                               $"\r\nWHERE letter_id =\"{letterId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }
        
        public static void UpdateSent(string caseId) {
            string strUpdate = "UPDATE tblCases SET" +
                               " case_resolutionSent = Yes" +
                               $"\r\nWHERE case_id =\"{caseId}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        public static void UpdateNotification(string id, string procedureName, DateTime sessionDate) {
            string strUpdate = "UPDATE tblSubjects SET " +
                               $"subject_procedureName = \"{procedureName}\"," +
                               " tblSubjects.subject_procedureDate =" +
                               $" #{DateHelper(DateTime.Today)}#," +
                               " subject_sessionDate =" +
                               $" #{DateHelper(sessionDate)}#," +
                               " subject_procedureOutComNum =" +
                               $" \"{string.Empty}\"," +
                               " subject_procedureOutComDate = Null" +
                               $"\r\nWHERE subject_id =\"{id}\"";
            using (OleDbCommand command = new OleDbCommand(strUpdate, Globals.ThisAddIn.SubjectsConnection)) {
                try {
                    var intUpdate = command.ExecuteNonQuery();
                    if (intUpdate == 0) {
                        XtraMessageBox.Show("The Data updating is failed");
                    }
                }
                catch (Exception exception) {
                    XtraMessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        static string MonthName(int month) {
            switch (month)
            {
                case 01:
                    return "Jan";
                case 02:
                    return "Feb";
                case 03:
                    return "Mar";
                case 04:
                    return "Apr";
                case 05:
                    return "May";
                case 06:
                    return "Jun";
                case 07:
                    return "Jul";
                case 08:
                    return "Aug";
                case 09:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
            }

            return string.Empty;
        }

        static string DateHelper(DateTime date) {
            return $"{date.Day}-{MonthName(date.Month)}-{date.Date:yy}";
        }
    }
}