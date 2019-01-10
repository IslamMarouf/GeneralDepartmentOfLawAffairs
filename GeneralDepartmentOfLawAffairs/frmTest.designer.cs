namespace GeneralDepartmentOfLawAffairs
{
    partial class frmTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.direction1 = new GeneralDepartmentOfLawAffairs.Direction();
            this.sentPhotoCopy1 = new GeneralDepartmentOfLawAffairs.SentPhotoCopy();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 222);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direction1
            // 
            this.direction1.DeptNameVal = "";
            this.direction1.Filled = false;
            this.direction1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction1.Location = new System.Drawing.Point(13, 12);
            this.direction1.MrMrsVal = "";
            this.direction1.Name = "direction1";
            this.direction1.RecipientVal = "";
            this.direction1.Size = new System.Drawing.Size(529, 25);
            this.direction1.TabIndex = 0;
            // 
            // sentPhotoCopy1
            // 
            this.sentPhotoCopy1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sentPhotoCopy1.Location = new System.Drawing.Point(5, 43);
            this.sentPhotoCopy1.Name = "sentPhotoCopy1";
            this.sentPhotoCopy1.Size = new System.Drawing.Size(537, 192);
            this.sentPhotoCopy1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sentPhotoCopy1);
            this.Controls.Add(this.direction1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTest_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Direction direction1;
        private SentPhotoCopy sentPhotoCopy1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}