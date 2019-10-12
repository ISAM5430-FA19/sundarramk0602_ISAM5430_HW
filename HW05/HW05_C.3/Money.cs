using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._3
{
    class Money
    {
        public int _dollars;
        public int _cents;

        public Money(decimal money)
        {
            _dollars = (int)(money);
            _cents = (int)((money - _dollars) * 100);
        }

        public Money(int dollar, int cent)
        {
            _dollars = dollar;
            _cents = cent;
        }

        public void IncrementMoney( int D, int C)
        {
            _dollars = _dollars + D;
            _cents = _cents + C;
        }

        public void DecrementMoney(int D, int C)
        {
            _dollars = _dollars - D;
            _cents = _cents - D;
        }

        public override string ToString()
        {
            return ("$"+ _dollars + _cents);
        }
    }
}
