using System;
namespace TransportModeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моделирование транспортных средств\n");
            TransportDemo.Run();
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}