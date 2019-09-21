using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter item:");
            int item = int.Parse(Console.ReadLine());
            int distance = 0;
            int closestnum = 0;
            int smallest = int.MaxValue;
            Console.WriteLine("Enter numbers:");
            int num = int.Parse(Console.ReadLine());
            while (num != item)
            {
                if (item > num)
                {
                    distance = item - num;
                }
                else
                {
                    distance = num - item;
                }
                if (distance < smallest)
                {
                    smallest = distance;
                    closestnum = num;
                }
                Console.WriteLine($"Closest: {closestnum}");
                Console.ReadLine();
            }
        }
    }
}