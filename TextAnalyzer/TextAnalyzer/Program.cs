using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer[] listOfAnalyzers = new TextAnalyzer[]
            {
                new NegativeTextAnalyzer(),
                new SpamAnalyzer(new List<string>() {"idi", "suda", "govno", "sobachye" }),
                new TooLongTextAnalyzer(10)
            };

            Label currentLabel = Analizer.CheckLabels(listOfAnalyzers, "11111111111111111111111govno");
            Console.WriteLine(currentLabel);
        }
    }
}
