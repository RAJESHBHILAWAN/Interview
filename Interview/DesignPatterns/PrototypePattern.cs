using Interview.NotImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns
{
    internal class PrototypePattern
    {
        // This is a creational design pattern that allows you to
        // create new objects by copying existing objects

        //a copy constructor is a language feature that allows creating a new object
        //by copying an existing one of the same class. The prototype pattern, on
        //the other hand, is a design pattern that provides a mechanism to create
        //new objects by cloning existing ones.While both achieve object cloning,
        //the prototype pattern offers more flexibility and can be used with different
        //types of objects, including those with complex internal structures, while a
        //copy constructor is limited to objects of the same class. 

        public PrototypePattern()
        {
            List<string> Options = new List<string>() { "Navigation", "Sunroof" };
            Car car = new Car("Ford", "F1", 2022, Options);
            Car? car1 = car.Clone() as Car;
        }
    }
    public class Car : Prototype
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public List<string> Options { get; set; }
        public Car(string make, string model, int year, List<string> options)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Options = options;

        }

        public override Prototype Clone()
        {
            return new Car(Make, Model, Year, new List<string>(Options));
        }
    }
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

}
