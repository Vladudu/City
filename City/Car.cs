using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Car
    {
        public string model { get; set; }
        public string brand { get; set; }
        public string year { get; set; }
        public int seats { get; set; }

        public Car(string model, string brand, string year, int seats)
        {
            this.model = model;
            this.brand = brand;
            this.year = year;
            this.seats = seats;
        }
    }
    
}
