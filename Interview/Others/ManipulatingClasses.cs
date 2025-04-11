using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Interview.Others
{
    internal class ManipulatingClasses
    {
        public ManipulatingClasses() {
            //GetPrivateClassInstance();
            //CreateGeneric();
            OverloadedIndexer();
        }
        private void OverloadedIndexer()
        {
            OverloadedIndexers o  = new OverloadedIndexers();
            o[0] = "Raj";
            o[1] = "Kumar";
            o[2] = "Verma";
            for  (int i = 0; i<= 2; i++) { 
                Console.WriteLine(o[i]);
            }

            Console.WriteLine(o["Verma"] );
        }
        private void CreateGeneric()
        {
            GenericStudent<int> student = new GenericStudent<int>();
            student.Value = 1;
            student.WriteData();
            GenericStudent<string> strstudent = new GenericStudent<string>();
            strstudent.Value = "R001";
            strstudent.WriteData();

        }


        private void GetPrivateClassInstance()
        {
            Type type = typeof(Foo);
            Foo? foo = (Foo?)Activator.CreateInstance(type, true);
            foo?.WriteOnceBlock();

        }    

    }



    public class Foo
    {
        private Foo() { }

        public void WriteOnceBlock()
        {
            Console.WriteLine("Hi!");
        }
    }

    public class GenericStudent<T>
    {
        public T Value { get; set; }

        public void WriteData()
        {
            Console.WriteLine($"Roll Number is {Value}");
        }
    }


    public class OverloadedIndexers
    {
        public int maxsize = 10;
        public string[] name = new string[10];

        public string this[int index]
        {
            get { return name[index];  }
            set { name[index] = value; }
        }

        public int this[string nm]
        {
            get
            {
                int index = 0;
                while (index < maxsize)
                {
                    if (name[index] == nm)
                    {
                        return index;
                    }
                    index++;
                }


                return index;
            }
        }
    }



}
