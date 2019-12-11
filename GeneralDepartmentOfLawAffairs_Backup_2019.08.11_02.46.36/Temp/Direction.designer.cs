namespace GeneralDepartmentOfLawAffairs.Temp
{
    partial class Direction
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxMrMrs = new System.Windows.Forms.ComboBox();
            this.cmbxRecipient = new System.Windows.Forms.ComboBox();
            this.cmbxRecipientDeptName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbxMrMrs
            // 
            this.cmbxMrMrs.BackColor = System.Drawing.Color.DarkGreen;
            this.cmbxMrMrs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMrMrs.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxMrMrs.FormattingEnabled = true;
            this.cmbxMrMrs.Location = new System.Drawing.Point(409, 2);
            this.cmbxMrMrs.Name = "cmbxMrMrs";
            this.cmbxMrMrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxMrMrs.Size = new System.Drawing.Size(117, 27);
            this.cmbxMrMrs.TabIndex = 3;
            this.cmbxMrMrs.SelectedIndexChanged += new System.EventHandler(this.cmbxMrMrs_SelectedIndexChanged);
            this.cmbxMrMrs.TextUpdate += new System.EventHandler(this.cmbxMrMrs_TextUpdate);
            // 
            // cmbxRecipient
            // 
            this.cmbxRecipient.BackColor = System.Drawing.Color.DarkGreen;
            this.cmbxRecipient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRecipient.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxRecipient.FormattingEnabled = true;
            this.cmbxRecipient.Location = new System.Drawing.Point(299, 2);
            this.cmbxRecipient.Name = "cmbxRecipient";
            this.cmbxRecipient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxRecipient.Size = new System.Drawing.Size(104, 27);
            this.cmbxRecipient.TabIndex = 4;
            this.cmbxRecipient.SelectedIndexChanged += new System.EventHandler(this.cmbxRecipient_SelectedIndexChanged);
            this.cmbxRecipient.TextUpdate += new System.EventHandler(this.cmbxRecipient_TextUpdate);
            // 
            // cmbxRecipientDeptName
            // 
            this.cmbxRecipientDeptName.BackColor = System.Drawing.Color.DarkGreen;
            this.cmbxRecipientDeptName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRecipientDeptName.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxRecipientDeptName.FormattingEnabled = true;
            this.cmbxRecipientDeptName.Location = new System.Drawing.Point(2, 2);
            this.cmbxRecipientDeptName.Name = "cmbxRecipientDeptName";
            this.cmbxRecipientDeptName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxRecipientDeptName.Size = new System.Drawing.Size(292, 27);
            this.cmbxRecipientDeptName.TabIndex = 5;
            this.cmbxRecipientDeptName.SelectedIndexChanged += new System.EventHandler(this.cmbxRecipientDeptName_SelectedIndexChanged);
            this.cmbxRecipientDeptName.TextUpdate += new System.EventHandler(this.cmbxRecipientDeptName_TextUpdate);
            // 
            // Direction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbxMrMrs);
            this.Controls.Add(this.cmbxRecipient);
            this.Controls.Add(this.cmbxRecipientDeptName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Direction";
            this.Size = new System.Drawing.Size(529, 27);
            this.Load += new System.EventHandler(this.Direction_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbxMrMrs;
        public System.Windows.Forms.ComboBox cmbxRecipient;
        public System.Windows.Forms.ComboBox cmbxRecipientDeptName;
    }
}
