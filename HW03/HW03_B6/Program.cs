using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int min = int.MaxValue;
            string value = "";
            while (num > 0)
            {
                count++;
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                else if (min * min < num)
                {
                    value = value + num + " | ";

                    Console.WriteLine($"Count: {count}");
                    Console.WriteLine($"Display: {value}");

                    Console.WriteLine("Enter new numbers: ");
                    num = 1;
                    count = 0;
                    min = int.MaxValue;
                }
                if (count != 0)
                {
                    value = value + num + ", ";
                }
            }
            Console.WriteLine($"Display:{ value}");
            Console.ReadLine();
        }
    }
}

