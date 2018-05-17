using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTransfer.Models
{
    public class Center : Location
    {
        protected List<Vehicle> _vehicles;
        protected List<Branch> _branches;

        public Center(List<Vehicle> vehicles, List<Branch> branches)
        {
            _vehicles = new List<Vehicle>(vehicles);
            _branches = new List<Branch>(branches);
        }

        public void TransferSemiToCenter(Center center, Semi semi)
        {
            if (!_vehicles.Contains(semi))
                throw new ArgumentException("Cannot transfer semi - it doesn't exist in this center");
            if (semi.VehicleStatus != VehicleStatusType.StandBy)
                throw new ArgumentException("A vehicle must be in Stand By status to transfer it");

            _vehicles.Remove(semi);
            center._vehicles.Add(semi);
        }
    }
}
