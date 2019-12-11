using System;
using GeneralDepartmentOfLawAffairs.Letters;

namespace GeneralDepartmentOfLawAffairs.Temp
{
    public partial class FrmProcedure : GeneralForm
    {
        
        public LetterData LetterData;
        public FrmProcedure()
        {
            InitializeComponent();
            LetterData = new LetterData();
        }

        private void FrmProcedure_Load(object sender, EventArgs e)
        {
            dtpassignmentDate.Enabled = false;
            dtpassignmentDate.Value = LetterData.AssignmentDate;
            txt_about.Text = LetterData.Subject;
            lbl_procedureName.Text = LetterData.ProcedureName;
        }
    }
}
