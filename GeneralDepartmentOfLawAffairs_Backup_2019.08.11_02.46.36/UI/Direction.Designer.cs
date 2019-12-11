namespace GeneralDepartmentOfLawAffairs.UI
{
    partial class Direction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbxMrMrs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbxRecipientDeptName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbxRecipient = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxMrMrs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxRecipientDeptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxRecipient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxMrMrs
            // 
            this.cmbxMrMrs.Location = new System.Drawing.Point(525, 12);
            this.cmbxMrMrs.Name = "cmbxMrMrs";
            this.cmbxMrMrs.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbxMrMrs.Properties.Appearance.Options.UseFont = true;
            this.cmbxMrMrs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbxMrMrs.Size = new System.Drawing.Size(133, 26);
            this.cmbxMrMrs.StyleController = this.layoutControl1;
            this.cmbxMrMrs.TabIndex = 0;
            this.cmbxMrMrs.SelectedIndexChanged += new System.EventHandler(this.cmbxMrMrs_SelectedIndexChanged);
            this.cmbxMrMrs.TextChanged += new System.EventHandler(this.cmbxMrMrs_TextChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbxRecipientDeptName);
            this.layoutControl1.Controls.Add(this.cmbxMrMrs);
            this.layoutControl1.Controls.Add(this.cmbxRecipient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(670, 50);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbxRecipientDeptName
            // 
            this.cmbxRecipientDeptName.Location = new System.Drawing.Point(12, 12);
            this.cmbxRecipientDeptName.Name = "cmbxRecipientDeptName";
            this.cmbxRecipientDeptName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbxRecipientDeptName.Properties.Appearance.Options.UseFont = true;
            this.cmbxRecipientDeptName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbxRecipientDeptName.Size = new System.Drawing.Size(375, 26);
            this.cmbxRecipientDeptName.StyleController = this.layoutControl1;
            this.cmbxRecipientDeptName.TabIndex = 2;
            this.cmbxRecipientDeptName.SelectedIndexChanged += new System.EventHandler(this.cmbxRecipientDeptName_SelectedIndexChanged);
            this.cmbxRecipientDeptName.TextChanged += new System.EventHandler(this.cmbxRecipientDeptName_TextChanged);
            // 
            // cmbxRecipient
            // 
            this.cmbxRecipient.Location = new System.Drawing.Point(391, 12);
            this.cmbxRecipient.Name = "cmbxRecipient";
            this.cmbxRecipient.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbxRecipient.Properties.Appearance.Options.UseFont = true;
            this.cmbxRecipient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbxRecipient.Size = new System.Drawing.Size(130, 26);
            this.cmbxRecipient.StyleController = this.layoutControl1;
            this.cmbxRecipient.TabIndex = 1;
            this.cmbxRecipient.SelectedIndexChanged += new System.EventHandler(this.cmbxRecipient_SelectedIndexChanged);
            this.cmbxRecipient.TextChanged += new System.EventHandler(this.cmbxRecipient_TextChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(670, 50);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbxMrMrs;
            this.layoutControlItem1.Location = new System.Drawing.Point(513, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(137, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbxRecipient;
            this.layoutControlItem2.Location = new System.Drawing.Point(379, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(134, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbxRecipientDeptName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(379, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(454, 30);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(121, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Direction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Direction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(670, 50);
            this.Load += new System.EventHandler(this.Direction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbxMrMrs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbxRecipientDeptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxRecipient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.ComboBoxEdit cmbxMrMrs;
        public DevExpress.XtraEditors.ComboBoxEdit cmbxRecipient;
        public DevExpress.XtraEditors.ComboBoxEdit cmbxRecipientDeptName;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
