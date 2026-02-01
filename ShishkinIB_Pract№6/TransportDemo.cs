using System;
namespace TransportModeling
{
    public class TransportDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Демонстрация моделирования транспорта ===\n");
            ElectricCar tesla = new ElectricCar("Tesla", "Model S", 2023, 85000, 100, 8);
            Console.WriteLine("1. Вызов унаследованных методов:");
            tesla.DisplayBasicInfo();
            Console.WriteLine($"Амортизация за 2 года: {tesla.CalculateDepreciation(2025):C}\n");
            Console.WriteLine("2. Вызов переопределенных методов:");
            tesla.Start();
            Console.WriteLine();
            tesla.Stop();
            Console.WriteLine();
            Console.WriteLine("3. Вызов скрытых методов:");
            tesla.Repair();
            Console.WriteLine($"Страховка электромобиля: {tesla.CalculateInsurance():C}\n");
            Console.WriteLine("4. Вызов методов производного класса:");
            tesla.DisplayBatteryInfo();
            Console.WriteLine("\n5. Демонстрация полиморфизма:");
            Vehicle vehicleRef = tesla;
            Console.WriteLine("При вызове через ссылку типа Vehicle:");
            vehicleRef.Start(); 
            vehicleRef.Stop();  
            vehicleRef.Repair(); 
            Console.WriteLine("\nПри вызове через ссылку типа ElectricCar:");
            tesla.Repair();
            Console.WriteLine("\n6. Сравнение страховок:");
            Console.WriteLine($"Базовая страховка: {vehicleRef.CalculateInsurance():C}");
            Console.WriteLine($"Страховка электромобиля: {tesla.CalculateInsurance():C}");
        }
    }
}