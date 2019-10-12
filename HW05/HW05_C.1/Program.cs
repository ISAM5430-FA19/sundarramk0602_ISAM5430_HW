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
            Console.WriteLine("Enter the student number");
            int studid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the student last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the student gpa");
            decimal gpa = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student classification");
            string studclassi = Console.ReadLine();
            Console.WriteLine("Enter the student major");
            string studmaj = Console.ReadLine();
            Student student = new Student(studid,fname,lname);

            Console.WriteLine("Student Name:" + student.firstname + student.lastname);
            Console.WriteLine(" Student GPA:" + student.gpa);

            Console.ReadLine();

        }
    }
}
