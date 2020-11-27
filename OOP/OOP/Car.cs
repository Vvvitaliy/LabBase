using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Car<T, X> : Vehicle
    {
        private T passengersNumber;
        private X doorsNumber;

        public T PassengersNumber 
        {
            get { return passengersNumber; }
            set { passengersNumber = value; }
        }
        public X DoorsNumber
        {
            get { return doorsNumber; }
            set { doorsNumber = value; }
        }

        public Car()
        {
            WheelsNumber = 4;
            Stop();
        }

        public Car(string model, int horsePower, int maxSpeed, T passengersNumber, X doorsNumber) 
        {
            WheelsNumber = 4;
            Stop();
            Model = model;
            HorsePower = horsePower;
            MaxSpeed = maxSpeed;
            PassengersNumber = passengersNumber;
            DoorsNumber = doorsNumber;
        }

        public override void ShowAllInfo()
        {
            string output = String.Format("Машина {0}\nКоличество колес: {1}\nСтатус: {2}\nКоличество лошадиных сил: {3}\nМаксимальная скорость: {4}\nКоличество пассажиров: {5}\nКоличество дверей: {6}",
                Model, WheelsNumber, Status, HorsePower, MaxSpeed, PassengersNumber, DoorsNumber);
            Console.WriteLine(output);
        }
    }
}
