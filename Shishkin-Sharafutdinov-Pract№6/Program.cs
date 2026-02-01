using System;
using System.Runtime.ConstrainedExecution;
namespace TransportModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Name = "Toyota",
                MaxSpeed = 180,
                Weight = 1500,
                Year = 2020,
                Doors = 4,
                FuelType = "Бензин"
            };
            car.Start();
            car.Move();        
            car.GetInfo();     
            car.Service();     
            car.Fuel();       
            car.Stop();
            Console.ReadLine();
        }
    }
}