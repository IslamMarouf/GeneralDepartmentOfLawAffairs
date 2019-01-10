namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmInspectionNote
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
            this.cmbxDirection = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbxInspectionNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPkrIInspectionYear = new System.Windows.Forms.DateTimePicker();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblIInspectionNum = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
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
            this.cmbxDirection.Location = new System.Drawing.Point(94, 45);
            this.cmbxDirection.Name = "cmbxDirection";
            this.cmbxDirection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxDirection.Size = new System.Drawing.Size(187, 27);
            this.cmbxDirection.TabIndex = 90;
            this.cmbxDirection.SelectedIndexChanged += new System.EventHandler(this.cmbxDirection_SelectedIndexChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(95, 139);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(526, 34);
            this.pnlButtons.TabIndex = 89;
            // 
            // pbxStatus
            // 
            this.pbxStatus.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Sample4__2_;
            this.pbxStatus.Location = new System.Drawing.Point(482, 3);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(37, 28);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 80;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMessage.Location = new System.Drawing.Point(300, 8);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(175, 19);
            this.lblMessage.TabIndex = 79;
            this.lblMessage.Text = "يجب كتابة او اختيار رقم التحقيق";
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
            // cmbxInspectionNum
            // 
            this.cmbxInspectionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxInspectionNum.FormatString = "N0";
            this.cmbxInspectionNum.FormattingEnabled = true;
            this.cmbxInspectionNum.Location = new System.Drawing.Point(94, 12);
            this.cmbxInspectionNum.Name = "cmbxInspectionNum";
            this.cmbxInspectionNum.Size = new System.Drawing.Size(73, 27);
            this.cmbxInspectionNum.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(174, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "لسنة:";
            // 
            // dtPkrIInspectionYear
            // 
            this.dtPkrIInspectionYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrIInspectionYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrIInspectionYear.CustomFormat = "yyyy";
            this.dtPkrIInspectionYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrIInspectionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrIInspectionYear.Location = new System.Drawing.Point(221, 12);
            this.dtPkrIInspectionYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrIInspectionYear.Name = "dtPkrIInspectionYear";
            this.dtPkrIInspectionYear.RightToLeftLayout = true;
            this.dtPkrIInspectionYear.ShowUpDown = true;
            this.dtPkrIInspectionYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrIInspectionYear.TabIndex = 86;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(14, 48);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(82, 19);
            this.lblDirection.TabIndex = 85;
            this.lblDirection.Text = "للعرض على :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(95, 79);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(527, 53);
            this.txtSubject.TabIndex = 84;
            this.txtSubject.Text = "بشأن ...";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(15, 79);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 83;
            this.lblSubject.Text = "الموضوع :";
            // 
            // lblIInspectionNum
            // 
            this.lblIInspectionNum.AutoSize = true;
            this.lblIInspectionNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblIInspectionNum.Location = new System.Drawing.Point(13, 18);
            this.lblIInspectionNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIInspectionNum.Name = "lblIInspectionNum";
            this.lblIInspectionNum.Size = new System.Drawing.Size(82, 19);
            this.lblIInspectionNum.TabIndex = 82;
            this.lblIInspectionNum.Text = "رقم الفحص : ";
            // 
            // FrmInspectionNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 184);
            this.Controls.Add(this.cmbxDirection);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.cmbxInspectionNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrIInspectionYear);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblIInspectionNum);
            this.Name = "FrmInspectionNote";
            this.Text = "مذكرة فحص";
            this.Load += new System.EventHandler(this.FrmInspectionNote_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbxDirection;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbxInspectionNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPkrIInspectionYear;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblIInspectionNum;
    }
}