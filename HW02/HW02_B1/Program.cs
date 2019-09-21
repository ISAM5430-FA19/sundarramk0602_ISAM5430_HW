using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First number is the largest number");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("second number is the largest number");
            }
            else
            {
                Console.WriteLine("Both the numbers are same");
            }
            Console.ReadLine();
        }
    }
}
