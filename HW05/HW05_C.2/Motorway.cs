using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW05_C._2
{
    class Motorway
    {
        private string _name;
        private string _type;
        private char _direction;
        private string _surface;
        private int _numofLanes;
        private string _tollornot;
        private string _party;

        public Motorway(string motorname, string motortype, char direction, string surface, int lanes, string tollornot, string party)
        {
            _name = motorname;
            _type = motortype;
            _direction = direction;
            _surface = surface;
            _numofLanes = lanes;
            _tollornot = tollornot;
            _party = party;
        }

        public string fullname
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string motortype
        {
            get
            {
                return _type;
            }
            set
            {
                if(value =="Road" || value=="Street" || value=="Avenue" || value=="Lane")
                _type = value;
            }
        }
        public char direction
        {
            get
            {
                return _direction;
            }
            set
            {
               if (value == 'N' || value == 'S' || value == 'E' || value == 'W')
                    _direction = value;


            }
        }
        public string surface
        {
            get
            {
                return _surface;
            }
            set
            {
                if (value == "blacktop" || value == "gravel" || value == "sand" || value == "concrete")
                    _surface = value;
            }
        }
        
        public string Toll
        {
            get
            {
                return _tollornot;
            }
            set
            {
                if (value == "Toll" || value == "Not Toll")
                    _tollornot = value;
            }

        } 
        public int NumberofLanes
        {
            get
            {
                return _numofLanes;
            }
            set
            {
                if (value >= 0)
                    _numofLanes = value;
            }
        }
        public string party
        {
            get
            {
                return _party;
            }
        }

        public string MotorName()
        {
            return _name;
        }
        public string NameandTollornot()
        {
            return _name + '\n' + _tollornot;
        }
        public string NameandLanes()
        {
            return _name + '\n' +_numofLanes;
        }
        public override string ToString()
        {
            return _name + _type + _direction + _surface + _tollornot + _numofLanes + _party;
        }
        
    }
}
