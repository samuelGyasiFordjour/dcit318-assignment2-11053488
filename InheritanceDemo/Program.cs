using System;
using InheritanceDemo.Models;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() method on each instance
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
