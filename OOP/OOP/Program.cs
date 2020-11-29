using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Train> trainList = new List<Train>();
            trainList.Add(new Train("001Г Казань — Москва", 1200, 100, 7));
            trainList.Add(new Train("003Г Казань — Москва", 1200, 100, 5));
            trainList.Add(new Train("001Д Казань — Коломна", 1200, 100, 6));
            trainList.Add(new Train("001А Рязань — Москва", 1200, 100, 3));
            trainList.Add(new Train("005Г Москва — Рязань", 1200, 100, 9));
            trainList.Add(new Train("002Г Москва — Коломна", 1200, 100, 4));

            foreach (var item in trainList)
            {
                Console.WriteLine(item.WagonNumber);
            }
            Console.WriteLine("");

            trainList.Sort();
            foreach (var item in trainList)
            {
                Console.WriteLine(item.WagonNumber);
            }

            Car<int, int> car = new Car<int, int>();

            try
            {
                trainList[0].CompareTo(car);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Train train = new Train("001Г Казань — Москва", 1200, 100, -1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Train train = new Train("001Г Казань — Москва", 1200, 0, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Train train = new Train("001Г Казань — Москва", 0, 1, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
