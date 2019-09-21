using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side3:");
            int num3 = int.Parse(Console.ReadLine());
            while (num1 > 0 && num2 > 0 && num3 > 0)
            {
                if (num1 + num2 > num3)
                {
                    Console.WriteLine("It's a valid triangle");
                }
                else if (num1 + num3 > num2)
                {
                    Console.WriteLine("It's a valid triangle");
                }
                else if (num2 + num3 > num1)
                {
                    Console.WriteLine("It's a valid triangle");
                }
                else
                {
                    Console.WriteLine("Invalid triangle");
                }
                Console.ReadLine();
            }
        }
    }
}
