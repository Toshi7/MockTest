using System;
using System.Collections.Generic;
using System.Text;

namespace MockTest
{
    public class CalcViewModel : ViewModelBase 
    {

        public CalcViewModel(ICalc calc) : base (calc)
        {
        }
        public int DoCalculation(int x, int y)
        {
            SuperClassMethod();
            return _calc.Add(x,y);
        }
    }
}
