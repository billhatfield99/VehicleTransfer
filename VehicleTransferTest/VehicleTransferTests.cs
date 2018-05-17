using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VehicleTransfer.Models;

namespace VehicleTransferTest
{
    [TestClass]
    public class VehicleTransferTests
    {
        [TestMethod]
        public void TransferVehicleFromBranchToBranch()
        {
            var favoriteVehicle = new Truck("Make3", "Model2", "2018", "aabbccdd1122334455668803", VehicleStatusType.StandBy);
            var vehicles1 = new List<Vehicle> {
                new Truck("Make1","Model1","2018","aabbccdd1122334455668899", VehicleStatusType.InService),
                new Van("Make2","Model1","2018","aabbccdd1122334455668800", VehicleStatusType.InTransit),
                new Van("Make2","Model2","2018","aabbccdd1122334455668801", VehicleStatusType.InTransit),
                new Semi("Make3","Model1","2018","aabbccdd1122334455668802", VehicleStatusType.Repair),
                favoriteVehicle
            };

            var branch1 = new Branch(vehicles1);

            var vehicles2 = new List<Vehicle> {
                new Truck("Make1","Model1","2018","aabbccdd1122334455668844", VehicleStatusType.InService),
                new Van("Make1","Model2","2018","aabbccdd1122334455668855", VehicleStatusType.InTransit),
                new Truck("Make2","Model1","2018","aabbccdd1122334455668866", VehicleStatusType.InService)
            };

            var branch2 = new Branch(vehicles2);

            branch1.TransferToBranch(branch2, favoriteVehicle);
        }





        [TestMethod]
        public void TransferSemiFromCenterToCenter()
        {
            var favoriteVehicle = new Semi("Make3", "Model1", "2018", "aabbccdd1122334455668802", VehicleStatusType.StandBy);
            var vehicles1 = new List<Vehicle> {
                new Truck("Make1","Model1","2018","aabbccdd1122334455668899", VehicleStatusType.InService),
                new Van("Make2","Model1","2018","aabbccdd1122334455668800", VehicleStatusType.InTransit),
                new Van("Make2","Model2","2018","aabbccdd1122334455668801", VehicleStatusType.InTransit),
                favoriteVehicle
            };

            var branches1 = new List<Branch>
            {
                new Branch(), new Branch()
            };
            var center1 = new Center(vehicles1, branches1);

            var vehicles2 = new List<Vehicle> {
                new Truck("Make1","Model1","2018","aabbccdd1122334455668844", VehicleStatusType.InService),
                new Van("Make1","Model2","2018","aabbccdd1122334455668855", VehicleStatusType.InTransit),
                new Truck("Make2","Model1","2018","aabbccdd1122334455668866", VehicleStatusType.InService)
            };

            var branches2 = new List<Branch>
            {
                new Branch(), new Branch()
            };
            var center2 = new Center(vehicles2, branches2); ;

            center1.TransferSemiToCenter(center2, favoriteVehicle);
        }

    }
}
