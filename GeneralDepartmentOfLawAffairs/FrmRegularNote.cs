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
    public partial class FrmRegularNote : GeneralForm
    {
        public bool FormHasEmptyFeilds { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmRegularNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFeilds = false;
        }
    }
}
