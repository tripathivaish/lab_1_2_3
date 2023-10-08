using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    sealed class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.Drive();
            car.StopEngine();


        }
    }
}

