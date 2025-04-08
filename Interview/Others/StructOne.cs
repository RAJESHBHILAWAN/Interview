using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal struct StructOne
    {
        public StructOne(string str) { }
        public StructOne()
        {

            Calc calc = Sum;
            Console.WriteLine(calc(2, 3));
            Action<int, int> A = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            A(2, 3);
            Func<int, int> func = (x) => { return x + x; };
            Console.WriteLine(func(2));
        }
        private int Sum(int x, int y)
        {
            return x + y;
        }
        private delegate int Calc(int x, int y);




    }
}
