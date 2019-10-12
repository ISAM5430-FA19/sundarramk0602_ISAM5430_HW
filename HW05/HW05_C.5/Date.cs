using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._5
{
    class Date
    {
        public int _month;
        public int _day;
        public int _year;

        public Date(int month, int day, int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
            }
        }

        public int Days
        {
            get
            {
                return _day;
            }
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            
        }

        public string DisplayDate()
        {
            return ($"{_month} / {_day} / {_year}");
          
        }
    }
}
