using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class SentPhotoCopy : DevExpress.XtraEditors.XtraUserControl
    {
        public List<Direction> Directions;

        public SentPhotoCopy()
        {
            InitializeComponent();
            Directions = new List<Direction> {direction1, direction2, direction3, direction4, direction5};
        }

        private void SentPhotoCopy_Load(object sender, EventArgs e)
        {
            
        }

        private void direction2_Load(object sender, EventArgs e)
        {

        }

        private void gcDirection_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
