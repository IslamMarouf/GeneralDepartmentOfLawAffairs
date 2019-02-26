using System.Data;
using System.Data.OleDb;

namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmInvestInquiry : GeneralForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        private string _subjectsConStr = "SELECT * FROM tblSubjects";
        readonly OleDbDataAdapter _subjectsDataAdapter = new OleDbDataAdapter();
        readonly OleDbCommand _subjectsOdbCommand = new OleDbCommand();
        private readonly DataSet _subjectsDs = new DataSet();

        public FrmInvestInquiry()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();

            _subjectsOdbCommand.Connection = Globals.ThisAddIn.SubjectsConnection;
            _subjectsOdbCommand.CommandType = CommandType.Text;
            _subjectsOdbCommand.CommandText = _subjectsConStr;
            _subjectsDataAdapter.SelectCommand = _subjectsOdbCommand;
            _subjectsDataAdapter.Fill(_subjectsDs, "tblSubjects");
        }

        private void FrmInvestInquiry_Load(object sender, System.EventArgs e)
        {

        }
    }
}
