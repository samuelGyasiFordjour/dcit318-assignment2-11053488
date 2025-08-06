using System;
using InterfaceDemo.Models;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call Move() method on each instance
            car.Move();
            bicycle.Move();
        }
    }
}
