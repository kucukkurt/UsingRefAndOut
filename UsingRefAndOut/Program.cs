using System;

namespace UsingRefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double _i = 10;
            double a = 5.179, f;

            UsingRef usingRef = new UsingRef();
            UsingOut usingOut = new UsingOut();

           Console.WriteLine("i value before the ref method : "+ _i.ToString());

            usingRef.GetSquare(ref _i);

            Console.WriteLine("i value after the ref method :" + _i.ToString());

            Console.WriteLine("*******************************************");

            Console.WriteLine("Before Out method : {0}", a);

            usingOut.GetValue(ref a, out f);

            Console.WriteLine("After Out method : {0}----{1}", a, f);


        }
    }
}
