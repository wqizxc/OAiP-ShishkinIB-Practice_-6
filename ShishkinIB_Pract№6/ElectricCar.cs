using System;
namespace TransportModeling
{
    public class ElectricCar : Vehicle
    {
        public int BatteryCapacity { get; set; } 
        public int ChargingTime { get; set; } 
        public ElectricCar(string brand, string model, int year, decimal price,
                          int batteryCapacity, int chargingTime)
            : base(brand, model, year, price)
        {
            BatteryCapacity = batteryCapacity;
            ChargingTime = chargingTime;
        }
        public override void Start()
        {
            Console.WriteLine($"Электромобиль {Brand} {Model} бесшумно включается");
            Console.WriteLine("Заряд батареи: 100%");
        }
        public override void Stop()
        {
            Console.WriteLine($"Электромобиль {Brand} {Model} плавно останавливается");
            Console.WriteLine("Режим рекуперативного торможения активирован");
        }
        public new void Repair()
        {
            Console.WriteLine("Проводится специализированный ремонт электромобиля");
            Console.WriteLine("Диагностика батареи и электродвигателя");
        }
        public new decimal CalculateInsurance()
        {
            decimal baseInsurance = base.CalculateInsurance();
            decimal electricDiscount = baseInsurance * 0.2m;
            return baseInsurance - electricDiscount;
        }
        public void DisplayBatteryInfo()
        {
            Console.WriteLine($"Емкость батареи: {BatteryCapacity} кВт·ч");
            Console.WriteLine($"Время зарядки: {ChargingTime} часов");
        }
    }
}