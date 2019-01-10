namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmInspecInquiry : GeneralForm
    {
        public LetterData FrmLetterData { get; set; }
        public bool FormHasEmptyFields { get; set; }

        public FrmInspecInquiry()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
        }
    }
}
