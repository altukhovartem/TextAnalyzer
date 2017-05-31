using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    static class Analizer
    {
        private static Label theFirstCatchedLabel = Label.OK;
        public static Label CheckLabels(TextAnalyzer[] analyzers, string text)
        {

            foreach (var analyzer in analyzers)
            {
                theFirstCatchedLabel = analyzer.ProcessText(text);
                if (theFirstCatchedLabel != Label.OK)
                {
                    break;
                }
            }

            return theFirstCatchedLabel;

        }
    }
}
