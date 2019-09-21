using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
            {
                Console.WriteLine($"The middle number is {num1}");
            }
            else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num1 < num2))
            {
                Console.WriteLine($"The middle number is {num2}");
            }
            else
            {
                Console.WriteLine($"The middle number is {num3}");
            }
            Console.ReadLine();
        }
    }
}

