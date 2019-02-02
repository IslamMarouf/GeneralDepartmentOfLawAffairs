namespace GeneralDepartmentOfLawAffairs
{
    public partial class FrmRegularNote : GeneralForm
    {
        public bool FormHasEmptyFeilds { get; set; }
        public LetterData FrmLetterData { get; set; }

        public FrmRegularNote()
        {
            InitializeComponent();
            FrmLetterData = new LetterData();
            FormHasEmptyFeilds = false;
        }
    }
}
