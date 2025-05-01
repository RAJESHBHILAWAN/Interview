using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Others
{
    internal class SealedMethods
    {
        public SealedMethods() { }
    }

   public class BaseClass
    {
        public virtual void MyMethod()
        {
            // Base class implementation
        }
    }
    public class DerivedClass : BaseClass
    {
        // This method is sealed, meaning it can’t be overridden again
        public sealed override void MyMethod()
        {
            // Specific implementation for DerivedClass
        }
    }

 public class AnotherDerivedClass : DerivedClass
{
        // This will cause a compile-time error because MyMethod is sealed in DerivedClass
        //public override void MyMethod()
        //{
        //    // This is not allowed
        //}
    }






    ////////////////


}