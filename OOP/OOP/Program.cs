using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<int, int> car1 = new Car<int, int>("BMW X5", 218, 220, 2, 5);
            Car<double, string> car2 = new Car<double, string>("BMW X5", 218, 220, 2.5, "пять");

            car1.ShowAllInfo();
            Console.WriteLine("");
            car2.ShowAllInfo();
            Console.WriteLine("");

            Train train = new Train("001Г Казань — Москва", 1200, 100, 7);
            Console.WriteLine(train.ToString());
            Console.WriteLine("");


            Train train2 = new Train("001Г Казань — Москва", 1200, 100, 7);
            Console.WriteLine(train.Equals(train2));
            Console.WriteLine("");

            train2.MaxSpeed = 150;
            Console.WriteLine(train.Equals(train2));
            Console.WriteLine("");

            Console.WriteLine(train.Equals(car1));
        }
    }
}
