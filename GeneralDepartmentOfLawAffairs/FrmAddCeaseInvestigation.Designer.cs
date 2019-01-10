namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmAddCeaseInvestigation
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
            this.lblMessage_3 = new System.Windows.Forms.Label();
            this.lblMessage_2 = new System.Windows.Forms.Label();
            this.lblMessage_1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPkrInvestigationYear = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHistory.Location = new System.Drawing.Point(259, 17);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(85, 19);
            this.lblHistory.TabIndex = 67;
            this.lblHistory.Text = "تاريخ الأحالة: ";
            // 
            // dTPickerIncomDate
            // 
            this.dTPickerIncomDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dTPickerIncomDate.Location = new System.Drawing.Point(351, 10);
            this.dTPickerIncomDate.Name = "dTPickerIncomDate";
            this.dTPickerIncomDate.RightToLeftLayout = true;
            this.dTPickerIncomDate.Size = new System.Drawing.Size(134, 26);
            this.dTPickerIncomDate.TabIndex = 66;
            this.dTPickerIncomDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButtons.Controls.Add(this.lblMessage_4);
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage_3);
            this.pnlButtons.Controls.Add(this.lblMessage_2);
            this.pnlButtons.Controls.Add(this.lblMessage_1);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(94, 299);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(523, 110);
            this.pnlButtons.TabIndex = 64;
            // 
            // lblMessage_4
            // 
            this.lblMessage_4.AutoSize = true;
            this.lblMessage_4.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_4.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_4.Location = new System.Drawing.Point(258, 82);
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
            this.pbxStatus.Location = new System.Drawing.Point(456, 25);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(60, 60);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 6;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage_3
            // 
            this.lblMessage_3.AutoSize = true;
            this.lblMessage_3.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_3.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_3.Location = new System.Drawing.Point(270, 64);
            this.lblMessage_3.Name = "lblMessage_3";
            this.lblMessage_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage_3.Size = new System.Drawing.Size(180, 17);
            this.lblMessage_3.TabIndex = 5;
            this.lblMessage_3.Text = "تم تحديد موعد الجلسة بتاريخ سابق";
            // 
            // lblMessage_2
            // 
            this.lblMessage_2.AutoSize = true;
            this.lblMessage_2.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_2.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_2.Location = new System.Drawing.Point(282, 46);
            this.lblMessage_2.Name = "lblMessage_2";
            this.lblMessage_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage_2.Size = new System.Drawing.Size(168, 17);
            this.lblMessage_2.TabIndex = 4;
            this.lblMessage_2.Text = "يجب كتابة اسم المطلوب حضوره";
            // 
            // lblMessage_1
            // 
            this.lblMessage_1.AutoSize = true;
            this.lblMessage_1.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_1.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_1.Location = new System.Drawing.Point(280, 28);
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
            this.lblMessage.Location = new System.Drawing.Point(283, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(168, 17);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "يجب كتابة أو اختيار رقم التحقيق";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(4, 68);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 1;
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
            this.btnOK.Location = new System.Drawing.Point(124, 68);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "موافق";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(144, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "لسنة:";
            // 
            // dtPkrInvestigationYear
            // 
            this.dtPkrInvestigationYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInvestigationYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInvestigationYear.CustomFormat = "yyyy";
            this.dtPkrInvestigationYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInvestigationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInvestigationYear.Location = new System.Drawing.Point(191, 11);
            this.dtPkrInvestigationYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInvestigationYear.Name = "dtPkrInvestigationYear";
            this.dtPkrInvestigationYear.RightToLeftLayout = true;
            this.dtPkrInvestigationYear.ShowUpDown = true;
            this.dtPkrInvestigationYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInvestigationYear.TabIndex = 62;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(94, 130);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(527, 53);
            this.txtSubject.TabIndex = 57;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(14, 130);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 60;
            this.lblSubject.Text = "الموضوع :";
            // 
            // lblInvestigationNum
            // 
            this.lblInvestigationNum.AutoSize = true;
            this.lblInvestigationNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvestigationNum.Location = new System.Drawing.Point(14, 17);
            this.lblInvestigationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvestigationNum.Name = "lblInvestigationNum";
            this.lblInvestigationNum.Size = new System.Drawing.Size(83, 19);
            this.lblInvestigationNum.TabIndex = 59;
            this.lblInvestigationNum.Text = "رقم التحقيق : ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox1.Location = new System.Drawing.Point(104, 10);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(33, 26);
            this.maskedTextBox1.TabIndex = 68;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(138, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "اسم المشكو في حقه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(308, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "الجهة التابع لها :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 72;
            this.button1.Text = "ايام الانقطاع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddCeaseInvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dTPickerIncomDate);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrInvestigationYear);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblInvestigationNum);
            this.Name = "FrmAddCeaseInvestigation";
            this.Text = "تحقيق انقطاع";
            this.Load += new System.EventHandler(this.FrmAddCeaseInvestigation_Load);
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
        private System.Windows.Forms.Label lblMessage_3;
        private System.Windows.Forms.Label lblMessage_2;
        private System.Windows.Forms.Label lblMessage_1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPkrInvestigationYear;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}