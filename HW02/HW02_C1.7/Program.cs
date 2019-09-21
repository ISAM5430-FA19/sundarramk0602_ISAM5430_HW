using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            for (letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write($" {letter} ");
            }
            Console.Read();
        }
    }
}
