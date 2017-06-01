using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class SpamAnalyzer: KeywordAnalyzer
    {
        private List<string> listOfSpamWords = null;

        protected override List<string> Keywords
        {
            get
            {
                return listOfSpamWords;
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
            listOfSpamWords = listOfKeywords;
        }
    }
}
