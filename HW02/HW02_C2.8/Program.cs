using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int prev = 1;
            while (num < 10)
            {
                prev = prev * 2;
                if (prev > 0 && prev <= 100)
                    Console.Write($" {prev} ");
                num++;
            }
                Console.ReadLine();
            }
        }
    }

