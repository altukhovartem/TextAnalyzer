using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class TooLongTextAnalyzer : TextAnalyzer
    {
        private int maxLength = 0;

        public TooLongTextAnalyzer(int currentMaxLenth)
        {
            maxLength = currentMaxLenth;
        }

        public Label ProcessText(string text)
        {
            if (text.Length > maxLength)
            {
                return Label.TOO_LONG;
            }
            else
            {
                return Label.OK;
            }
        }
    }
}
