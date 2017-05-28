using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    interface TextAnalyzer
    {
        Label ProcessText(String text);
    }

    enum Label
    {
        SPAM, NEGATIVE_TEXT, TOO_LONG, OK
    }

}
