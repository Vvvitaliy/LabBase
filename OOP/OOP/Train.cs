using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Train : Vehicle, IComparable
    {
        private int wagonNumber;

        public int WagonNumber
        {
            get { return wagonNumber; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Количество вагонов должнро быть больше 0");
                }
                wagonNumber = value;
                WheelsNumber = wagonNumber * 8;
            }
        }

        public Train(string model, int horsePower, int maxSpeed, int wagonNumber)
        {
            Stop();
            Model = model;
            HorsePower = horsePower;
            MaxSpeed = maxSpeed;
            WagonNumber = wagonNumber;
        }

        public override void ShowAllInfo()
        {
            string output = String.Format("Поезд {0}\nКоличество колес: {1}\nСтатус: {2}\nКоличество лошадиных сил: {3}\nМаксимальная скорость: {4}\nКоличество вагонов: {5}",
                Model, WheelsNumber, Status, HorsePower, MaxSpeed, WagonNumber);
            Console.WriteLine(output);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Train otherTrain = (Train)obj;

            return Status == otherTrain.Status && Model == otherTrain.Model && HorsePower == otherTrain.HorsePower &&
                MaxSpeed == otherTrain.MaxSpeed && WagonNumber == otherTrain.WagonNumber && WheelsNumber == otherTrain.WheelsNumber;
        }

        public override string ToString()
        {
            return String.Format("Поезд {0}\nКоличество колес: {1}\nСтатус: {2}\nКоличество лошадиных сил: {3}\nМаксимальная скорость: {4}\nКоличество вагонов: {5}",
                Model, WheelsNumber, Status, HorsePower, MaxSpeed, WagonNumber);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (GetType() != obj.GetType())
            {
                throw new ArgumentException("Объект не типа Train");
            }

            Train otherTrain = (Train)obj;
            if (WagonNumber < otherTrain.WagonNumber)
            {
                return -1;
            }
            if (WagonNumber == otherTrain.WagonNumber)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
