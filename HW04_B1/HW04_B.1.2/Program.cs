using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW04_B._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sumthree = 0;
            int sumfour = 0;
            int sumfive = 0;
            WriteLine("two numbers");

            for(int i=1; i<=5; i++)
            {
                for(int j=i+1; j<=5; j++)
                {
                        sum = sum + i * j;
                    Write(sum + i + " * " + j + " + ");                 
                        }
                }
            

            WriteLine("three numbers");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        if (i != j && j!=k && k!=i)
                        {
                            sumthree = sumthree + i * j * k;
                            Write(i + " * " + j + " * " + k + " + ");
                        }
                    }
                }
            }

            WriteLine("four numbers");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {
                            if (i != j && j != k && k != i && l != i && l != k && l!=j)
                            {
                                sumfour = sumfour + i * j * k * l;
                                Write(i + " * " + j + " * " + k + " * " + l + " + ");
                            }
                        }
                    }
                }
            }

            WriteLine("five numbers");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {
                            for (int m = l + 1; m <= 5; m++)
                            {
                                if (i != j && j != k && k != i && l != i && l != k && l != j && m != i && m != j && m != k && m != l)
                                {
                                    sumfive = sumfive + i * j * k * l * m;
                                    Write(i + " * " + j + " * " + k + " * " + l + " * " + m + " + ");
                                }
                            }
                        }
                    }
                }
            }
            ReadLine();
        }
    }
}
