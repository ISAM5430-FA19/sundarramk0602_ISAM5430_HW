using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(0);
            Console.WriteLine("Enter the student number");
            int studid = int.Parse(Console.ReadLine());
            student.student_number = studid;
            Console.WriteLine("Enter the student first name");
            string fname = Console.ReadLine();
            student.first_name = fname;
            Console.WriteLine("Enter the student last name");
            string lname = Console.ReadLine();
            student.last_name = lname;
            Console.WriteLine("Enter the student gpa");
            double gpa = double.Parse(Console.ReadLine());
            student.overall_gpa = gpa;
            Console.WriteLine("Enter the student classification");
            string studclassi = Console.ReadLine();
            student.classification = studclassi;
            Console.WriteLine("Enter the student major");
            string studmaj = Console.ReadLine();
            student.major = studmaj;

            Console.ReadLine();

        }
    }
}
