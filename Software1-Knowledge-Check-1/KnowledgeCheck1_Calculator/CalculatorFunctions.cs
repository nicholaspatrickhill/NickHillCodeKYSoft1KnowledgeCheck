using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class CalculatorFunctions
    {
        public static void PrintError()
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }
        public static bool UserNumbers(string CalcFunction, out int num1, out int num2)
        {
            Console.WriteLine("Enter 2 integers to" + CalcFunction);
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int num1Temp) && int.TryParse(number2, out int num2Temp))
            {
                num1 = num1Temp;
                num2 = num2Temp;
                return true;

            }
            else
            {
                CalculatorFunctions.PrintError();
                num1 = 0;
                num2 = 0;
                return false;   
            }
        }
    }
}
