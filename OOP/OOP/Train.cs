using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Train : Vehicle
    {
        private int wagonNumber;

        public int WagonNumber
        {
            get { return wagonNumber; }
            set 
            { 
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

            Train train = (Train)obj;

            return Status == train.Status && Model == train.Model && HorsePower == train.HorsePower &&
                MaxSpeed == train.MaxSpeed && WagonNumber == train.WagonNumber && WheelsNumber == train.WheelsNumber;
        }

        public override string ToString()
        {
            return String.Format("Поезд {0}\nКоличество колес: {1}\nСтатус: {2}\nКоличество лошадиных сил: {3}\nМаксимальная скорость: {4}\nКоличество вагонов: {5}",
                Model, WheelsNumber, Status, HorsePower, MaxSpeed, WagonNumber);
        }
    }
}
