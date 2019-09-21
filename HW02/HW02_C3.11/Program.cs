using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int factorial = 1;
            while (num < 10)
            {
                factorial = factorial * num;
                if (factorial <= 1000)
                    Console.Write($" {factorial} ");
                    num++;
            }
                Console.ReadLine();
        }
    }
}
