using System;
using System.Data;
using System.Data.OleDb;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmAddCeaseInvestigation : GeneralForm
    {
        private string gDeptsConString = "SELECT * FROM tblDepartments";
        private readonly OleDbDataAdapter _gDepartmentsDataAdapter = new OleDbDataAdapter();
        private readonly OleDbCommand _gDeptsOdbCommand = new OleDbCommand();
        private readonly DataSet _gDeptsDs = new DataSet();

        public FrmAddCeaseInvestigation()
        {
            InitializeComponent();

            _gDeptsOdbCommand.Connection = Globals.ThisAddIn.DepartmentsConnection;
            _gDeptsOdbCommand.CommandType = CommandType.Text;
            _gDeptsOdbCommand.CommandText = gDeptsConString;
            _gDepartmentsDataAdapter.SelectCommand = _gDeptsOdbCommand;
            _gDepartmentsDataAdapter.Fill(_gDeptsDs, "tblDepartments");
        }     

        private void FrmAddCeaseInvestigation_Load(object sender, EventArgs e)
        {
            var gDepts = from gd in _gDeptsDs.Tables["tblDepartments"].AsEnumerable()
                select gd;

            foreach (var gdept in gDepts)
            {
                cmbxDepartments.Items.Add(gdept.Field<string>("Dept_name"));
            }

            cmbxDepartments.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dTPickerIncomDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddCeaseInvestigation_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _gDepartmentsDataAdapter?.Dispose();
            _gDeptsOdbCommand?.Dispose();
        }
    }
}
