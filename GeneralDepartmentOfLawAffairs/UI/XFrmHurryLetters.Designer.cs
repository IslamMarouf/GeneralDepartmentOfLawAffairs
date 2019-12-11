namespace GeneralDepartmentOfLawAffairs.UI
{
    partial class XFrmHurryLetters
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
            this.components = new System.ComponentModel.Container();
            this.dflHurryLetters = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.vpHurryLetters = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vpHurryLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // XFrmHurryLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 449);
            this.MaximizeBox = false;
            this.Name = "XFrmHurryLetters";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XFrmHurryLetters";
            this.Load += new System.EventHandler(this.XFrmHurryLetters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpHurryLetters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel dflHurryLetters;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpHurryLetters;
    }
}