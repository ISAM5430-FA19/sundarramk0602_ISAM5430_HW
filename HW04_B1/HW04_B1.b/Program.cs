using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04_B1.b
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    for(int k=1; k<=5; k++)
                    {
                        if (i!= j && j!= k && i!=k)
                        {
                            Console.Write(i + "," + j + "," + k + ";");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
