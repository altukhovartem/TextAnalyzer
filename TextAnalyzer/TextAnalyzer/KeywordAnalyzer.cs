using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    public abstract class KeywordAnalyzer: TextAnalyzer
    {
        protected abstract List<string> Keywords { get; }
        protected abstract Label Label { get; }
    }
}
