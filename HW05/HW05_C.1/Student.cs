using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._1
{
    class Student
    {
        public int student_number;
        public string first_name;
        public string last_name;
        public double overall_gpa;
        public string classification;
        public string major;
        
        public Student(int studentno)
        {
            student_number = studentno;
        }
        public Student(string firstname, string lastname)
        {
            
            first_name = firstname;
            last_name = lastname;
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
        public double gpa
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

