using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
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
