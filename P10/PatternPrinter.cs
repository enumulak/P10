using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    public class PatternPrinter
    {
        private string inputStatus;

        
        public void PrintOnesPattern(int n)
        {
            if (n > 0)
            {
                inputStatus = "Valid Input";

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("1");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine("-1");
                    }
                }
            }
            else
            {
                inputStatus = "Invalid Input";

                Console.WriteLine(inputStatus);
            }
        }

        public string GetInputStatusMessage() => inputStatus;
    }
}
