using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.WriteLine($"{j}");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
