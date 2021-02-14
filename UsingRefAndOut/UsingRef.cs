using System;
using System.Collections.Generic;
using System.Text;

namespace UsingRefAndOut
{
    class UsingRef
    {
        public void GetSquare(ref double a)
        {
            a = 20;
            a = a * a;
        }
    }
}
