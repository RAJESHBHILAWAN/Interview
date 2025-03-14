using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class DelegateMethods
    {



        public DelegateMethods() {
            Process();
        }

        private delegate int DelegateMethod(int x);

        private int Sum(int x)
        {
            int y = 100;
            return y + x;
        }
        private int Mul(int x)
        {
            int y = 100;
            return y * x;
        }

        private void Process() {
            DelegateMethod delegateMethod = Sum;
            Console.WriteLine(delegateMethod(20).ToString());
            delegateMethod = Mul;
            Console.WriteLine(delegateMethod(20).ToString());

        }


    }
}
