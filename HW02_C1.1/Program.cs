using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            while(num<=20 && num>=1)
            {
                Console.Write($"{ num} ");
                num = num - 1;

            }
            Console.ReadLine();
        }
    }
}
