using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static void Add(int num1, int num2, bool trueOrFalse)
        {
            var sum = num1 + num2;
            if (trueOrFalse && sum == 0)
            {
                Console.WriteLine($"{sum} means you are broke");
            }
            else if (trueOrFalse == true && sum == 1)
            {
                Console.WriteLine($" Congrats on {sum} dollar");
            }
            else
            {
                Console.WriteLine($"{sum} dollars is more than 1");
            }
        }
    }
}
 
