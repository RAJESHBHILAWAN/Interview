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
            //AnonymousMethod();
            //AnonFunc();
            //AnonAction();
            //AnonSelect();
             MyPredicate1();
            //MyEvent();
           // MyClosure();
        }

        delegate void CalculateResult(int x);
        delegate void CalculateResult1();

        private void AnonymousMethod()
        {
            int x = 0;
            CalculateResult calculateResult = delegate (int x) { Console.WriteLine(x); };
            x = 1;
            calculateResult(x);
            CalculateResult1 calculateResult1 = delegate { Console.WriteLine(x); };
            calculateResult1();
        }

        private void MyClosure()
        {
            int x = 0;
            Action a = delegate { Console.WriteLine(x); };
            x = 1;
            a();
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
        delegate void Action();
       
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        private void MyPredicate()
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);

        }
        private void MyPredicate1()
        {
            int number = 4;
            Predicate<int> isEven = (a) => number % 2 == 0;
            Console.WriteLine($"Is {number} even: {isEven(number)}" );

        }

      



    }




 
}
