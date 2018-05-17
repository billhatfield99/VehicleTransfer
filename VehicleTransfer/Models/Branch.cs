using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTransfer.Models
{
    public class Branch : Location
    {
        protected List<Vehicle> _vehicles { get; set; }

        public Branch(List<Vehicle> vehicles = null)
        {
            if (vehicles == null)
                _vehicles = new List<Vehicle>();
            else
                _vehicles = new List<Vehicle>(vehicles);
        }

        public void TransferToBranch(Branch branch, Vehicle vehicle)
        {
            if (!_vehicles.Contains(vehicle))
                throw new ArgumentException("Cannot transfer vehicle - it doesn't exist in this branch");
            if (vehicle.GetType() != typeof(Truck) && vehicle.GetType() != typeof(Van))
                throw new ArgumentException("Only trucks and vans can be transferred between branches");
            if (vehicle.VehicleStatus != VehicleStatusType.StandBy)
                throw new ArgumentException("A vehicle must be in Stand By status to transfer it");

            _vehicles.Remove(vehicle);
            branch._vehicles.Add(vehicle);
        }
    }
}
