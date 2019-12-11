namespace GeneralDepartmentOfLawAffairs.Temp
{
    partial class FrmEmptyLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmptyLetter));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlSentPhotoCopy = new SentPhotoCopy();
            this.chkbxSentPhotoCopy = new System.Windows.Forms.CheckBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtAttachmentsCount = new System.Windows.Forms.MaskedTextBox();
            this.lblCompanionsCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpLetterDate = new System.Windows.Forms.DateTimePicker();
            this.txtAPLetterNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEmpty = new System.Windows.Forms.RadioButton();
            this.rbtnRef = new System.Windows.Forms.RadioButton();
            this.ctrlDirection = new GeneralDepartmentOfLawAffairs.UI.Direction();
            this.pnlButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(76, 418);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(527, 34);
            this.pnlButtons.TabIndex = 28;
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
            // ctrlSentPhotoCopy
            // 
            this.ctrlSentPhotoCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlSentPhotoCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlSentPhotoCopy.BackgroundImage")));
            this.ctrlSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSentPhotoCopy.Location = new System.Drawing.Point(76, 199);
            this.ctrlSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSentPhotoCopy.Name = "ctrlSentPhotoCopy";
            this.ctrlSentPhotoCopy.Size = new System.Drawing.Size(527, 210);
            this.ctrlSentPhotoCopy.TabIndex = 27;
            // 
            // chkbxSentPhotoCopy
            // 
            this.chkbxSentPhotoCopy.AutoSize = true;
            this.chkbxSentPhotoCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxSentPhotoCopy.ForeColor = System.Drawing.SystemColors.Info;
            this.chkbxSentPhotoCopy.Location = new System.Drawing.Point(23, 168);
            this.chkbxSentPhotoCopy.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxSentPhotoCopy.Name = "chkbxSentPhotoCopy";
            this.chkbxSentPhotoCopy.Size = new System.Drawing.Size(103, 23);
            this.chkbxSentPhotoCopy.TabIndex = 26;
            this.chkbxSentPhotoCopy.Text = "صورة مرسلة:";
            this.chkbxSentPhotoCopy.UseVisualStyleBackColor = true;
            this.chkbxSentPhotoCopy.CheckedChanged += new System.EventHandler(this.chkbxSentPhotoCopy_CheckedChanged);
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
            this.lblDirection.TabIndex = 29;
            this.lblDirection.Text = "التوجيه :";
            // 
            // txtAttachmentsCount
            // 
            this.txtAttachmentsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAttachmentsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAttachmentsCount.HidePromptOnLeave = true;
            this.txtAttachmentsCount.Location = new System.Drawing.Point(102, 135);
            this.txtAttachmentsCount.Mask = "000";
            this.txtAttachmentsCount.Name = "txtAttachmentsCount";
            this.txtAttachmentsCount.Size = new System.Drawing.Size(33, 26);
            this.txtAttachmentsCount.TabIndex = 32;
            this.txtAttachmentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompanionsCount
            // 
            this.lblCompanionsCount.AutoSize = true;
            this.lblCompanionsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanionsCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCompanionsCount.Location = new System.Drawing.Point(12, 138);
            this.lblCompanionsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanionsCount.Name = "lblCompanionsCount";
            this.lblCompanionsCount.Size = new System.Drawing.Size(87, 19);
            this.lblCompanionsCount.TabIndex = 31;
            this.lblCompanionsCount.Text = "عدد المرفقات :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(315, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 70;
            this.label6.Text = "بتاريخ ";
            // 
            // dpLetterDate
            // 
            this.dpLetterDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dpLetterDate.Location = new System.Drawing.Point(174, 16);
            this.dpLetterDate.Name = "dpLetterDate";
            this.dpLetterDate.RightToLeftLayout = true;
            this.dpLetterDate.Size = new System.Drawing.Size(134, 26);
            this.dpLetterDate.TabIndex = 69;
            this.dpLetterDate.Value = new System.DateTime(2018, 2, 19, 18, 24, 8, 0);
            // 
            // txtAPLetterNumber
            // 
            this.txtAPLetterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtAPLetterNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAPLetterNumber.HidePromptOnLeave = true;
            this.txtAPLetterNumber.Location = new System.Drawing.Point(367, 19);
            this.txtAPLetterNumber.Mask = "0000";
            this.txtAPLetterNumber.Name = "txtAPLetterNumber";
            this.txtAPLetterNumber.Size = new System.Drawing.Size(48, 26);
            this.txtAPLetterNumber.TabIndex = 68;
            this.txtAPLetterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEmpty);
            this.groupBox1.Controls.Add(this.rbtnRef);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dpLetterDate);
            this.groupBox1.Controls.Add(this.txtAPLetterNumber);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 78);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "محتوى الخطاب";
            // 
            // rbtnEmpty
            // 
            this.rbtnEmpty.AutoSize = true;
            this.rbtnEmpty.ForeColor = System.Drawing.SystemColors.Info;
            this.rbtnEmpty.Location = new System.Drawing.Point(528, 49);
            this.rbtnEmpty.Name = "rbtnEmpty";
            this.rbtnEmpty.Size = new System.Drawing.Size(52, 23);
            this.rbtnEmpty.TabIndex = 72;
            this.rbtnEmpty.TabStop = true;
            this.rbtnEmpty.Text = "فارغ";
            this.rbtnEmpty.UseVisualStyleBackColor = true;
            this.rbtnEmpty.CheckedChanged += new System.EventHandler(this.LetterContent_CheckedChanged);
            // 
            // rbtnRef
            // 
            this.rbtnRef.AutoSize = true;
            this.rbtnRef.ForeColor = System.Drawing.SystemColors.Info;
            this.rbtnRef.Location = new System.Drawing.Point(421, 20);
            this.rbtnRef.Name = "rbtnRef";
            this.rbtnRef.Size = new System.Drawing.Size(159, 23);
            this.rbtnRef.TabIndex = 71;
            this.rbtnRef.TabStop = true;
            this.rbtnRef.Text = "بالاشارة الى كتابكم رقم  :";
            this.rbtnRef.UseVisualStyleBackColor = true;
            this.rbtnRef.CheckedChanged += new System.EventHandler(this.LetterContent_CheckedChanged);
            // 
            // ctrlDirection
            // 
            this.ctrlDirection.ApAddresses = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApAddresses")));
            this.ctrlDirection.ApAddressVal = "";
            this.ctrlDirection.ApNames = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrlDirection.ApNames")));
            this.ctrlDirection.DeptNameVal = "";
            this.ctrlDirection.Filled = false;
            this.ctrlDirection.Location = new System.Drawing.Point(76, 12);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlDirection.Size = new System.Drawing.Size(530, 33);
            this.ctrlDirection.TabIndex = 72;
            // 
            // FrmEmptyLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 459);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAttachmentsCount);
            this.Controls.Add(this.lblCompanionsCount);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.ctrlSentPhotoCopy);
            this.Controls.Add(this.chkbxSentPhotoCopy);
            this.Name = "FrmEmptyLetter";
            this.Text = "خطاب عام";
            this.Load += new System.EventHandler(this.FrmEmptyLetter_Load);
            this.pnlButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private SentPhotoCopy ctrlSentPhotoCopy;
        private System.Windows.Forms.CheckBox chkbxSentPhotoCopy;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.MaskedTextBox txtAttachmentsCount;
        private System.Windows.Forms.Label lblCompanionsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpLetterDate;
        private System.Windows.Forms.MaskedTextBox txtAPLetterNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnEmpty;
        private System.Windows.Forms.RadioButton rbtnRef;
        private UI.Direction ctrlDirection;
    }
}