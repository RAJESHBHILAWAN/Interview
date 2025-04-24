using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interview.Others
{
    
    internal class AspecctOrientedProgramming
    {
        
        public AspecctOrientedProgramming() {

            Add();
        
        }

        
        public void Add()
        {
          
            Type clazz = typeof(MyClass);
            Object[] atts = clazz.GetCustomAttributes(typeof(FixMeAttribute), false);

            foreach (FixMeAttribute att in atts)
            {
                System.Console.WriteLine("You should fix '" + clazz.FullName + "' : " + att.Value);
            }

            Console.ReadKey();
        }


    }

    [FixMe("Incorporate 4.0 features")]
    class MyClass
    {
    }
   // [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public sealed class FixMeAttribute : Attribute
    {
        public string Value { get; set; }

        public FixMeAttribute() { }

        public FixMeAttribute(string value)
        {
            Value = value;
            Console.WriteLine("Hi");
        }
    }
}
