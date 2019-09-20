using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW03_B7
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter positive numbers:");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int n = num % 10;
                reverse = (reverse * 10) + n;
                num = num / 10;
            }
            Console.WriteLine($"Reverse number: {reverse}");
            Console.ReadLine(); 
         }
    }

}
