using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns
{
    internal class BuilderPattern
    {
        //Builder design pattern falls under the category of "Creational" design patterns.
        //This pattern is used to build a complex object by using a step by step approach.
        //“Separate the construction of a complex object from its representation so that
        //the same construction process can create different representations”

        private IToyBuilder _toyBuilder;
        
        public void CreateToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetBody();
            _toyBuilder.SetLegs();
        }
        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
        public BuilderPattern(IToyBuilder toyBuilder) {
            _toyBuilder = toyBuilder;
            MakeToy();
        }

        private void MakeToy()
        {
            Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
            var toyACreator = new BuilderPattern(new ToyABuilder());
            toyACreator.CreateToy();
            toyACreator.GetToy() ;
            var toyBCreator = new BuilderPattern(new ToyBBuilder());
            toyBCreator.CreateToy();
            toyBCreator.GetToy() ;
        }
    }


    public class ToyBBuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY B";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Steel";
        }
        public void SetLegs()
        {
            toy.Legs = "4";
        }
        public Toy GetToy()
        {
            return toy;
        }
    }
    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY A";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Plastic";
        }
        public void SetLegs()
        {
            toy.Legs = "2";
        }
        public Toy GetToy()
        {
            return toy;
        }
    }
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();
        Toy GetToy();
    }
    public class Toy
    {
        public string Model
        {
            get;
            set;
        }
        public string Head
        {
            get;
            set;
        }
        public string Limbs
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
        public string Legs
        {
            get;
            set;
        }
    }
}
