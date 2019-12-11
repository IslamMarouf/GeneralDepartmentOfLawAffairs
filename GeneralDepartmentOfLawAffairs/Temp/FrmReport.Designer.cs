namespace GeneralDepartmentOfLawAffairs.Temp
{
    partial class FrmReport
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
            this.dgvInvestigations = new System.Windows.Forms.DataGridView();
            this.dgvInspections = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDate = new System.Windows.Forms.CheckBox();
            this.cbxOut = new System.Windows.Forms.CheckBox();
            this.cbxLastProc = new System.Windows.Forms.CheckBox();
            this.cbxAssignmentDate = new System.Windows.Forms.CheckBox();
            this.cbxAbout = new System.Windows.Forms.CheckBox();
            this.cbxYear = new System.Windows.Forms.CheckBox();
            this.cbxNum = new System.Windows.Forms.CheckBox();
            this.btnViewSubjects = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnCustomView = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvestigations
            // 
            this.dgvInvestigations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInvestigations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestigations.Location = new System.Drawing.Point(3, 201);
            this.dgvInvestigations.Name = "dgvInvestigations";
            this.dgvInvestigations.Size = new System.Drawing.Size(757, 195);
            this.dgvInvestigations.TabIndex = 0;
            // 
            // dgvInspections
            // 
            this.dgvInspections.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspections.Location = new System.Drawing.Point(3, 454);
            this.dgvInspections.Name = "dgvInspections";
            this.dgvInspections.Size = new System.Drawing.Size(757, 201);
            this.dgvInspections.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvInspections, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvInvestigations, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17327F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.433187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.8091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.433187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.54332F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 673);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreyGradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 33);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(328, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "تحقيقات";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreyGradient;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 33);
            this.panel2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(328, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "فحوصات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDate);
            this.groupBox1.Controls.Add(this.cbxOut);
            this.groupBox1.Controls.Add(this.cbxLastProc);
            this.groupBox1.Controls.Add(this.cbxAssignmentDate);
            this.groupBox1.Controls.Add(this.cbxAbout);
            this.groupBox1.Controls.Add(this.cbxYear);
            this.groupBox1.Controls.Add(this.cbxNum);
            this.groupBox1.Controls.Add(this.btnViewSubjects);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbtnCustomView);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 145);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طريقة عرض البيانات";
            // 
            // cbxDate
            // 
            this.cbxDate.AutoSize = true;
            this.cbxDate.Location = new System.Drawing.Point(206, 92);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(60, 23);
            this.cbxDate.TabIndex = 53;
            this.cbxDate.Text = "بتاريخ";
            this.cbxDate.UseVisualStyleBackColor = true;
            // 
            // cbxOut
            // 
            this.cbxOut.AutoSize = true;
            this.cbxOut.Location = new System.Drawing.Point(272, 92);
            this.cbxOut.Name = "cbxOut";
            this.cbxOut.Size = new System.Drawing.Size(56, 23);
            this.cbxOut.TabIndex = 52;
            this.cbxOut.Text = "صادر";
            this.cbxOut.UseVisualStyleBackColor = true;
            // 
            // cbxLastProc
            // 
            this.cbxLastProc.AutoSize = true;
            this.cbxLastProc.Location = new System.Drawing.Point(334, 92);
            this.cbxLastProc.Name = "cbxLastProc";
            this.cbxLastProc.Size = new System.Drawing.Size(82, 23);
            this.cbxLastProc.TabIndex = 51;
            this.cbxLastProc.Text = "اخر إجراء";
            this.cbxLastProc.UseVisualStyleBackColor = true;
            // 
            // cbxAssignmentDate
            // 
            this.cbxAssignmentDate.AutoSize = true;
            this.cbxAssignmentDate.Location = new System.Drawing.Point(422, 92);
            this.cbxAssignmentDate.Name = "cbxAssignmentDate";
            this.cbxAssignmentDate.Size = new System.Drawing.Size(95, 23);
            this.cbxAssignmentDate.TabIndex = 50;
            this.cbxAssignmentDate.Text = "تاريخ الإحالة";
            this.cbxAssignmentDate.UseVisualStyleBackColor = true;
            // 
            // cbxAbout
            // 
            this.cbxAbout.AutoSize = true;
            this.cbxAbout.Location = new System.Drawing.Point(523, 92);
            this.cbxAbout.Name = "cbxAbout";
            this.cbxAbout.Size = new System.Drawing.Size(55, 23);
            this.cbxAbout.TabIndex = 49;
            this.cbxAbout.Text = "بشأن";
            this.cbxAbout.UseVisualStyleBackColor = true;
            // 
            // cbxYear
            // 
            this.cbxYear.AutoSize = true;
            this.cbxYear.Location = new System.Drawing.Point(584, 92);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(53, 23);
            this.cbxYear.TabIndex = 48;
            this.cbxYear.Text = "لسنة";
            this.cbxYear.UseVisualStyleBackColor = true;
            // 
            // cbxNum
            // 
            this.cbxNum.AutoSize = true;
            this.cbxNum.Location = new System.Drawing.Point(643, 92);
            this.cbxNum.Name = "cbxNum";
            this.cbxNum.Size = new System.Drawing.Size(100, 23);
            this.cbxNum.TabIndex = 47;
            this.cbxNum.Text = "رقم الموضوع";
            this.cbxNum.UseVisualStyleBackColor = true;
            // 
            // btnViewSubjects
            // 
            this.btnViewSubjects.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnViewSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewSubjects.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnViewSubjects.ForeColor = System.Drawing.Color.White;
            this.btnViewSubjects.Location = new System.Drawing.Point(7, 49);
            this.btnViewSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSubjects.Name = "btnViewSubjects";
            this.btnViewSubjects.Size = new System.Drawing.Size(129, 32);
            this.btnViewSubjects.TabIndex = 46;
            this.btnViewSubjects.Text = "عرض الموضوعات";
            this.btnViewSubjects.UseVisualStyleBackColor = true;
            this.btnViewSubjects.Click += new System.EventHandler(this.btnViewSubjects_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpTo.Location = new System.Drawing.Point(143, 51);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.Size = new System.Drawing.Size(134, 26);
            this.dtpTo.TabIndex = 45;
            this.dtpTo.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpFrom.Location = new System.Drawing.Point(315, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.Size = new System.Drawing.Size(134, 26);
            this.dtpFrom.TabIndex = 44;
            this.dtpFrom.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "إلي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الإحالة من";
            // 
            // rbtnCustomView
            // 
            this.rbtnCustomView.AutoSize = true;
            this.rbtnCustomView.Location = new System.Drawing.Point(643, 54);
            this.rbtnCustomView.Name = "rbtnCustomView";
            this.rbtnCustomView.Size = new System.Drawing.Size(108, 23);
            this.rbtnCustomView.TabIndex = 1;
            this.rbtnCustomView.TabStop = true;
            this.rbtnCustomView.Text = "عرض مخصص";
            this.rbtnCustomView.UseVisualStyleBackColor = true;
            this.rbtnCustomView.CheckedChanged += new System.EventHandler(this.ViewType_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(618, 25);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(133, 23);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "عرض جميع البيانات";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.ViewType_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = global::GeneralDepartmentOfLawAffairs.Properties.Resources.GreenGradient;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(3, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 39);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(15, 692);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 46);
            this.panel3.TabIndex = 51;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmReport";
            this.Text = "بيان بالموضوعات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvestigations;
        private System.Windows.Forms.DataGridView dgvInspections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnCustomView;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnViewSubjects;
        private System.Windows.Forms.CheckBox cbxDate;
        private System.Windows.Forms.CheckBox cbxOut;
        private System.Windows.Forms.CheckBox cbxLastProc;
        private System.Windows.Forms.CheckBox cbxAssignmentDate;
        private System.Windows.Forms.CheckBox cbxAbout;
        private System.Windows.Forms.CheckBox cbxYear;
        private System.Windows.Forms.CheckBox cbxNum;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel3;
    }
}