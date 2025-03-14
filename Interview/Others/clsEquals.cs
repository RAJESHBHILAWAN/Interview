using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Others
{
    public class clsEquals
    {
        public clsEquals() { ImplementMethod(); }


        private void ImplementMethod()
        {
            string msg = "Sandeep";
            string msg1 = msg;

            Console.WriteLine($"msg and msg1 with string == {msg1 == msg}");
            Console.WriteLine($"msg and msg1 with string Equals { msg1.Equals(msg) }");

            char[] chars = { 'S', 'a', 'n', 'd', 'e', 'e', 'p' };
            Console.WriteLine($"msg and msg1 with chars Equals {msg1.Equals(chars)}");






        }


    }
}
