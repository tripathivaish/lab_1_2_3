using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Abstract method for making a sound
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed)
            : base(name, age)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Breed} barks.");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} fetches a ball.");
        }
    }

    class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat(string name, int age, bool isLazy)
            : base(name, age)
        {
            IsLazy = isLazy;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the cat meows.");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} the cat scratches the furniture.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 3, "Golden Retriever");
            Cat cat = new Cat("Whiskers", 2, true);

            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Fetch();

            Console.WriteLine($"{cat.Name} is {cat.Age} years old.");
            cat.MakeSound();
            cat.Scratch();
            Console.ReadKey();
        }
    }
}
