using System;
using System.Dynamic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCreator();
            Console.ReadKey();
        }
        public static void CarCreator()
        {
            Car car = new Car("Honda", 2017,"OAX-201");
            Car car2 = new Car(); // går på den tomma konstruktorn
            Console.WriteLine($"Model: {car.model} | Year: {car.year} | Age of vehicle: {car.age} år {(car.age < 5 ?" Ny":"gammal")}");
           
        }
    }

    class Car
    {
        public string model;
        public int year;
        public int age;
        private string licenseplate;

        public Car(string modelName, int modelYear, string licenseplateNum)
        {
            model = modelName;
            year = modelYear;
            age = 2020 - modelYear;
            licenseplate = licenseplateNum;
        }
        public Car()
        {

        }

    }
}
