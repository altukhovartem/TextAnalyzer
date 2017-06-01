using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class NegativeTextAnalyzer: KeywordAnalyzer
    {

        List<string> listOfSmiles = null;

        protected override List<string> Keywords
        {
            get
            {
                return listOfSmiles;
            }
        }

        protected override Label Label
        {
            get
            {
                return Label.NEGATIVE_TEXT;
            }
        }

        public NegativeTextAnalyzer()
        {
            listOfSmiles = new List<string> { ":(", "=(", ":|" };
        }

        
    }
}
