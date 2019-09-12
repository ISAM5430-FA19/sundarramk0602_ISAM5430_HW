using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num < 20 )
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    Console.Write($" {num} ");
                }
                num++;
            }
            Console.ReadLine();
        }
    }
}
