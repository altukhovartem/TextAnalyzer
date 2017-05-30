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
            Analizer.CheckLbels();

            TextAnalyzer test = new NegativeTextAnalyzer();
            Console.WriteLine(test.ProcessText("qweqweqwe : (asd"));
        }
    }
}
