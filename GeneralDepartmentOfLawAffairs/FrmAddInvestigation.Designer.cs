namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmAddInvestigation
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.dTPickerIncomDate = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblMessage_4 = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage_1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtInspectionNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPkrInspectionYear = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblInspectionNum = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHistory.Location = new System.Drawing.Point(248, 18);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(85, 19);
            this.lblHistory.TabIndex = 78;
            this.lblHistory.Text = "تاريخ الأحالة: ";
            // 
            // dTPickerIncomDate
            // 
            this.dTPickerIncomDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dTPickerIncomDate.Location = new System.Drawing.Point(340, 11);
            this.dTPickerIncomDate.Name = "dTPickerIncomDate";
            this.dTPickerIncomDate.RightToLeftLayout = true;
            this.dTPickerIncomDate.Size = new System.Drawing.Size(134, 26);
            this.dTPickerIncomDate.TabIndex = 77;
            this.dTPickerIncomDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButtons.Controls.Add(this.lblMessage_4);
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage_1);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(97, 138);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(523, 82);
            this.pnlButtons.TabIndex = 76;
            // 
            // lblMessage_4
            // 
            this.lblMessage_4.AutoSize = true;
            this.lblMessage_4.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_4.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_4.Location = new System.Drawing.Point(255, 53);
            this.lblMessage_4.Name = "lblMessage_4";
            this.lblMessage_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage_4.Size = new System.Drawing.Size(192, 17);
            this.lblMessage_4.TabIndex = 7;
            this.lblMessage_4.Text = "يجب تحديد تاريخ الإحالة بشكل صحيح";
            // 
            // pbxStatus
            // 
            this.pbxStatus.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Sample4__2_;
            this.pbxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxStatus.Location = new System.Drawing.Point(456, 13);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(60, 60);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 6;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage_1
            // 
            this.lblMessage_1.AutoSize = true;
            this.lblMessage_1.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_1.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_1.Location = new System.Drawing.Point(274, 35);
            this.lblMessage_1.Name = "lblMessage_1";
            this.lblMessage_1.Size = new System.Drawing.Size(173, 17);
            this.lblMessage_1.TabIndex = 3;
            this.lblMessage_1.Text = "يجب كتابة الموضوع بشكل واضح";
            this.lblMessage_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(328, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(119, 17);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "يجب كتابة رقم التحقيق";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(4, 37);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(124, 37);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "موافق";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtInspectionNumber
            // 
            this.txtInspectionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtInspectionNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInspectionNumber.HidePromptOnLeave = true;
            this.txtInspectionNumber.Location = new System.Drawing.Point(93, 12);
            this.txtInspectionNumber.Mask = "000";
            this.txtInspectionNumber.Name = "txtInspectionNumber";
            this.txtInspectionNumber.Size = new System.Drawing.Size(33, 26);
            this.txtInspectionNumber.TabIndex = 75;
            this.txtInspectionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(133, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "لسنة:";
            // 
            // dtPkrInspectionYear
            // 
            this.dtPkrInspectionYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInspectionYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInspectionYear.CustomFormat = "yyyy";
            this.dtPkrInspectionYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInspectionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInspectionYear.Location = new System.Drawing.Point(180, 12);
            this.dtPkrInspectionYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInspectionYear.Name = "dtPkrInspectionYear";
            this.dtPkrInspectionYear.RightToLeftLayout = true;
            this.dtPkrInspectionYear.ShowUpDown = true;
            this.dtPkrInspectionYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInspectionYear.TabIndex = 73;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(93, 45);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(527, 86);
            this.txtSubject.TabIndex = 72;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(13, 45);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 71;
            this.lblSubject.Text = "الموضوع :";
            // 
            // lblInspectionNum
            // 
            this.lblInspectionNum.AutoSize = true;
            this.lblInspectionNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInspectionNum.Location = new System.Drawing.Point(13, 18);
            this.lblInspectionNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspectionNum.Name = "lblInspectionNum";
            this.lblInspectionNum.Size = new System.Drawing.Size(83, 19);
            this.lblInspectionNum.TabIndex = 70;
            this.lblInspectionNum.Text = "رقم التحقيق : ";
            // 
            // FrmAddInvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 228);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dTPickerIncomDate);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtInspectionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrInspectionYear);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblInspectionNum);
            this.Name = "FrmAddInvestigation";
            this.Text = "تحقيق";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DateTimePicker dTPickerIncomDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblMessage_4;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage_1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.MaskedTextBox txtInspectionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPkrInspectionYear;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblInspectionNum;
    }
}