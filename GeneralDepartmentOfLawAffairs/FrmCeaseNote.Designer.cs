namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmCeaseNote
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
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtGuilty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPkrInvestigationYear = new System.Windows.Forms.DateTimePicker();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbxInvestigationNum = new System.Windows.Forms.ComboBox();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(17, 194);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(601, 34);
            this.pnlButtons.TabIndex = 74;
            // 
            // pbxStatus
            // 
            this.pbxStatus.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Sample4__2_;
            this.pbxStatus.Location = new System.Drawing.Point(559, 3);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(37, 28);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 76;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMessage.Location = new System.Drawing.Point(281, 8);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(275, 19);
            this.lblMessage.TabIndex = 75;
            this.lblMessage.Text = "يجب ملء الحقول الخالية والتأكد من صحة التواريخ ";
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
            // txtGuilty
            // 
            this.txtGuilty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtGuilty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuilty.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGuilty.Location = new System.Drawing.Point(204, 121);
            this.txtGuilty.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuilty.Name = "txtGuilty";
            this.txtGuilty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuilty.Size = new System.Drawing.Size(217, 26);
            this.txtGuilty.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(13, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "الدرجة المالية للمشكو في حقه  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(163, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "لسنة:";
            // 
            // dtPkrInvestigationYear
            // 
            this.dtPkrInvestigationYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInvestigationYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInvestigationYear.CustomFormat = "yyyy";
            this.dtPkrInvestigationYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInvestigationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInvestigationYear.Location = new System.Drawing.Point(210, 12);
            this.dtPkrInvestigationYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInvestigationYear.Name = "dtPkrInvestigationYear";
            this.dtPkrInvestigationYear.RightToLeftLayout = true;
            this.dtPkrInvestigationYear.ShowUpDown = true;
            this.dtPkrInvestigationYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInvestigationYear.TabIndex = 83;
            // 
            // lblInvestigationNum
            // 
            this.lblInvestigationNum.AutoSize = true;
            this.lblInvestigationNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvestigationNum.Location = new System.Drawing.Point(13, 15);
            this.lblInvestigationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvestigationNum.Name = "lblInvestigationNum";
            this.lblInvestigationNum.Size = new System.Drawing.Size(83, 19);
            this.lblInvestigationNum.TabIndex = 82;
            this.lblInvestigationNum.Text = "رقم التحقيق : ";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(103, 45);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(511, 68);
            this.txtSubject.TabIndex = 86;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(13, 48);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 87;
            this.lblSubject.Text = "الموضوع :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox1.Location = new System.Drawing.Point(17, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 23);
            this.checkBox1.TabIndex = 88;
            this.checkBox1.Text = "مشروع قرار";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.cmbxInvestigationNum.TabIndex = 89;
            this.cmbxInvestigationNum.SelectedIndexChanged += new System.EventHandler(this.cmbxInvestigationNum_SelectedIndexChanged);
            // 
            // FrmCeaseNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 241);
            this.Controls.Add(this.cmbxInvestigationNum);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrInvestigationYear);
            this.Controls.Add(this.lblInvestigationNum);
            this.Controls.Add(this.txtGuilty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlButtons);
            this.Name = "FrmCeaseNote";
            this.Text = "مذكرة إنقطاع";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGuilty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPkrInvestigationYear;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbxInvestigationNum;
    }
}