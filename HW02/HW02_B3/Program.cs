using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade:");
            decimal grade = decimal.Parse(Console.ReadLine());
            decimal gpa = (int)(3 * gpa + 0.5m);
            int num = 0;
            string lettergrade = "";
            if(grade >=0 && grade<=4)
            {
                Console.WriteLine("Invalid gpa");
            }
            if (num==0)
            {
                if (gpa > 10)
                {
                    lettergrade = "A";
                }
                else if (gpa < 12)
                {
                    lettergrade += "-";
                }
                else if (gpa > 7)
                {
                    lettergrade = "B";
                }
                else if (gpa < 9)
                {
                    lettergrade += "-";
                }
                else if (gpa > 4)
                {
                    lettergrade = "C";
                }
                else if (gpa < 6)
                {
                    lettergrade += "-";
                }
                else if (gpa>2)
                {
                    lettergrade = "D";
                }
                else
                {
                    lettergrade = "F";
                }
                Console.WriteLine($"Grade: {lettergrade}");
            }
            Console.ReadLine();
        }
    }
}
