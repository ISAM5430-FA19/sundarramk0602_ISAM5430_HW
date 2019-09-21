using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                count = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadLine();
        }
    }
}
