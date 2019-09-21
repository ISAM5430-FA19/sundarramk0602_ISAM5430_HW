using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num<10)
            {
                int input = (int)Math.Pow(num, 2);

                if(input>=10 && input<=100)
                {
                    Console.Write($" {input} ");
                }
                num++;
            }
            Console.ReadLine();
        }
    }
}
