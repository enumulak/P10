using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            PatternPrinter pp = new PatternPrinter();

            pp.PrintOnesPattern(n);

            Console.ReadLine();
        }

        
    }
}
