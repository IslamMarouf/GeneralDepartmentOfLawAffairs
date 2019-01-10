namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmInspectionLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInspectionLetter));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInspectionNum = new System.Windows.Forms.Label();
            this.lblCompanionsCount = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.chkbxSentPhotoCopy = new System.Windows.Forms.CheckBox();
            this.dtPkrInspectionYear = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInspectionNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtAttachmentsCount = new System.Windows.Forms.MaskedTextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.ctrlSentPhotoCopy = new GeneralDepartmentOfLawAffairs.SentPhotoCopy();
            this.ctrlDirection = new GeneralDepartmentOfLawAffairs.Direction();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
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
            // lblInspectionNum
            // 
            this.lblInspectionNum.AutoSize = true;
            this.lblInspectionNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspectionNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInspectionNum.Location = new System.Drawing.Point(8, 13);
            this.lblInspectionNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspectionNum.Name = "lblInspectionNum";
            this.lblInspectionNum.Size = new System.Drawing.Size(82, 19);
            this.lblInspectionNum.TabIndex = 2;
            this.lblInspectionNum.Text = "رقم الفحص : ";
            // 
            // lblCompanionsCount
            // 
            this.lblCompanionsCount.AutoSize = true;
            this.lblCompanionsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanionsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCompanionsCount.Location = new System.Drawing.Point(243, 13);
            this.lblCompanionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanionsCount.Name = "lblCompanionsCount";
            this.lblCompanionsCount.Size = new System.Drawing.Size(83, 19);
            this.lblCompanionsCount.TabIndex = 3;
            this.lblCompanionsCount.Text = "عدد المرفقات:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(8, 84);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "الموضوع :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(88, 84);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(527, 86);
            this.txtSubject.TabIndex = 7;
            this.txtSubject.Text = "بشأن الشكوى المقدمة من... ";
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubject_KeyPress);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(8, 44);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(56, 19);
            this.lblDirection.TabIndex = 8;
            this.lblDirection.Text = "التوجيه :";
            // 
            // chkbxSentPhotoCopy
            // 
            this.chkbxSentPhotoCopy.AutoSize = true;
            this.chkbxSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSentPhotoCopy.ForeColor = System.Drawing.SystemColors.Info;
            this.chkbxSentPhotoCopy.Location = new System.Drawing.Point(12, 249);
            this.chkbxSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxSentPhotoCopy.Name = "chkbxSentPhotoCopy";
            this.chkbxSentPhotoCopy.Size = new System.Drawing.Size(103, 23);
            this.chkbxSentPhotoCopy.TabIndex = 11;
            this.chkbxSentPhotoCopy.Text = "صورة مرسلة:";
            this.chkbxSentPhotoCopy.UseVisualStyleBackColor = true;
            this.chkbxSentPhotoCopy.CheckedChanged += new System.EventHandler(this.chkbxSentPhotoCopy_CheckedChanged);
            // 
            // dtPkrInspectionYear
            // 
            this.dtPkrInspectionYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInspectionYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInspectionYear.CustomFormat = "yyyy";
            this.dtPkrInspectionYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInspectionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInspectionYear.Location = new System.Drawing.Point(175, 7);
            this.dtPkrInspectionYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInspectionYear.Name = "dtPkrInspectionYear";
            this.dtPkrInspectionYear.RightToLeftLayout = true;
            this.dtPkrInspectionYear.ShowUpDown = true;
            this.dtPkrInspectionYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInspectionYear.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(128, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "لسنة:";
            // 
            // txtInspectionNumber
            // 
            this.txtInspectionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtInspectionNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInspectionNumber.HidePromptOnLeave = true;
            this.txtInspectionNumber.Location = new System.Drawing.Point(88, 7);
            this.txtInspectionNumber.Mask = "000";
            this.txtInspectionNumber.Name = "txtInspectionNumber";
            this.txtInspectionNumber.Size = new System.Drawing.Size(33, 26);
            this.txtInspectionNumber.TabIndex = 19;
            this.txtInspectionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAttachmentsCount
            // 
            this.txtAttachmentsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAttachmentsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAttachmentsCount.HidePromptOnLeave = true;
            this.txtAttachmentsCount.Location = new System.Drawing.Point(333, 7);
            this.txtAttachmentsCount.Mask = "000";
            this.txtAttachmentsCount.Name = "txtAttachmentsCount";
            this.txtAttachmentsCount.Size = new System.Drawing.Size(33, 26);
            this.txtAttachmentsCount.TabIndex = 20;
            this.txtAttachmentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtRequest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRequest.Location = new System.Drawing.Point(88, 178);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequest.Size = new System.Drawing.Size(527, 63);
            this.txtRequest.TabIndex = 22;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.ForeColor = System.Drawing.SystemColors.Info;
            this.lblRequest.Location = new System.Drawing.Point(8, 178);
            this.lblRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(53, 19);
            this.lblRequest.TabIndex = 21;
            this.lblRequest.Text = "المطلوب";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(88, 497);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(527, 34);
            this.pnlButtons.TabIndex = 25;
            // 
            // ctrlSentPhotoCopy
            // 
            this.ctrlSentPhotoCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlSentPhotoCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlSentPhotoCopy.BackgroundImage")));
            this.ctrlSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSentPhotoCopy.Location = new System.Drawing.Point(88, 280);
            this.ctrlSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSentPhotoCopy.Name = "ctrlSentPhotoCopy";
            this.ctrlSentPhotoCopy.Size = new System.Drawing.Size(527, 210);
            this.ctrlSentPhotoCopy.TabIndex = 24;
            this.ctrlSentPhotoCopy.Load += new System.EventHandler(this.ctrlSentPhotoCopy_Load);
            // 
            // ctrlDirection
            // 
            this.ctrlDirection.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApAddresses")));
            this.ctrlDirection.ApAddressVal = "";
            this.ctrlDirection.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApNames")));
            this.ctrlDirection.DeptNameVal = "";
            this.ctrlDirection.Filled = false;
            this.ctrlDirection.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDirection.Location = new System.Drawing.Point(88, 44);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.Size = new System.Drawing.Size(527, 33);
            this.ctrlDirection.TabIndex = 23;
            // 
            // FrmInspectionLetter
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(635, 538);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.ctrlSentPhotoCopy);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.txtAttachmentsCount);
            this.Controls.Add(this.txtInspectionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrInspectionYear);
            this.Controls.Add(this.chkbxSentPhotoCopy);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCompanionsCount);
            this.Controls.Add(this.lblInspectionNum);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmInspectionLetter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خطاب فحص شكوى";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInspectionLetter_FormClosing);
            this.Load += new System.EventHandler(this.FrmInspectionLetter_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInspectionNum;
        private System.Windows.Forms.Label lblCompanionsCount;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.CheckBox chkbxSentPhotoCopy;
        private System.Windows.Forms.DateTimePicker dtPkrInspectionYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtInspectionNumber;
        private System.Windows.Forms.MaskedTextBox txtAttachmentsCount;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label lblRequest;
        private Direction ctrlDirection;
        private SentPhotoCopy ctrlSentPhotoCopy;
        private System.Windows.Forms.Panel pnlButtons;
    }
}