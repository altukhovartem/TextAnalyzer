using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class SpamAnalyzer: KeywordAnalyzer
    { 
        protected override List<string> Keywords
        {
            get
            {
                return base.Keywords;
            }
        }

        protected override Label Label
        {
            get
            {
                return Label.SPAM;
            }
        }

        public SpamAnalyzer(List<string> listOfKeywords)
        {
            
        }
    }
}
