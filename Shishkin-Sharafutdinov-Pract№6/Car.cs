using System;
using System.Xml.Linq;

namespace TransportModel
{
    class Car : Transport
    {
        public int Doors { get; set; }
        public string FuelType { get; set; }

        public override void Move()
        {
            Console.WriteLine("Автомобиль едет по дороге");
        }
        public override void GetInfo()
        {
            Console.WriteLine(
                $"Авто: {Name}, Скорость: {MaxSpeed}, Дверей: {Doors}, Топливо: {FuelType}");
        }
        public new void Service()
        {
            Console.WriteLine("Автомобиль проходит ТО");
        }

        public new void Fuel()
        {
            Console.WriteLine("Автомобиль заправляется бензином");
        }
    }
}