using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class NegativeTextAnalyzer: KeywordAnalyzer
    {

        List<string> listOfSmiles = new List<string> { ":(", "=(", ":|" };
        bool smileExist = false;

        public NegativeTextAnalyzer()
        {

        }

        public Label ProcessText(string text)
        {
            foreach (string smile in listOfSmiles)
            {
                if (text.Contains(smile))
                {
                    smileExist = true;
                }
            }

            if (smileExist)
            {
                return Label.NEGATIVE_TEXT;
            }
            else
            {
                return Label.OK;
            }
        }
    }
}
