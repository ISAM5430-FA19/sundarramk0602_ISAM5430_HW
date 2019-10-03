using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_B1.C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two numbers");
            int sum = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        sum =sum + i * j;
                        Console.Write(i + " * " + j + " + ");
                    }
                }
            }

            Console.WriteLine("Three numbers");
            int sumthree = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {
                        if (i != j && j != k && i != k)
                        {
                            sumthree = i * j * k;
                           // Console.WriteLine($"{sum}");
                            Console.Write(i + " * " + j + " * " + k + " + " );
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
