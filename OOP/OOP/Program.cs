using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW X5", 218, 220, 2, 5);
            Train train = new Train("001Г Казань — Москва", 1200, 100, 7);

            car.ShowAllInfo();
            Console.WriteLine("");
            train.ShowAllInfo();

            train.Drive();
            Console.WriteLine("Поезд {0}", train.Status);
            Console.WriteLine("Машина {0}", car.Status);
            Console.WriteLine("");

            train.WagonNumber = 5;
            train.ShowAllInfo();
        }
    }
}
