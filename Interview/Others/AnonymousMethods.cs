using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class AnonymousMethods
    {


        public AnonymousMethods()
        {
            //MyAnon();
            //AnonFunc();
            //AnonAction();
            //AnonSelect();
         
        }

        delegate void CalculateResult(int x);

        private void MyAnon()
        {
            int x = 0;
            CalculateResult calculateResult = delegate (int x) { Console.WriteLine(x); };
            x = 1;
            calculateResult(x);

        }

        private void AnonFunc()
        {
            Func<int, int> func = x => x * x;
            Console.WriteLine(func(2));
        }
        private void AnonAction()
        {
            Action<int> action = x => { Console.WriteLine(x * x); };
            action(4);
            Action<int, int> action1 = (x, y) => { Console.WriteLine(x * y); };
            action1(2, 3);

        }
        private void AnonSelect()
        {
            int[] ints = { 1, 2, 3 };
            var squarednumbers = ints.Select(x => x * x);
            Console.WriteLine(string.Join(" , ", squarednumbers));
        }

       
    }
      
}
