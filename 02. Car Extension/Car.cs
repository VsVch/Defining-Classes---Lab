﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double distance)
        {
            double check = FuelQuantity - distance * FuelConsumption;
            if (check >= 0) FuelQuantity -= distance * FuelConsumption;
            else Console.WriteLine("Not enough fuel to perform this trip!");
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:f2}";
        }
                    // WhoAmI() : string – returns the following message: 
                    //"Make: {this.Make}
                    // Model: {this.Model
                    //    }
                    //    Year: {this.Year}
                    //    Fuel: {this.FuelQuantity:F2}" 

    }
}
