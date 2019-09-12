using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int num = 0;
            int positive = 0;
            int zero = 0;
            int even = 0;
            int smallest = int.MaxValue;
            int largest = int.MinValue;
            int firsthalf = 0;
            int secondhalf = 0;
            int sum = 0;
            while (i < count)
            {
                Console.WriteLine($"Enter the number {i + 1}");
                num = Convert.ToInt32(Console.ReadLine());

                // positive
                if (num > 0)
                {
                    positive++;
                }
                //zeros
                if (num == 0)
                {
                    zero++;
                }
                //even
                if (even % 2 == 0)
                {
                    even++;
                }
                //smallest and largest
                if (num < smallest)
                {
                    smallest = num;
                }
                if (num > largest)
                {
                    largest = num;
                }
                //first half and second half
               /* if (i == 1)
                {
                firsthalf = num;
                } */
                

              i++;
            }
            Console.WriteLine($"Number of positive numbers: {positive}");
            Console.WriteLine($"Number of zeros: {zero}");
            Console.WriteLine($"Number of even numbers: {even}");
            Console.WriteLine($"Number of smallest numbers: {smallest}");
            Console.WriteLine($"Number of largest numbers: {largest}");
            
            Console.ReadLine(); 
        }
    }
}
