namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmInvestInquiry
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
            this.lblMessage_4 = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage_1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_about = new System.Windows.Forms.TextBox();
            this.lbl_procedureName = new System.Windows.Forms.Label();
            this.cmbxInvestigationNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPkrInvestigationYear = new System.Windows.Forms.DateTimePicker();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRushsNumber = new System.Windows.Forms.MaskedTextBox();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
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
            this.pnlButtons.Location = new System.Drawing.Point(13, 147);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(523, 82);
            this.pnlButtons.TabIndex = 77;
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
            // dtpAssignmentDate
            // 
            this.dtpAssignmentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpAssignmentDate.Enabled = false;
            this.dtpAssignmentDate.Location = new System.Drawing.Point(368, 10);
            this.dtpAssignmentDate.Name = "dtpAssignmentDate";
            this.dtpAssignmentDate.RightToLeftLayout = true;
            this.dtpAssignmentDate.Size = new System.Drawing.Size(168, 26);
            this.dtpAssignmentDate.TabIndex = 84;
            this.dtpAssignmentDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "الموضوع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "اخر إجراء:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(281, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "تاريخ الإحالة:";
            // 
            // txt_about
            // 
            this.txt_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txt_about.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_about.Location = new System.Drawing.Point(99, 46);
            this.txt_about.Multiline = true;
            this.txt_about.Name = "txt_about";
            this.txt_about.ReadOnly = true;
            this.txt_about.Size = new System.Drawing.Size(437, 57);
            this.txt_about.TabIndex = 80;
            // 
            // lbl_procedureName
            // 
            this.lbl_procedureName.AutoSize = true;
            this.lbl_procedureName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_procedureName.Location = new System.Drawing.Point(94, 118);
            this.lbl_procedureName.Name = "lbl_procedureName";
            this.lbl_procedureName.Size = new System.Drawing.Size(33, 19);
            this.lbl_procedureName.TabIndex = 79;
            this.lbl_procedureName.Text = "عينة";
            // 
            // cmbxInvestigationNum
            // 
            this.cmbxInvestigationNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxInvestigationNum.FormatString = "N0";
            this.cmbxInvestigationNum.FormattingEnabled = true;
            this.cmbxInvestigationNum.Location = new System.Drawing.Point(98, 10);
            this.cmbxInvestigationNum.Name = "cmbxInvestigationNum";
            this.cmbxInvestigationNum.Size = new System.Drawing.Size(53, 27);
            this.cmbxInvestigationNum.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(165, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 88;
            this.label4.Text = "لسنة:";
            // 
            // dtPkrInvestigationYear
            // 
            this.dtPkrInvestigationYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInvestigationYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInvestigationYear.CustomFormat = "yyyy";
            this.dtPkrInvestigationYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInvestigationYear.Enabled = false;
            this.dtPkrInvestigationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInvestigationYear.Location = new System.Drawing.Point(214, 10);
            this.dtPkrInvestigationYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInvestigationYear.Name = "dtPkrInvestigationYear";
            this.dtPkrInvestigationYear.RightToLeftLayout = true;
            this.dtPkrInvestigationYear.ShowUpDown = true;
            this.dtPkrInvestigationYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInvestigationYear.TabIndex = 87;
            // 
            // lblInvestigationNum
            // 
            this.lblInvestigationNum.AutoSize = true;
            this.lblInvestigationNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvestigationNum.Location = new System.Drawing.Point(8, 16);
            this.lblInvestigationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvestigationNum.Name = "lblInvestigationNum";
            this.lblInvestigationNum.Size = new System.Drawing.Size(83, 19);
            this.lblInvestigationNum.TabIndex = 86;
            this.lblInvestigationNum.Text = "رقم التحقيق : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(166, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 89;
            this.label5.Text = "استعجال رقم:";
            // 
            // txtRushsNumber
            // 
            this.txtRushsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtRushsNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRushsNumber.HidePromptOnLeave = true;
            this.txtRushsNumber.Location = new System.Drawing.Point(251, 115);
            this.txtRushsNumber.Mask = "0";
            this.txtRushsNumber.Name = "txtRushsNumber";
            this.txtRushsNumber.Size = new System.Drawing.Size(23, 26);
            this.txtRushsNumber.TabIndex = 90;
            this.txtRushsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmInvestInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 239);
            this.Controls.Add(this.txtRushsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbxInvestigationNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPkrInvestigationYear);
            this.Controls.Add(this.lblInvestigationNum);
            this.Controls.Add(this.dtpAssignmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_about);
            this.Controls.Add(this.lbl_procedureName);
            this.Controls.Add(this.pnlButtons);
            this.Name = "FrmInvestInquiry";
            this.Text = "استيفاء (تحقيق)";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblMessage_4;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage_1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_about;
        private System.Windows.Forms.Label lbl_procedureName;
        private System.Windows.Forms.ComboBox cmbxInvestigationNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPkrInvestigationYear;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtRushsNumber;
    }
}