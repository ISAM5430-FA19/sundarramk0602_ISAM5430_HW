using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW04_B1
{
    class Program
    {
        static void Main(string[] args)
        {
          // int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                       Console.Write( i + "," + j + ";");
                    }
                }
            }
            ReadLine();
        }
    }

}