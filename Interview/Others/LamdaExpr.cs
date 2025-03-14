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
        public void delegatelambda()
        {
          int  x1 = 0;
            string str = "Hi";
            CalculateResult expr = (x, str) => {
                Console.WriteLine(x1 + " " + str); };
            x1 = 1;
            str = "Adaab";
            expr(x1, str);
            x1 = 2;
             
        }



    }
}
