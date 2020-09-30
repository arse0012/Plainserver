using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string RegNumber { get; set; }

        public Car()
        {

        }

        public Car(string model, string type, string regNumber)
        {
            Model = model;
            Type = type;
            RegNumber = regNumber;

        }
    }
}
