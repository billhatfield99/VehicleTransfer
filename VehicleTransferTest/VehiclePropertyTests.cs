using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VehicleTransfer.Models;

namespace VehicleTransferTest
{
    [TestClass]
    public class VehiclePropertyTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleYearIsntFourCharacters()
        {
            var coolTruck = new Truck();
            coolTruck.Year = "21387";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleYearIsntNumeric()
        {
            var coolTruck = new Truck();
            coolTruck.Year = "12ab";
        }
        [TestMethod]
        public void VehicleYearIsValid()
        {
            var coolTruck = new Truck();
            coolTruck.Year = "2018";
            Assert.AreEqual("2018", coolTruck.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleVINIsntTwentyFourCharacters()
        {
            var coolTruck = new Truck();
            coolTruck.Vin = "1a2b3c4d5e6f7g8h9i00112233";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleVINDoesntHaveEightAlphas()
        {
            var coolTruck = new Truck();
            coolTruck.Vin = "11223c4d5e6f7g8h9i001122";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VehicleVINDoesntHaveLastFiveNumeric()
        {
            var coolTruck = new Truck();
            coolTruck.Vin = "1a2b3c4d5e6f7g8h9i0j1k2l";
        }
        [TestMethod]
        public void VehicleVINIsValid()
        {
            var vin = "1a2b3c4d5e6f7g8h9i012345";
            var coolTruck = new Truck();
            coolTruck.Vin = vin;

            Assert.AreEqual(coolTruck.Vin, vin);
        }
    }
}
