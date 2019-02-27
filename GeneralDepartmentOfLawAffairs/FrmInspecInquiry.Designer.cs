namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmInspecInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInspecInquiry));
            this.cmbxInspectionNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.dtpAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_about = new System.Windows.Forms.TextBox();
            this.txtAttachmentsCount = new System.Windows.Forms.MaskedTextBox();
            this.lblCompanionsCount = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlDirection = new GeneralDepartmentOfLawAffairs.Direction();
            this.lblDirection = new System.Windows.Forms.Label();
            this.ctrlSentPhotoCopy = new GeneralDepartmentOfLawAffairs.SentPhotoCopy();
            this.chkbxSentPhotoCopy = new System.Windows.Forms.CheckBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxInspectionNum
            // 
            this.cmbxInspectionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxInspectionNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxInspectionNum.FormatString = "N0";
            this.cmbxInspectionNum.FormattingEnabled = true;
            this.cmbxInspectionNum.Location = new System.Drawing.Point(103, 12);
            this.cmbxInspectionNum.Name = "cmbxInspectionNum";
            this.cmbxInspectionNum.Size = new System.Drawing.Size(53, 27);
            this.cmbxInspectionNum.TabIndex = 98;
            this.cmbxInspectionNum.SelectedIndexChanged += new System.EventHandler(this.cmbxInspectionNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(163, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 101;
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
            this.lblInvestigationNum.Size = new System.Drawing.Size(82, 19);
            this.lblInvestigationNum.TabIndex = 99;
            this.lblInvestigationNum.Text = "رقم الفحص : ";
            // 
            // dtpAssignmentDate
            // 
            this.dtpAssignmentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpAssignmentDate.Enabled = false;
            this.dtpAssignmentDate.Location = new System.Drawing.Point(363, 12);
            this.dtpAssignmentDate.Name = "dtpAssignmentDate";
            this.dtpAssignmentDate.RightToLeftLayout = true;
            this.dtpAssignmentDate.Size = new System.Drawing.Size(133, 26);
            this.dtpAssignmentDate.TabIndex = 97;
            this.dtpAssignmentDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "ابشأن:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 94;
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
            this.txt_about.Size = new System.Drawing.Size(526, 57);
            this.txt_about.TabIndex = 93;
            // 
            // txtAttachmentsCount
            // 
            this.txtAttachmentsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAttachmentsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAttachmentsCount.HidePromptOnLeave = true;
            this.txtAttachmentsCount.Location = new System.Drawing.Point(597, 12);
            this.txtAttachmentsCount.Mask = "000";
            this.txtAttachmentsCount.Name = "txtAttachmentsCount";
            this.txtAttachmentsCount.Size = new System.Drawing.Size(33, 26);
            this.txtAttachmentsCount.TabIndex = 105;
            this.txtAttachmentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompanionsCount
            // 
            this.lblCompanionsCount.AutoSize = true;
            this.lblCompanionsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanionsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCompanionsCount.Location = new System.Drawing.Point(503, 18);
            this.lblCompanionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanionsCount.Name = "lblCompanionsCount";
            this.lblCompanionsCount.Size = new System.Drawing.Size(83, 19);
            this.lblCompanionsCount.TabIndex = 104;
            this.lblCompanionsCount.Text = "عدد المرفقات:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(93, 400);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(527, 34);
            this.pnlButtons.TabIndex = 106;
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
            // ctrlDirection
            // 
            this.ctrlDirection.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApAddresses")));
            this.ctrlDirection.ApAddressVal = "";
            this.ctrlDirection.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApNames")));
            this.ctrlDirection.DeptNameVal = "";
            this.ctrlDirection.Filled = false;
            this.ctrlDirection.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDirection.Location = new System.Drawing.Point(103, 112);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.Size = new System.Drawing.Size(527, 33);
            this.ctrlDirection.TabIndex = 108;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(23, 112);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(56, 19);
            this.lblDirection.TabIndex = 107;
            this.lblDirection.Text = "التوجيه :";
            // 
            // ctrlSentPhotoCopy
            // 
            this.ctrlSentPhotoCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlSentPhotoCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlSentPhotoCopy.BackgroundImage")));
            this.ctrlSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSentPhotoCopy.Location = new System.Drawing.Point(93, 183);
            this.ctrlSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSentPhotoCopy.Name = "ctrlSentPhotoCopy";
            this.ctrlSentPhotoCopy.Size = new System.Drawing.Size(527, 210);
            this.ctrlSentPhotoCopy.TabIndex = 110;
            // 
            // chkbxSentPhotoCopy
            // 
            this.chkbxSentPhotoCopy.AutoSize = true;
            this.chkbxSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSentPhotoCopy.ForeColor = System.Drawing.SystemColors.Info;
            this.chkbxSentPhotoCopy.Location = new System.Drawing.Point(17, 152);
            this.chkbxSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxSentPhotoCopy.Name = "chkbxSentPhotoCopy";
            this.chkbxSentPhotoCopy.Size = new System.Drawing.Size(103, 23);
            this.chkbxSentPhotoCopy.TabIndex = 109;
            this.chkbxSentPhotoCopy.Text = "صورة مرسلة:";
            this.chkbxSentPhotoCopy.UseVisualStyleBackColor = true;
            this.chkbxSentPhotoCopy.CheckedChanged += new System.EventHandler(this.chkbxSentPhotoCopy_CheckedChanged);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtYear.ForeColor = System.Drawing.SystemColors.Info;
            this.txtYear.Location = new System.Drawing.Point(209, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(64, 26);
            this.txtYear.TabIndex = 111;
            // 
            // FrmInspecInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.ctrlSentPhotoCopy);
            this.Controls.Add(this.chkbxSentPhotoCopy);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtAttachmentsCount);
            this.Controls.Add(this.lblCompanionsCount);
            this.Controls.Add(this.cmbxInspectionNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInvestigationNum);
            this.Controls.Add(this.dtpAssignmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_about);
            this.Name = "FrmInspecInquiry";
            this.Text = "إستيفاء";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInspecInquiry_FormClosing);
            this.Load += new System.EventHandler(this.FrmInspecInquiry_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxInspectionNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_about;
        private System.Windows.Forms.MaskedTextBox txtAttachmentsCount;
        private System.Windows.Forms.Label lblCompanionsCount;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Direction ctrlDirection;
        private System.Windows.Forms.Label lblDirection;
        private SentPhotoCopy ctrlSentPhotoCopy;
        private System.Windows.Forms.CheckBox chkbxSentPhotoCopy;
        private System.Windows.Forms.TextBox txtYear;
    }
}