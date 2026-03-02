using System;

namespace TransportModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Создание объекта Car ===");
            Car car = new Car
            {
                Name = "Toyota",
                MaxSpeed = 180,
                Weight = 1500,
                Year = 2020,
                Doors = 4,
                FuelType = "Бензин"
            };

            Console.WriteLine("\n=== Вызов методов через объект Car ===");
            car.Start();     
            car.Move();        
            car.GetInfo();    
            car.Service();    
            car.Fuel();         
            car.Stop();         
            Transport transportRef = car;

            Console.WriteLine("Вызов методов через ссылку Transport:");
            transportRef.Service();  
            transportRef.Fuel();   

            Console.WriteLine("\nВызов виртуальных методов через ссылку Transport:");
            transportRef.Move();     
            transportRef.GetInfo();  

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}