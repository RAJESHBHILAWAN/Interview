using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns
{
    internal class PrototypePattern
    {
        // This is a creational design pattern that allows you to
        // create new objects by copying existing objects
      
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
     public Car(string make, string model, int year, List<string> options) {
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
