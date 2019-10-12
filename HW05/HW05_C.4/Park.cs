using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW05_C._4
{
    class Park
    {
        private string _name { get; set;}
        private string _location { get; set;}
        private string _type;
        private int _fee { get; set; }
        private int _employee { get; set; }
        private int _visitor { get; set; }
        private decimal _budget { get; set; }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value=="national" || value=="state" || value=="local")
                    _type = value;
            }
        }

        public Park(string name, string location, string type, int fee, int employee, int visitor, decimal budget)
        {
            _name = name;
            _location = location;
            _type = type;
            _fee = fee;
            _employee = employee;
            _visitor = visitor;
            _budget = budget;
        }

        public string NameLocType()
        {
            return ("Park name" + _name + "Location" + _location + "Type" + _type);
        }
        public string NameLocFac()
        {
            return ("Park name" + _name + "Location" + _location + "Facilities" + _type);
        }
        public int computecost()
        {
            return (int)_budget * _visitor;
        }
        public int computerevenue()
        {
            return _visitor * _fee;
        }
        public override string ToString()
        {
            return ($"{_name} {_type} {_location} {_fee} {_employee} {_visitor} {_budget}");
        }
    }
}

