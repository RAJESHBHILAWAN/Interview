using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class InheritedClass
    {
        InheritedClass()
        {

            clsB clsb = new clsB();
            clsb.MyMethod();
            clsb.clsBMethod();
            clsA clsa = new clsA();
            clsa = clsb;
          
        }
    }
    public class clsB :clsA
    {
        public clsB() { }

        public void clsBMethod()
        {

        }
        public new void A() { }
        public override void B() { }
    }

    public class clsA
    {

        public void A() { }
        public virtual void B() { }

        public void MyMethod()
        {

        }
    }
}
