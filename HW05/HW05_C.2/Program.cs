using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the motor name");
            string motorname = Console.ReadLine();
            Console.WriteLine("Enter the motor type");
            string motortype = Console.ReadLine();
            Console.WriteLine("Enter the direction");
            char direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the surface");
            string surface = Console.ReadLine();
            Console.WriteLine("Enter the number of Lanes");
            int numberofLanes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter whether toll or no toll");
            string tollornot = Console.ReadLine();
            Console.WriteLine("Enter the party");
            string party = Console.ReadLine();

            Motorway motor = new Motorway(motorname, motortype, direction, surface, numberofLanes, tollornot, party);

            Console.WriteLine("Motor Name:" + motor.MotorName());
            Console.WriteLine("Toll Or Not:" + motor.NameandTollornot());
            Console.WriteLine("Number of Lanes:" + motor.NameandLanes());

            Console.ReadLine();
        }
    }
}
