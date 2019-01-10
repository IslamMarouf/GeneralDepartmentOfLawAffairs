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
    public partial class FrmDraftResolution : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmDraftResolution()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }
    }
}
