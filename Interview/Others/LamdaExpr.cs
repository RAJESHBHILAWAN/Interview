using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class LamdaExpr
    {

        public LamdaExpr() {
            delegatelambda();
        }
        delegate void CalculateResult(int x, string y);
        private void x(int x1, string str)
        {
            Console.WriteLine(x1 + " " + str);

        }
        public void delegatelambda()
        {
          int  x1 = 0;
            string str = "Hi";
            CalculateResult expr = (x, str) => {
                 x1 = x1 + 2 * x1;
                Console.WriteLine(x1 + " " + str); 
            };
           // CalculateResult expr1 = x ;
            x1 = 1;
            str = "Adaab";
            expr(x1, str);
            x1 = 2;
             
        }



    }
}
