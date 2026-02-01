using System;
namespace TransportModel
{
    class Transport
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Weight { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Транспорт начал движение");
        }

        public void Stop()
        {
            Console.WriteLine("Транспорт остановился");
        }
        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется");
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Название: {Name}, Скорость: {MaxSpeed}");
        }
        public void Service()
        {
            Console.WriteLine("Транспорт проходит обслуживание");
        }

        public void Fuel()
        {
            Console.WriteLine("Транспорт заправляется");
        }
    }
}