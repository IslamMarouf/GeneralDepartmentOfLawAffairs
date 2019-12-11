namespace GeneralDepartmentOfLawAffairs.Temp
{
    partial class FrmRescriptSentLetter : GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRescriptSentLetter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtCaseDecisionYear = new System.Windows.Forms.DateTimePicker();
            this.rdbtnYear = new System.Windows.Forms.RadioButton();
            this.rdbtnDate = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaseDecisionNumber = new System.Windows.Forms.MaskedTextBox();
            this.dtCaseDecision = new System.Windows.Forms.DateTimePicker();
            this.dtCase = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpAPLetter = new System.Windows.Forms.DateTimePicker();
            this.txtAPLetterNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDirection = new Direction();
            this.lblDirection = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deRescriptDate = new System.Windows.Forms.DateTimePicker();
            this.txtRescriptNum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuilty = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtCaseDecisionYear);
            this.panel1.Controls.Add(this.rdbtnYear);
            this.panel1.Controls.Add(this.rdbtnDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCaseDecisionNumber);
            this.panel1.Controls.Add(this.dtCaseDecision);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 44);
            this.panel1.TabIndex = 71;
            // 
            // dtCaseDecisionYear
            // 
            this.dtCaseDecisionYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCaseDecisionYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtCaseDecisionYear.CustomFormat = "yyyy";
            this.dtCaseDecisionYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtCaseDecisionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCaseDecisionYear.Location = new System.Drawing.Point(4, 7);
            this.dtCaseDecisionYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtCaseDecisionYear.Name = "dtCaseDecisionYear";
            this.dtCaseDecisionYear.RightToLeftLayout = true;
            this.dtCaseDecisionYear.ShowUpDown = true;
            this.dtCaseDecisionYear.Size = new System.Drawing.Size(60, 26);
            this.dtCaseDecisionYear.TabIndex = 55;
            // 
            // rdbtnYear
            // 
            this.rdbtnYear.AutoSize = true;
            this.rdbtnYear.ForeColor = System.Drawing.SystemColors.Info;
            this.rdbtnYear.Location = new System.Drawing.Point(71, 10);
            this.rdbtnYear.Name = "rdbtnYear";
            this.rdbtnYear.Size = new System.Drawing.Size(61, 23);
            this.rdbtnYear.TabIndex = 51;
            this.rdbtnYear.TabStop = true;
            this.rdbtnYear.Text = "لسنة :";
            this.rdbtnYear.UseVisualStyleBackColor = true;
            this.rdbtnYear.CheckedChanged += new System.EventHandler(this.DateType_CheckedChanged);
            // 
            // rdbtnDate
            // 
            this.rdbtnDate.AutoSize = true;
            this.rdbtnDate.ForeColor = System.Drawing.SystemColors.Info;
            this.rdbtnDate.Location = new System.Drawing.Point(278, 10);
            this.rdbtnDate.Name = "rdbtnDate";
            this.rdbtnDate.Size = new System.Drawing.Size(68, 23);
            this.rdbtnDate.TabIndex = 50;
            this.rdbtnDate.TabStop = true;
            this.rdbtnDate.Text = "بتاريخ :";
            this.rdbtnDate.UseVisualStyleBackColor = true;
            this.rdbtnDate.CheckedChanged += new System.EventHandler(this.DateType_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(400, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "والمرفق به قرار لجنة التأديب رقم  : ";
            // 
            // txtCaseDecisionNumber
            // 
            this.txtCaseDecisionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtCaseDecisionNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCaseDecisionNumber.HidePromptOnLeave = true;
            this.txtCaseDecisionNumber.Location = new System.Drawing.Point(352, 9);
            this.txtCaseDecisionNumber.Mask = "0000";
            this.txtCaseDecisionNumber.Name = "txtCaseDecisionNumber";
            this.txtCaseDecisionNumber.Size = new System.Drawing.Size(46, 26);
            this.txtCaseDecisionNumber.TabIndex = 48;
            this.txtCaseDecisionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaseDecisionNumber.TextChanged += new System.EventHandler(this.txtCaseDecisionNumber_TextChanged);
            // 
            // dtCaseDecision
            // 
            this.dtCaseDecision.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtCaseDecision.Location = new System.Drawing.Point(138, 7);
            this.dtCaseDecision.Name = "dtCaseDecision";
            this.dtCaseDecision.RightToLeftLayout = true;
            this.dtCaseDecision.Size = new System.Drawing.Size(134, 26);
            this.dtCaseDecision.TabIndex = 49;
            this.dtCaseDecision.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            this.dtCaseDecision.ValueChanged += new System.EventHandler(this.dtCaseDecision_ValueChanged);
            // 
            // dtCase
            // 
            this.dtCase.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCase.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtCase.CustomFormat = "yyyy";
            this.dtCase.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtCase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCase.Location = new System.Drawing.Point(232, 143);
            this.dtCase.Margin = new System.Windows.Forms.Padding(4);
            this.dtCase.Name = "dtCase";
            this.dtCase.RightToLeftLayout = true;
            this.dtCase.ShowUpDown = true;
            this.dtCase.Size = new System.Drawing.Size(60, 26);
            this.dtCase.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(181, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "لسنة: ";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtCaseNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCaseNumber.HidePromptOnLeave = true;
            this.txtCaseNumber.Location = new System.Drawing.Point(122, 146);
            this.txtCaseNumber.Mask = "0000";
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(50, 26);
            this.txtCaseNumber.TabIndex = 68;
            this.txtCaseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaseNumber.TextChanged += new System.EventHandler(this.txtCaseNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "في القضية رقم  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(217, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "بتاريخ ";
            // 
            // dpAPLetter
            // 
            this.dpAPLetter.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dpAPLetter.Location = new System.Drawing.Point(269, 55);
            this.dpAPLetter.Name = "dpAPLetter";
            this.dpAPLetter.RightToLeftLayout = true;
            this.dpAPLetter.Size = new System.Drawing.Size(134, 26);
            this.dpAPLetter.TabIndex = 65;
            this.dpAPLetter.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            this.dpAPLetter.ValueChanged += new System.EventHandler(this.dpAPLetter_ValueChanged);
            // 
            // txtAPLetterNumber
            // 
            this.txtAPLetterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAPLetterNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAPLetterNumber.HidePromptOnLeave = true;
            this.txtAPLetterNumber.Location = new System.Drawing.Point(161, 58);
            this.txtAPLetterNumber.Mask = "0000";
            this.txtAPLetterNumber.Name = "txtAPLetterNumber";
            this.txtAPLetterNumber.Size = new System.Drawing.Size(48, 26);
            this.txtAPLetterNumber.TabIndex = 64;
            this.txtAPLetterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAPLetterNumber.TextChanged += new System.EventHandler(this.txtAPLetterNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "بالاشارة الى كتابكم رقم  :";
            // 
            // ctrlDirection
            // 
            this.ctrlDirection.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApAddresses")));
            this.ctrlDirection.ApAddressVal = "";
            this.ctrlDirection.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApNames")));
            this.ctrlDirection.DeptNameVal = "";
            this.ctrlDirection.Filled = false;
            this.ctrlDirection.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDirection.Location = new System.Drawing.Point(86, 16);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.Size = new System.Drawing.Size(527, 33);
            this.ctrlDirection.TabIndex = 61;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(13, 22);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(56, 19);
            this.lblDirection.TabIndex = 60;
            this.lblDirection.Text = "التوجيه :";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(12, 238);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(601, 34);
            this.pnlButtons.TabIndex = 73;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(238, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "بتاريخ : ";
            // 
            // deRescriptDate
            // 
            this.deRescriptDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.deRescriptDate.Location = new System.Drawing.Point(299, 186);
            this.deRescriptDate.Name = "deRescriptDate";
            this.deRescriptDate.RightToLeftLayout = true;
            this.deRescriptDate.Size = new System.Drawing.Size(134, 26);
            this.deRescriptDate.TabIndex = 76;
            this.deRescriptDate.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            this.deRescriptDate.ValueChanged += new System.EventHandler(this.dtRescriptDate_ValueChanged);
            // 
            // txtRescriptNum
            // 
            this.txtRescriptNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtRescriptNum.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRescriptNum.HidePromptOnLeave = true;
            this.txtRescriptNum.Location = new System.Drawing.Point(179, 189);
            this.txtRescriptNum.Mask = "0000";
            this.txtRescriptNum.Name = "txtRescriptNum";
            this.txtRescriptNum.Size = new System.Drawing.Size(51, 26);
            this.txtRescriptNum.TabIndex = 75;
            this.txtRescriptNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRescriptNum.TextChanged += new System.EventHandler(this.txtRescriptNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(13, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 19);
            this.label7.TabIndex = 74;
            this.label7.Text = "القرار التنفيذي الصادر برقم :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(300, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 78;
            this.label8.Text = "والمقيدة ضد  : ";
            // 
            // txtGuilty
            // 
            this.txtGuilty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtGuilty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuilty.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGuilty.Location = new System.Drawing.Point(396, 146);
            this.txtGuilty.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuilty.Name = "txtGuilty";
            this.txtGuilty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuilty.Size = new System.Drawing.Size(217, 26);
            this.txtGuilty.TabIndex = 79;
            this.txtGuilty.TextChanged += new System.EventHandler(this.txtGuilty_TextChanged);
            // 
            // FrmRescriptSentLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 284);
            this.Controls.Add(this.txtGuilty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deRescriptDate);
            this.Controls.Add(this.txtRescriptNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtCase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCaseNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpAPLetter);
            this.Controls.Add(this.txtAPLetterNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.lblDirection);
            this.Name = "FrmRescriptSentLetter";
            this.Text = "خطاب ارسال قرار للنيابة";
            this.Load += new System.EventHandler(this.FrmRescriptSentLetter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtCaseDecisionYear;
        private System.Windows.Forms.RadioButton rdbtnYear;
        private System.Windows.Forms.RadioButton rdbtnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCaseDecisionNumber;
        private System.Windows.Forms.DateTimePicker dtCaseDecision;
        private System.Windows.Forms.DateTimePicker dtCase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCaseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpAPLetter;
        private System.Windows.Forms.MaskedTextBox txtAPLetterNumber;
        private System.Windows.Forms.Label label1;
        private Direction ctrlDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker deRescriptDate;
        private System.Windows.Forms.MaskedTextBox txtRescriptNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGuilty;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbxStatus;
    }
}