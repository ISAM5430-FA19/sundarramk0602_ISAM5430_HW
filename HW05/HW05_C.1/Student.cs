using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._1
{
    class Student
    {
        private int student_number;
        private string first_name;
        private string last_name;
        private decimal overall_gpa;
        public string classification;
        public string major;
        
        public Student(int studentno, string firstname, string lastname)
        {
            student_number = studentno;
            first_name = firstname;
            last_name = lastname;
        }

        public Student(decimal gpa, string Major)
        {
            overall_gpa = gpa;
            major = Major;
        }
        public int studentno
        {
            get
            {
                return studentno;
            }
            set
            {
                studentno = value;
            }
        }
        public string firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public decimal gpa
        {
            get
            {
                return overall_gpa;
            }
            set
            {
                overall_gpa = value;
            }
        }
        public string studclassi
        {
            get
            {
                return classification;
            }
            set
            {
                classification = value;
            }
        }
        public string studmajor
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        }
    }

