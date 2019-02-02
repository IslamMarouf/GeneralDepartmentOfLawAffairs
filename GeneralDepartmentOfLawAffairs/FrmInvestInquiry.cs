namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmInvestInquiry : GeneralForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        public FrmInvestInquiry()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }
    }
}
