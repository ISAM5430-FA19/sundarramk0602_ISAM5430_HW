using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int prev = 0;
            int preprev = 1;
            while(num < 25)
            {
                int next = prev + preprev;
                prev = preprev;
                preprev = next;
                Console.Write($" {next} ");
                num++;
            }
            Console.ReadLine();
        }
    }  
}
