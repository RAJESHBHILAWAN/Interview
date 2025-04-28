using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.NotImp
{
    internal class Abstractclass
    {
        public Abstractclass()
        {
            Animal[] animals = new Animal[] { new Cat(), new Dog() };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
                animal.Move();
            }
        }



    }


    // C# program to demonstrates the 
// working of abstract classses
 
public abstract class Animal
    {
        public abstract string Sound { get; }

        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
    }

    public class Cat : Animal
    {
        public override string Sound => "Meow";

        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
    }

    public class Dog : Animal
    {
        public override string Sound => "Woof";

        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
    }
}
