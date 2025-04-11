using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Others
{
    internal class FuncAndAction
    {
      public  FuncAndAction() { Process(); }

        
        private void Process()
        {
            Func<int, int, int> func = Multi;
           int res = func(12, 2);
            Console.WriteLine(res);
            Action<int,int> action = Sum;
            Sum(12, 4);
        }
        private int Multi(int x , int y)
        {
            return x * y;
        }
        private void Sum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }

    }
}
