using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW03_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int prev = 0;
            while (num != prev)
            {
                prev = num;
                sum = sum + num;
                Console.WriteLine("Enter another number:");
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Sum is:{sum}");
            Console.ReadLine();

        }
    }
}
