using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTransfer.Models
{
    public abstract class Vehicle
    {
        protected string _make;
        public string Make { get; set; }

        protected string _model;
        public string Model { get; set; }

        protected string _year;
        public string Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value.Length != 4 ||
                    !Int32.TryParse(value, out var x))
                {
                    throw new ArgumentException("Year must be four numeric characters");
                }
                else
                {
                    _year = value;
                }
            }
        }

        protected string _vin;
        public string Vin
        {
            get
            {
                return _vin;
            }
            set
            {
                var x = 0;
                if (value.Length != 24 ||
                    value.Count(char.IsLetter) < 8 ||
                    !Int32.TryParse(value.Substring(value.Length - 5), out x))
                {
                    throw new ArgumentException("VIN be 24 characters long, have 8 letters and the last 5 characters must be numbers");
                }
                else
                {
                    _vin = value;
                }
            }
        }

        protected VehicleStatusType _vehicleStatus;
        public VehicleStatusType VehicleStatus { get; set; }

        public Vehicle()
        {
        }
        public Vehicle(string make, string model, string year, string vin, VehicleStatusType status)
        {
            Make = make;
            Model = model;
            Year = year;
            Vin = vin;
            VehicleStatus = status;
        }
    }
}
