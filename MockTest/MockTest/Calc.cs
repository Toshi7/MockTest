using System;
using System.Collections.Generic;
using System.Text;

namespace MockTest
{
    public class Calc : ICalc
    {
        protected ICalc _calc;
        public Calc(ICalc calc)
        {
            _calc = calc;
        }

        public int Add(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
