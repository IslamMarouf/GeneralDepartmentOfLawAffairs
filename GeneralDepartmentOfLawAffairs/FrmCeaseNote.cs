﻿using System;
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
    public partial class FrmCeaseNote : GeneralForm
    {
        public bool FormHasEmptyFields { get; set; }

        public LetterData FrmLetterData { get; set; }

        public FrmCeaseNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFields = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmbxInvestigationNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}