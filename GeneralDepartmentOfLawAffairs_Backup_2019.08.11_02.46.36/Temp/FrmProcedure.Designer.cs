namespace GeneralDepartmentOfLawAffairs.Temp
{
    partial class FrmProcedure
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
            this.lbl_procedureName = new System.Windows.Forms.Label();
            this.txt_about = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpassignmentDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_procedureName
            // 
            this.lbl_procedureName.AutoSize = true;
            this.lbl_procedureName.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_procedureName.Location = new System.Drawing.Point(99, 114);
            this.lbl_procedureName.Name = "lbl_procedureName";
            this.lbl_procedureName.Size = new System.Drawing.Size(33, 19);
            this.lbl_procedureName.TabIndex = 2;
            this.lbl_procedureName.Text = "عينة";
            // 
            // txt_about
            // 
            this.txt_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.txt_about.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_about.Location = new System.Drawing.Point(100, 42);
            this.txt_about.Multiline = true;
            this.txt_about.Name = "txt_about";
            this.txt_about.ReadOnly = true;
            this.txt_about.Size = new System.Drawing.Size(441, 57);
            this.txt_about.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاريخ الإحالة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "اخر إجراء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "الموضوع:";
            // 
            // dtpassignmentDate
            // 
            this.dtpassignmentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(86)))));
            this.dtpassignmentDate.Location = new System.Drawing.Point(100, 10);
            this.dtpassignmentDate.Name = "dtpassignmentDate";
            this.dtpassignmentDate.RightToLeftLayout = true;
            this.dtpassignmentDate.Size = new System.Drawing.Size(134, 26);
            this.dtpassignmentDate.TabIndex = 78;
            this.dtpassignmentDate.Value = new System.DateTime(2018, 2, 17, 11, 35, 30, 0);
            // 
            // FrmProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 182);
            this.Controls.Add(this.dtpassignmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_about);
            this.Controls.Add(this.lbl_procedureName);
            this.Name = "FrmProcedure";
            this.Text = "FrmProcedure";
            this.Load += new System.EventHandler(this.FrmProcedure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_procedureName;
        private System.Windows.Forms.TextBox txt_about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpassignmentDate;
    }
}