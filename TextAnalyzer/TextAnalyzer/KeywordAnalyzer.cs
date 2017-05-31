using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public abstract class KeywordAnalyzer: TextAnalyzer
    {
        //string listOfKeywords;
        bool existedKeyword = false;


        protected abstract List<string> Keywords { get; }
        protected abstract Label Label { get; }

        public Label ProcessText(string text)
        {
            foreach (string keyword in Keywords)
            {
                if (text.Contains(keyword))
                {
                    existedKeyword = true;
                }
            }

            if (existedKeyword)
            {
                return Label;
            }
            else
            {
                return Label.OK;
            }
        }
    }
}
