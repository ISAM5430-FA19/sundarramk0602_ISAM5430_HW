using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW03_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            while (num > max)
            {
                max = num;
                Console.WriteLine("Enter another number:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Largest number is: {max}");
            Console.ReadLine();
        }
    }
}
