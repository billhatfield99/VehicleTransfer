using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTransfer.Models
{
    public class Semi : Vehicle
    {
        public Semi() : base()
        {
        }
        public Semi(string make, string model, string year, string vin, VehicleStatusType status)
            : base(make, model, year, vin, status)
        {
        }
    }
}
