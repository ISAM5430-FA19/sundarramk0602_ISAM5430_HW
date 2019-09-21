using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int avg = 0;
            int total = 0;
            int sum = 0;
            int max = int.MinValue;
            Console.WriteLine("Enter score:");
            int num = int.Parse(Console.ReadLine());
            while (num > 0 && num <= 100)
            {
                sum = sum + num;
                total++;
                if (num > max)
                {
                    max = num;
                }
                Console.WriteLine("Enter another score:");
                num = int.Parse(Console.ReadLine());
            }
            if (total > 0)
            {
                avg = sum / total;
                Console.WriteLine($"Average: {avg}");
                Console.WriteLine($"Best Score: {max}");
            }
            else if (num > 100)
            {
                Console.WriteLine("Enter a valid score");
            }
            else
            {
                Console.WriteLine("Enter a valid score");
            }
            Console.ReadLine();
        }
    }
}

