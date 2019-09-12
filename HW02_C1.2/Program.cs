using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
          for(num=1;num<=10;num++)
            {
                if(num%2==0)
                {
                    Console.Write($" {num} ");
                }
            }
            Console.ReadLine();
        }
    }
}
