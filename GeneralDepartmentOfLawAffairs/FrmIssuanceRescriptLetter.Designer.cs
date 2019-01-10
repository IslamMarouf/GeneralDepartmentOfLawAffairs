namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmIssuanceRescriptLetter : GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIssuanceRescriptLetter));
            this.ctrlDirection = new GeneralDepartmentOfLawAffairs.Direction();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPLetterNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblInspectionNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpAPLetter = new System.Windows.Forms.DateTimePicker();
            this.dtCaseDecision = new System.Windows.Forms.DateTimePicker();
            this.txtCaseDecisionNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaseNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCase = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.direction1 = new GeneralDepartmentOfLawAffairs.Direction();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtCaseDecisionYear = new System.Windows.Forms.DateTimePicker();
            this.rdbtnYear = new System.Windows.Forms.RadioButton();
            this.rdbtnDate = new System.Windows.Forms.RadioButton();
            this.cmbxAPList = new System.Windows.Forms.ComboBox();
            this.txtGuilty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDirection
            // 
            this.ctrlDirection.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApAddresses")));
            this.ctrlDirection.ApAddressVal = "";
            this.ctrlDirection.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApNames")));
            this.ctrlDirection.DeptNameVal = "";
            this.ctrlDirection.Filled = false;
            this.ctrlDirection.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDirection.Location = new System.Drawing.Point(140, 12);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.Size = new System.Drawing.Size(527, 33);
            this.ctrlDirection.TabIndex = 25;
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
            this.lblDirection.TabIndex = 24;
            this.lblDirection.Text = "التوجيه :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "كتاب هيئة النيابة الإدارية  :";
            // 
            // txtAPLetterNumber
            // 
            this.txtAPLetterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAPLetterNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAPLetterNumber.HidePromptOnLeave = true;
            this.txtAPLetterNumber.Location = new System.Drawing.Point(432, 58);
            this.txtAPLetterNumber.Mask = "0000";
            this.txtAPLetterNumber.Name = "txtAPLetterNumber";
            this.txtAPLetterNumber.Size = new System.Drawing.Size(43, 26);
            this.txtAPLetterNumber.TabIndex = 28;
            this.txtAPLetterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAPLetterNumber.TextChanged += new System.EventHandler(this.txtAPLetterNumber_TextChanged);
            // 
            // lblInspectionNum
            // 
            this.lblInspectionNum.AutoSize = true;
            this.lblInspectionNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInspectionNum.Location = new System.Drawing.Point(385, 61);
            this.lblInspectionNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspectionNum.Name = "lblInspectionNum";
            this.lblInspectionNum.Size = new System.Drawing.Size(40, 19);
            this.lblInspectionNum.TabIndex = 27;
            this.lblInspectionNum.Text = "رقم : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(482, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "بتاريخ ";
            // 
            // dpAPLetter
            // 
            this.dpAPLetter.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dpAPLetter.Location = new System.Drawing.Point(534, 55);
            this.dpAPLetter.Name = "dpAPLetter";
            this.dpAPLetter.RightToLeftLayout = true;
            this.dpAPLetter.Size = new System.Drawing.Size(134, 26);
            this.dpAPLetter.TabIndex = 45;
            this.dpAPLetter.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            this.dpAPLetter.ValueChanged += new System.EventHandler(this.dpAPLetter_ValueChanged);
            // 
            // dtCaseDecision
            // 
            this.dtCaseDecision.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtCaseDecision.Location = new System.Drawing.Point(246, 8);
            this.dtCaseDecision.Name = "dtCaseDecision";
            this.dtCaseDecision.RightToLeftLayout = true;
            this.dtCaseDecision.Size = new System.Drawing.Size(134, 26);
            this.dtCaseDecision.TabIndex = 49;
            this.dtCaseDecision.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            this.dtCaseDecision.ValueChanged += new System.EventHandler(this.dtCaseDecision_ValueChanged);
            // 
            // txtCaseDecisionNumber
            // 
            this.txtCaseDecisionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtCaseDecisionNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCaseDecisionNumber.HidePromptOnLeave = true;
            this.txtCaseDecisionNumber.Location = new System.Drawing.Point(464, 10);
            this.txtCaseDecisionNumber.Mask = "0000";
            this.txtCaseDecisionNumber.Name = "txtCaseDecisionNumber";
            this.txtCaseDecisionNumber.Size = new System.Drawing.Size(46, 26);
            this.txtCaseDecisionNumber.TabIndex = 48;
            this.txtCaseDecisionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaseDecisionNumber.TextChanged += new System.EventHandler(this.txtCaseDecisionNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(517, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "قرار لجنة التأديب رقم  : ";
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
            this.label4.TabIndex = 51;
            this.label4.Text = "في القضية رقم  : ";
            // 
            // txtCaseNumber
            // 
            this.txtCaseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtCaseNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCaseNumber.HidePromptOnLeave = true;
            this.txtCaseNumber.Location = new System.Drawing.Point(122, 146);
            this.txtCaseNumber.Mask = "0000";
            this.txtCaseNumber.Name = "txtCaseNumber";
            this.txtCaseNumber.Size = new System.Drawing.Size(45, 26);
            this.txtCaseNumber.TabIndex = 52;
            this.txtCaseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCaseNumber.TextChanged += new System.EventHandler(this.txtCaseNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(174, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "لسنة : ";
            // 
            // dtCase
            // 
            this.dtCase.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCase.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtCase.CustomFormat = "yyyy";
            this.dtCase.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtCase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCase.Location = new System.Drawing.Point(225, 143);
            this.dtCase.Margin = new System.Windows.Forms.Padding(4);
            this.dtCase.Name = "dtCase";
            this.dtCase.RightToLeftLayout = true;
            this.dtCase.ShowUpDown = true;
            this.dtCase.Size = new System.Drawing.Size(60, 26);
            this.dtCase.TabIndex = 54;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(12, 247);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(656, 34);
            this.pnlButtons.TabIndex = 55;
            // 
            // pbxStatus
            // 
            this.pbxStatus.Image = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Sample4__2_;
            this.pbxStatus.Location = new System.Drawing.Point(614, 3);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(37, 28);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 78;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMessage.Location = new System.Drawing.Point(336, 8);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(275, 19);
            this.lblMessage.TabIndex = 77;
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
            // direction1
            // 
            this.direction1.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("direction1.ApAddresses")));
            this.direction1.ApAddressVal = "";
            this.direction1.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("direction1.ApNames")));
            this.direction1.DeptNameVal = "";
            this.direction1.Filled = false;
            this.direction1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction1.Location = new System.Drawing.Point(140, 208);
            this.direction1.MrMrsVal = "";
            this.direction1.Name = "direction1";
            this.direction1.RecipientVal = "";
            this.direction1.Size = new System.Drawing.Size(527, 33);
            this.direction1.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(13, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "صورة مرسلة الى  : ";
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
            this.panel1.Size = new System.Drawing.Size(655, 44);
            this.panel1.TabIndex = 58;
            // 
            // dtCaseDecisionYear
            // 
            this.dtCaseDecisionYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCaseDecisionYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtCaseDecisionYear.CustomFormat = "yyyy";
            this.dtCaseDecisionYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtCaseDecisionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCaseDecisionYear.Location = new System.Drawing.Point(112, 8);
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
            this.rdbtnYear.Location = new System.Drawing.Point(179, 12);
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
            this.rdbtnDate.Location = new System.Drawing.Point(386, 11);
            this.rdbtnDate.Name = "rdbtnDate";
            this.rdbtnDate.Size = new System.Drawing.Size(68, 23);
            this.rdbtnDate.TabIndex = 50;
            this.rdbtnDate.TabStop = true;
            this.rdbtnDate.Text = "بتاريخ :";
            this.rdbtnDate.UseVisualStyleBackColor = true;
            this.rdbtnDate.CheckedChanged += new System.EventHandler(this.DateType_CheckedChanged);
            // 
            // cmbxAPList
            // 
            this.cmbxAPList.FormattingEnabled = true;
            this.cmbxAPList.Location = new System.Drawing.Point(166, 58);
            this.cmbxAPList.Name = "cmbxAPList";
            this.cmbxAPList.Size = new System.Drawing.Size(212, 27);
            this.cmbxAPList.TabIndex = 59;
            this.cmbxAPList.SelectedIndexChanged += new System.EventHandler(this.cmbxAPList_SelectedIndexChanged);
            // 
            // txtGuilty
            // 
            this.txtGuilty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtGuilty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuilty.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGuilty.Location = new System.Drawing.Point(386, 146);
            this.txtGuilty.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuilty.Name = "txtGuilty";
            this.txtGuilty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuilty.Size = new System.Drawing.Size(281, 26);
            this.txtGuilty.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(290, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "والمقيدة ضد  : ";
            // 
            // FrmIssuanceRescriptLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 290);
            this.Controls.Add(this.txtGuilty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbxAPList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direction1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dtCase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCaseNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpAPLetter);
            this.Controls.Add(this.txtAPLetterNumber);
            this.Controls.Add(this.lblInspectionNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.lblDirection);
            this.Name = "FrmIssuanceRescriptLetter";
            this.Text = "خطاب طلب إستصدار قرار نيابة";
            this.Load += new System.EventHandler(this.FrmIssuanceRescriptLetter_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Direction ctrlDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAPLetterNumber;
        private System.Windows.Forms.Label lblInspectionNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpAPLetter;
        private System.Windows.Forms.DateTimePicker dtCaseDecision;
        private System.Windows.Forms.MaskedTextBox txtCaseDecisionNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCaseNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCase;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Direction direction1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtCaseDecisionYear;
        private System.Windows.Forms.RadioButton rdbtnYear;
        private System.Windows.Forms.RadioButton rdbtnDate;
        private System.Windows.Forms.ComboBox cmbxAPList;
        private System.Windows.Forms.TextBox txtGuilty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage;
    }
}