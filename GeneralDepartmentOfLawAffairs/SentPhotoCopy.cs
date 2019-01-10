using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class SentPhotoCopy : UserControl
    {
        public List<Direction> Directions;

        public SentPhotoCopy() {
            InitializeComponent();
        }

        private void SentPhotoCopy_Load(object sender, EventArgs e) {
            Directions = new List<Direction> {direction1, direction2, direction3, direction4, direction5};
        }

        private void SentPhotoCopy_Validated(object sender, EventArgs e) {
            if (!direction1.MrMrsVal.Equals("")
                && !direction1.RecipientVal.Equals("")
                && !direction1.DeptNameVal.Equals("")) {
            }
            if (!direction2.MrMrsVal.Equals("")
                && !direction2.RecipientVal.Equals("")
                && !direction2.DeptNameVal.Equals("")) {
            }
            if (!direction3.MrMrsVal.Equals("")
                && !direction3.RecipientVal.Equals("")
                && !direction3.DeptNameVal.Equals("")) {
            }
            if (!direction4.MrMrsVal.Equals("")
                && !direction4.RecipientVal.Equals("")
                && !direction4.DeptNameVal.Equals("")) {
            }
            if (!direction5.MrMrsVal.Equals("")
                && !direction5.RecipientVal.Equals("")
                && !direction5.DeptNameVal.Equals("")) {
            }
        }
    }
}