using System;
using System.Collections.Generic;
using System.Text;

namespace UsingRefAndOut
{
    class UsingOut
    {

        public void GetValue(ref double a,out double franc)
        {
            int _temp;

            _temp = (int) a;

            franc = a - _temp;


        }
    }
}
