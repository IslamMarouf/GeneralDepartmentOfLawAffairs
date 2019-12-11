using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GeneralDepartmentOfLawAffairs.Properties;

namespace GeneralDepartmentOfLawAffairs.UI
{
    public partial class XFrmAddCeaseInvestigation : DevExpress.XtraEditors.XtraForm
    {
        /*private readonly List<Color> _fillColors = new List<Color>(new Color[] {
            DXSkinColors.FillColors.Danger,
            DXSkinColors.FillColors.Primary,
            DXSkinColors.FillColors.Question,
            DXSkinColors.FillColors.Success,
            DXSkinColors.FillColors.Warning
        });

        ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddCeaseInvestigation));
        SvgImageCollection svgImageCollection1 = new SvgImageCollection();
        AppearanceObject warningApp;
        SvgBitmap svgBitmap;
        SvgPalette palette;*/

        private string gDeptsConString = "SELECT * FROM tblDepartments";
        private readonly OleDbDataAdapter _gDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _gDeptsOdbCommand = new OleDbCommand();
        private readonly DataSet _gDeptsDs = new DataSet();

        private readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();

        private string ceaseDays = string.Empty;

        public XFrmAddCeaseInvestigation()
        {
            InitializeComponent();
            _gDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _gDeptsOdbCommand.CommandType = CommandType.Text;
            _gDeptsOdbCommand.CommandText = gDeptsConString;
            _gDepartmentsDataAdapter.SelectCommand = _gDeptsOdbCommand;
            _gDepartmentsDataAdapter.Fill(_gDeptsDs, "tblDepartments");

            /*svgImageCollection1.Add("Warning", ((SvgImage)(resources.GetObject("svgImageCollection1.Warning"))));
            svgImageCollection1.Add("Success", ((SvgImage)(resources.GetObject("svgImageCollection1.Success"))));
            svgImageCollection1.Add("Danger", ((SvgImage)(resources.GetObject("svgImageCollection1.Danger"))));

            svgBitmap = SvgBitmap.Create(svgImageCollection1["Danger"]);
            warningApp = new AppearanceObject(Appearance);
            warningApp.FontSizeDelta = 2;
            warningApp.TextOptions.HAlignment = HorzAlignment.Center;
            warningApp.TextOptions.VAlignment = VertAlignment.Center;
            palette = new SvgPalette();
            palette.Colors.Add(new SvgColor("Red", Color.Red));*/
        }

        private void XFrmAddCeaseInvestigation_Load(object sender, EventArgs e) {
            dflAddCeaseInvest.LookAndFeel.SkinName = Settings.Default.CurrentSkinName;

            var gDepts = from gd in _gDeptsDs.Tables["tblDepartments"].AsEnumerable()
                select gd;

            foreach (var gDept in gDepts)
            {
                cmbxDepartments.Properties.Items.Add(gDept.Field<string>("Dept_name"));
            }

            cmbxDepartments.SelectedIndex = 0;
            dtpAssignmentDate.EditValue = DateTime.Today;
            dTPickerIncomDate.EditValue = DateTime.Today;
            dtPkrInvestigationYear.EditValue = DateTime.Today;
            vpAddCeaseInvest.Validate();
        }

        private void mtxtInvestigationNum_EditValueChanged(object sender, EventArgs e)
        {
            vpAddCeaseInvest.Validate();

        }

        private void cmbxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGuiltyName_EditValueChanged(object sender, EventArgs e) {
            vpAddCeaseInvest.Validate();
        }

        private void btnCeaseDays_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!vpAddCeaseInvest.Validate())
                return;

            int intInsert = 0;
            string cmdString = "INSERT INTO tblSubjects (" +
                               "Subject_type," +
                               " Subject_num," +
                               " Subject_year," +
                               " Subject_about," +
                               " Subject_assignmentDate," +
                               " Subject_investigationType," +
                               " Subject_assignmentDept," +
                               " Subject_assignmentLetterDate," +
                               " Subject_assignmentLetterNum," +
                               " Subject_guiltyName," +
                               " Subject_ceaseDays," +
                               " Subject_ceaseMonths) " +
                               
                               "VALUES (" +
                               "@Subject_type," +
                               " @Subject_num," +
                               " @Subject_year," +
                               " @Subject_about," +
                               " @Subject_assignmentDate," +
                               " @Subject_investigationType," +
                               " @Subject_assignmentDept," +
                               " @Subject_assignmentLetterDate," +
                               " @Subject_assignmentLetterNum," +
                               " @Subject_guiltyName," +
                               " @Subject_ceaseDays," +
                               " @Subject_ceaseMonths)";

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = cmdString;
            _subjectsDataAdapter.InsertCommand = _subjectsOdbCommand;

            _subjectsOdbCommand.Parameters.Add("@Subject_type", OleDbType.Char).Value = LetterSentences.Investigation;
            _subjectsOdbCommand.Parameters.Add("@Subject_num", OleDbType.Char).Value = mtxtInvestigationNum.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_year", OleDbType.Char).Value = dtPkrInvestigationYear.DateTime.Year.ToString();
            _subjectsOdbCommand.Parameters.Add("@Subject_about", OleDbType.Char).Value = LetterSentences.Cease + " " + txtGuiltyName.Text + " " + LetterSentences.CeaseNote23 + cmbxDepartments.Text + " " + LetterSentences.CeaseNote27 + " " + ceaseDays + " " + LetterSentences.CeaseNote8;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDate", OleDbType.Date).Value = dtpAssignmentDate.DateTime.Date;
            _subjectsOdbCommand.Parameters.Add("@Subject_investigationType", OleDbType.Char).Value = LetterSentences.Cease;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentDept", OleDbType.Char).Value = cmbxDepartments.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterDate", OleDbType.DBDate).Value = dTPickerIncomDate.DateTime;
            _subjectsOdbCommand.Parameters.Add("@Subject_assignmentLetterNum", OleDbType.Char).Value = mtxtAssignmentLetter.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_guiltyName", OleDbType.Char).Value = txtGuiltyName.Text;
            _subjectsOdbCommand.Parameters.Add("@Subject_ceaseDays", OleDbType.Char).Value = "";
            _subjectsOdbCommand.Parameters.Add("@Subject_ceaseMonths", OleDbType.Char).Value = "";

            //intInsert = _subjectsDataAdapter.InsertCommand.ExecuteNonQuery();

            
            intInsert = _subjectsOdbCommand.ExecuteNonQuery();
            if (intInsert == 0)
            {
                XtraMessageBox.Show("The Data insertion is failed");
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void XFrmAddCeaseInvestigation_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gDepartmentsDataAdapter?.Dispose();
            _gDeptsOdbCommand?.Dispose();
            _subjectsDataAdapter?.Dispose();
            _subjectsOdbCommand?.Dispose();
        }

        private void mtxtAssignmentLetter_EditValueChanged(object sender, EventArgs e) {
            vpAddCeaseInvest.Validate();
        }

        private void dtpAssignmentDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dtpAssignmentDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_5, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dTPickerIncomDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime currentValue = ((DateEdit) sender).DateTime;
            if (currentValue.Date > DateTime.Today)
                e.Cancel = true;
        }

        private void dTPickerIncomDate_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(LetterSentences.LblMessage_7, LetterSentences.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void emptySpaceItem9_CustomDraw(object sender, DevExpress.XtraLayout.ItemCustomDrawEventArgs e) {
            /*string text = LetterSentences.LblMessage;



            warningApp.BackColor = _fillColors[0];
            warningApp.ForeColor = ContrastColor.GetContrastForeColor(warningApp.GetBackColor(LookAndFeel));
            warningApp.DrawBackground(e.Cache, e.ViewInfo.TextAreaRelativeToControl);
            Rectangle textAreaRelativeToControl = e.ViewInfo.TextAreaRelativeToControl;
            textAreaRelativeToControl.X += ScaleHelper.ScaleHorizontal(12);
            textAreaRelativeToControl.Width -= ScaleHelper.ScaleHorizontal(12);
            palette.CustomColor = warningApp.ForeColor;
            Image render = svgBitmap.Render(palette);
            Point imageLocation = new Point(textAreaRelativeToControl.X, textAreaRelativeToControl.Y + (textAreaRelativeToControl.Height - render.Height) / 2);
            e.Cache.DrawImage(render, imageLocation);
            textAreaRelativeToControl.X += render.Width + ScaleHelper.ScaleHorizontal(8);
            textAreaRelativeToControl.Width -= render.Width + ScaleHelper.ScaleHorizontal(8);
            warningApp.DrawString(e.Cache, text, textAreaRelativeToControl);*/
        }
    }
}