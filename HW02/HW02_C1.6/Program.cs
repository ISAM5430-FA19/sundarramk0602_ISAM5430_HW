using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                if (num % 3 != 0 && num % 5 != 0 || (num % 3 == 0 && num % 5 == 0))
                {
                    Console.Write($" {num} ");
                }
                num = num + 1;
            }
            Console.Read();
        }
    }
}
