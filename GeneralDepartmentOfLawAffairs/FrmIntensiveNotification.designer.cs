namespace GeneralDepartmentOfLawAffairs
{
    partial class FrmIntensiveNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntensiveNotification));
            this.lblHestory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPickerLastNotification = new System.Windows.Forms.DateTimePicker();
            this.cmbxInvestigationNum = new System.Windows.Forms.ComboBox();
            this.pnlSummon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblMessage_3 = new System.Windows.Forms.Label();
            this.lblMessage_2 = new System.Windows.Forms.Label();
            this.pbxStatus = new System.Windows.Forms.PictureBox();
            this.lblMessage_1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctrlDirection = new GeneralDepartmentOfLawAffairs.Direction();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPkrInvestigationYear = new System.Windows.Forms.DateTimePicker();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblInvestigationNum = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dTPickerIncomDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotificationOutcomNumber = new System.Windows.Forms.TextBox();
            this.pnlSummon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHestory
            // 
            this.lblHestory.AutoSize = true;
            this.lblHestory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHestory.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHestory.Location = new System.Drawing.Point(217, 147);
            this.lblHestory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHestory.Name = "lblHestory";
            this.lblHestory.Size = new System.Drawing.Size(41, 19);
            this.lblHestory.TabIndex = 52;
            this.lblHestory.Text = "بتاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "بالاشارة الى الاخطار رقم ";
            // 
            // dTPickerLastNotification
            // 
            this.dTPickerLastNotification.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dTPickerLastNotification.Location = new System.Drawing.Point(265, 147);
            this.dTPickerLastNotification.Name = "dTPickerLastNotification";
            this.dTPickerLastNotification.RightToLeftLayout = true;
            this.dTPickerLastNotification.Size = new System.Drawing.Size(134, 26);
            this.dTPickerLastNotification.TabIndex = 49;
            this.dTPickerLastNotification.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            this.dTPickerLastNotification.ValueChanged += new System.EventHandler(this.dTPickerLastNotification_ValueChanged);
            // 
            // cmbxInvestigationNum
            // 
            this.cmbxInvestigationNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.cmbxInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbxInvestigationNum.FormatString = "N0";
            this.cmbxInvestigationNum.FormattingEnabled = true;
            this.cmbxInvestigationNum.Location = new System.Drawing.Point(94, 13);
            this.cmbxInvestigationNum.Name = "cmbxInvestigationNum";
            this.cmbxInvestigationNum.Size = new System.Drawing.Size(53, 27);
            this.cmbxInvestigationNum.TabIndex = 47;
            // 
            // pnlSummon
            // 
            this.pnlSummon.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.pnlSummon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSummon.Controls.Add(this.panel1);
            this.pnlSummon.Controls.Add(this.label6);
            this.pnlSummon.Controls.Add(this.dTPicker);
            this.pnlSummon.Controls.Add(this.txt_1);
            this.pnlSummon.Location = new System.Drawing.Point(93, 179);
            this.pnlSummon.Name = "pnlSummon";
            this.pnlSummon.Size = new System.Drawing.Size(527, 78);
            this.pnlSummon.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreyGradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 36);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "برجاء التنبيه على";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(145, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "مشددا بضرورة الحضور بجلسة";
            // 
            // dTPicker
            // 
            this.dTPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dTPicker.Location = new System.Drawing.Point(4, 42);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.RightToLeftLayout = true;
            this.dTPicker.Size = new System.Drawing.Size(134, 26);
            this.dTPicker.TabIndex = 43;
            this.dTPicker.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            this.dTPicker.ValueChanged += new System.EventHandler(this.dTPicker_ValueChanged);
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txt_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_1.Location = new System.Drawing.Point(321, 43);
            this.txt_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_1.Name = "txt_1";
            this.txt_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_1.Size = new System.Drawing.Size(202, 26);
            this.txt_1.TabIndex = 37;
            this.txt_1.TextChanged += new System.EventHandler(this.txt_1_TextChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.pnlButtons.Controls.Add(this.lblMessage_3);
            this.pnlButtons.Controls.Add(this.lblMessage_2);
            this.pnlButtons.Controls.Add(this.pbxStatus);
            this.pnlButtons.Controls.Add(this.lblMessage_1);
            this.pnlButtons.Controls.Add(this.lblMessage);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Location = new System.Drawing.Point(94, 263);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(526, 94);
            this.pnlButtons.TabIndex = 45;
            // 
            // lblMessage_3
            // 
            this.lblMessage_3.AutoSize = true;
            this.lblMessage_3.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_3.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_3.Location = new System.Drawing.Point(271, 62);
            this.lblMessage_3.Name = "lblMessage_3";
            this.lblMessage_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage_3.Size = new System.Drawing.Size(180, 17);
            this.lblMessage_3.TabIndex = 13;
            this.lblMessage_3.Text = "تم تحديد موعد الجلسة بتاريخ سابق";
            // 
            // lblMessage_2
            // 
            this.lblMessage_2.AutoSize = true;
            this.lblMessage_2.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_2.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_2.Location = new System.Drawing.Point(257, 45);
            this.lblMessage_2.Name = "lblMessage_2";
            this.lblMessage_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage_2.Size = new System.Drawing.Size(194, 17);
            this.lblMessage_2.TabIndex = 12;
            this.lblMessage_2.Text = "يجب تحديد تاريخ الصادر بشكل صحيح";
            // 
            // pbxStatus
            // 
            this.pbxStatus.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.Sample4__2_;
            this.pbxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxStatus.Location = new System.Drawing.Point(460, 16);
            this.pbxStatus.Name = "pbxStatus";
            this.pbxStatus.Size = new System.Drawing.Size(60, 60);
            this.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStatus.TabIndex = 11;
            this.pbxStatus.TabStop = false;
            // 
            // lblMessage_1
            // 
            this.lblMessage_1.AutoSize = true;
            this.lblMessage_1.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage_1.ForeColor = System.Drawing.Color.Red;
            this.lblMessage_1.Location = new System.Drawing.Point(283, 28);
            this.lblMessage_1.Name = "lblMessage_1";
            this.lblMessage_1.Size = new System.Drawing.Size(168, 17);
            this.lblMessage_1.TabIndex = 8;
            this.lblMessage_1.Text = "يجب كتابة اسم المطلوب حضوره";
            this.lblMessage_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(276, 11);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(175, 17);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "يجب كتابة رقم الصادر لاخر اخطار";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(5, 54);
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
            this.btnOK.Location = new System.Drawing.Point(125, 54);
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
            this.ctrlDirection.Location = new System.Drawing.Point(93, 107);
            this.ctrlDirection.MrMrsVal = "";
            this.ctrlDirection.Name = "ctrlDirection";
            this.ctrlDirection.RecipientVal = "";
            this.ctrlDirection.Size = new System.Drawing.Size(527, 33);
            this.ctrlDirection.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "لسنة:";
            // 
            // dtPkrInvestigationYear
            // 
            this.dtPkrInvestigationYear.CalendarFont = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPkrInvestigationYear.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.dtPkrInvestigationYear.CustomFormat = "yyyy";
            this.dtPkrInvestigationYear.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPkrInvestigationYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPkrInvestigationYear.Location = new System.Drawing.Point(201, 13);
            this.dtPkrInvestigationYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtPkrInvestigationYear.Name = "dtPkrInvestigationYear";
            this.dtPkrInvestigationYear.RightToLeftLayout = true;
            this.dtPkrInvestigationYear.ShowUpDown = true;
            this.dtPkrInvestigationYear.Size = new System.Drawing.Size(60, 26);
            this.dtPkrInvestigationYear.TabIndex = 42;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDirection.Location = new System.Drawing.Point(14, 107);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(56, 19);
            this.lblDirection.TabIndex = 41;
            this.lblDirection.Text = "التوجيه :";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSubject.Location = new System.Drawing.Point(93, 47);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubject.Size = new System.Drawing.Size(527, 53);
            this.txtSubject.TabIndex = 40;
            this.txtSubject.Text = "بشأن ...";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSubject.Location = new System.Drawing.Point(13, 47);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(68, 19);
            this.lblSubject.TabIndex = 39;
            this.lblSubject.Text = "الموضوع :";
            // 
            // lblInvestigationNum
            // 
            this.lblInvestigationNum.AutoSize = true;
            this.lblInvestigationNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationNum.ForeColor = System.Drawing.SystemColors.Info;
            this.lblInvestigationNum.Location = new System.Drawing.Point(13, 19);
            this.lblInvestigationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvestigationNum.Name = "lblInvestigationNum";
            this.lblInvestigationNum.Size = new System.Drawing.Size(83, 19);
            this.lblInvestigationNum.TabIndex = 38;
            this.lblInvestigationNum.Text = "رقم التحقيق : ";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHistory.Location = new System.Drawing.Point(269, 16);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(85, 19);
            this.lblHistory.TabIndex = 57;
            this.lblHistory.Text = "تاريخ الأحالة: ";
            // 
            // dTPickerIncomDate
            // 
            this.dTPickerIncomDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dTPickerIncomDate.Location = new System.Drawing.Point(355, 14);
            this.dTPickerIncomDate.Name = "dTPickerIncomDate";
            this.dTPickerIncomDate.RightToLeftLayout = true;
            this.dTPickerIncomDate.Size = new System.Drawing.Size(134, 26);
            this.dTPickerIncomDate.TabIndex = 56;
            this.dTPickerIncomDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // txtNotificationOutcomNumber
            // 
            this.txtNotificationOutcomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txtNotificationOutcomNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotificationOutcomNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNotificationOutcomNumber.Location = new System.Drawing.Point(158, 146);
            this.txtNotificationOutcomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotificationOutcomNumber.Name = "txtNotificationOutcomNumber";
            this.txtNotificationOutcomNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotificationOutcomNumber.Size = new System.Drawing.Size(51, 26);
            this.txtNotificationOutcomNumber.TabIndex = 58;
            this.txtNotificationOutcomNumber.TextChanged += new System.EventHandler(this.txtNotificationOutcomNumber_TextChanged);
            // 
            // FrmIntensiveNotification
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(632, 369);
            this.Controls.Add(this.txtNotificationOutcomNumber);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dTPickerIncomDate);
            this.Controls.Add(this.lblHestory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTPickerLastNotification);
            this.Controls.Add(this.cmbxInvestigationNum);
            this.Controls.Add(this.pnlSummon);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.ctrlDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPkrInvestigationYear);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblInvestigationNum);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmIntensiveNotification";
            this.Text = "إخطار مشدد";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIntensiveNotification_FormClosing);
            this.Load += new System.EventHandler(this.FrmIntensiveNotification_Load);
            this.pnlSummon.ResumeLayout(false);
            this.pnlSummon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxInvestigationNum;
        private System.Windows.Forms.Panel pnlSummon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPicker;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Direction ctrlDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPkrInvestigationYear;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblInvestigationNum;
        private System.Windows.Forms.DateTimePicker dTPickerLastNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHestory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DateTimePicker dTPickerIncomDate;
        private System.Windows.Forms.PictureBox pbxStatus;
        private System.Windows.Forms.Label lblMessage_1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtNotificationOutcomNumber;
        private System.Windows.Forms.Label lblMessage_3;
        private System.Windows.Forms.Label lblMessage_2;
    }
}