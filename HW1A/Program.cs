using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 =>");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 =>");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator =>");
            string oper = Console.ReadLine();
            if(oper == "+")
            {
                int sum = num1 + num2;
                Console.WriteLine($"The Sum of two numbers: {sum}");
            }

            if (oper == "-")
            {
                int subtraction = num1 - num2;
                Console.WriteLine($"The difference of two numbers: {subtraction}");
            }
            if(oper == "*")
            {
                int multiply = num1 * num2;
                Console.WriteLine($"The product of two numbers: {multiply}");
            }
            if (oper == "/")
            {
                int division = num1 / num2;
                Console.WriteLine($"The division of two numbers: {division}");
            }
            Console.ReadLine();
        }
    }
}
