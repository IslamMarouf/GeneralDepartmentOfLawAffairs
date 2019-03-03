namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmTableNote
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.cmbxDirection = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbxInvestigationNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.dtpAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_about = new System.Windows.Forms.TextBox();
            this.txtAttachmentsCount = new System.Windows.Forms.MaskedTextBox();
            this.lblCompanionsCount = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(104, 161);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(407, 34);
            this.pnlButtons.TabIndex = 80;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(4, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(124, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "موافق";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(12, 117);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(82, 19);
            this.lblDirection.TabIndex = 75;
            this.lblDirection.Text = "للعرض على :";
            // 
            // cmbxDirection
            // 
            this.cmbxDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxDirection.FormattingEnabled = true;
            this.cmbxDirection.Items.AddRange(new object[] {
            "معالي الوزيرة",
            "رئيس القطاع"});
            this.cmbxDirection.Location = new System.Drawing.Point(104, 114);
            this.cmbxDirection.Name = "cmbxDirection";
            this.cmbxDirection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxDirection.Size = new System.Drawing.Size(273, 27);
            this.cmbxDirection.TabIndex = 81;
            this.cmbxDirection.SelectedIndexChanged += new System.EventHandler(this.cmbxDirection_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtYear.ForeColor = System.Drawing.SystemColors.Info;
            this.txtYear.Location = new System.Drawing.Point(216, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(64, 26);
            this.txtYear.TabIndex = 99;
            // 
            // cmbxInvestigationNum
            // 
            this.cmbxInvestigationNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxInvestigationNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxInvestigationNum.FormatString = "N0";
            this.cmbxInvestigationNum.FormattingEnabled = true;
            this.cmbxInvestigationNum.Location = new System.Drawing.Point(103, 12);
            this.cmbxInvestigationNum.Name = "cmbxInvestigationNum";
            this.cmbxInvestigationNum.Size = new System.Drawing.Size(53, 27);
            this.cmbxInvestigationNum.TabIndex = 96;
            this.cmbxInvestigationNum.SelectedIndexChanged += new System.EventHandler(this.cmbxInvestigationNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(170, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "لسنة:";
            // 
            // lblInvestigationNum
            // 
            this.lblInvestigationNum.AutoSize = true;
            this.lblInvestigationNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvestigationNum.Location = new System.Drawing.Point(13, 18);
            this.lblInvestigationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvestigationNum.Name = "lblInvestigationNum";
            this.lblInvestigationNum.Size = new System.Drawing.Size(83, 19);
            this.lblInvestigationNum.TabIndex = 97;
            this.lblInvestigationNum.Text = "رقم التحقيق : ";
            // 
            // dtpAssignmentDate
            // 
            this.dtpAssignmentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpAssignmentDate.Enabled = false;
            this.dtpAssignmentDate.Location = new System.Drawing.Point(373, 12);
            this.dtpAssignmentDate.Name = "dtpAssignmentDate";
            this.dtpAssignmentDate.RightToLeftLayout = true;
            this.dtpAssignmentDate.Size = new System.Drawing.Size(138, 26);
            this.dtpAssignmentDate.TabIndex = 95;
            this.dtpAssignmentDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "ابشأن:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(286, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "تاريخ الإحالة:";
            // 
            // txt_about
            // 
            this.txt_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txt_about.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_about.Location = new System.Drawing.Point(104, 48);
            this.txt_about.Multiline = true;
            this.txt_about.Name = "txt_about";
            this.txt_about.ReadOnly = true;
            this.txt_about.Size = new System.Drawing.Size(407, 57);
            this.txt_about.TabIndex = 92;
            // 
            // txtAttachmentsCount
            // 
            this.txtAttachmentsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAttachmentsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAttachmentsCount.HidePromptOnLeave = true;
            this.txtAttachmentsCount.Location = new System.Drawing.Point(478, 114);
            this.txtAttachmentsCount.Mask = "000";
            this.txtAttachmentsCount.Name = "txtAttachmentsCount";
            this.txtAttachmentsCount.Size = new System.Drawing.Size(33, 26);
            this.txtAttachmentsCount.TabIndex = 107;
            this.txtAttachmentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompanionsCount
            // 
            this.lblCompanionsCount.AutoSize = true;
            this.lblCompanionsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanionsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCompanionsCount.Location = new System.Drawing.Point(384, 120);
            this.lblCompanionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanionsCount.Name = "lblCompanionsCount";
            this.lblCompanionsCount.Size = new System.Drawing.Size(83, 19);
            this.lblCompanionsCount.TabIndex = 106;
            this.lblCompanionsCount.Text = "عدد المرفقات:";
            // 
            // FrmTableNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 207);
            this.Controls.Add(this.txtAttachmentsCount);
            this.Controls.Add(this.lblCompanionsCount);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbxInvestigationNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInvestigationNum);
            this.Controls.Add(this.dtpAssignmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_about);
            this.Controls.Add(this.cmbxDirection);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblDirection);
            this.Name = "FrmTableNote";
            this.Text = "مذكرة (جدول) ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTableNote_FormClosing);
            this.Load += new System.EventHandler(this.FrmTableNote_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDirection;
        public System.Windows.Forms.ComboBox cmbxDirection;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbxInvestigationNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_about;
        private System.Windows.Forms.MaskedTextBox txtAttachmentsCount;
        private System.Windows.Forms.Label lblCompanionsCount;
    }
}