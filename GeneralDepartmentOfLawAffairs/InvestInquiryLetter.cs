using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GeneralDepartmentOfLawAffairs
{
    class InvestInquiryLetter : Letter
    {
        private readonly Document _doc;
        private DialogResult _dialogResult;
        private LetterData _letterData;

        public InvestInquiryLetter(Document doc) : base(doc)
        {
            _doc = doc;
        }

        public override void Write() {
            if (Initialize())
            {
                LetterSections();
            }
        }

        protected override bool Initialize()
        {
            FrmInvestInquiry frminvestquiry = new FrmInvestInquiry();
            _dialogResult = frminvestquiry.ShowDialog();
            _letterData = frminvestquiry.FrmLetterData;

            return (_dialogResult == DialogResult.OK) && !frminvestquiry.FormHasEmptyFields;
        }

        protected override void HeadingSection() {
            base.HeadingSection();
        }

        protected override void BodySection()
        {
            
        }

        protected override void DirectionSection()
        {
            
        }

        protected override void RequestSection()
        {
            
        }
    }
}
