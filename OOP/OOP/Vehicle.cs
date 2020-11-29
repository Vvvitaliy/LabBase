using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Vehicle
    {
        private string model;
        private int wheelsNumber;
        private int horsePower;
        private int maxSpeed;
        private string status;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int WheelsNumber 
        {
            get { return wheelsNumber; }
            protected set { wheelsNumber = value; }
        }
        public int HorsePower
        {
            get { return horsePower; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Количество лошадиных сил должно быть больше 0");
                }
                horsePower = value; 
            }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Максимальная скорость должна быть больше 0");
                }
                maxSpeed = value; 
            }
        }
        public string Status
        {
            get { return status; }
            private set { status = value; }
        }

        public void Drive()
        {
            Status = "Едет";
        }
        public void Stop()
        {
            Status = "Стоит";
        }

        public abstract void ShowAllInfo();
    }
}
