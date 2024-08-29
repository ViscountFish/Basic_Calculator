using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator");
            Console.WriteLine();

            Console.Write("Enter Your first number: ");
            string firstNumberInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberInput);

            Console.Write("Enter Your your operator: "); // + - / *
            string operatorInput = Console.ReadLine();

            Console.WriteLine.("Now choose your operator ");
            Console.WriteLine.("1. plus (+)");
            Console.WriteLine.("2. minus (-)");
            Console.WriteLine.("3. divide (/)");
            Console.WriteLine.("4. multiply (*)" + Environment.NewLine);

            double result = 0.0; 
            
            if (operatorInput.Contains("+"))
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorInput.Contains("-"))
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorInput.Contains("/"))
            {
                result = firstNumber / secondNumber;
            }
            else if (operatorInput.Contains("*"))
            {
                result = firstNumber * secondNumber;
            }

            Console.WriteLine("The result of " + firstNumber + " " + operatorInput + " " + secondNumber + " is: " + result);

            Console.ReadLine ();
        }
    }
}
