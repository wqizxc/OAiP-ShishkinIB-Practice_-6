using System;
namespace TransportModeling
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Vehicle(string brand, string model, int year, decimal price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Модель: {Model}");
        }
        public decimal CalculateDepreciation(int currentYear)
        {
            int age = currentYear - Year;
            return Price * (decimal)(0.9 * age);
        }
        public virtual void Start()
        {
            Console.WriteLine("Транспортное средство заводится...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Транспортное средство останавливается...");
        }
        public void Repair()
        {
            Console.WriteLine("Проводится общий ремонт транспортного средства");
        }
        public decimal CalculateInsurance()
        {
            return Price * 0.05m;
        }
    }
}