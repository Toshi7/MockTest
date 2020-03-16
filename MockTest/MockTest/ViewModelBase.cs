using System;
using System.Collections.Generic;
using System.Text;

namespace MockTest
{
    public class ViewModelBase
    {
        protected ICalc _calc;
        public ViewModelBase(ICalc calc)
        {
            _calc = calc;
        }
        public void SuperClassMethod()
        {
            _calc.Add(1, 2);
        }
    }
}
