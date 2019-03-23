using System;
using System.Collections.Generic;
using ConsoleApp20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GarageTest
    {

        [TestMethod]
        [ExpectedException(typeof(CarAlreadyHereException))]
        public void TestMethodAddCar1()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);
            Car a = new Car("Subaru", false, true);
            cars.AddCar(a);
            cars.AddCar(a);
                        
        }
        [TestMethod]
        [ExpectedException(typeof(WeDoNotFixTotalLostException))]
        public void TestMethodAddCar2()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);
            Car a = new Car("Subaru", true, true);
            cars.AddCar(a);
            
        }
        [TestMethod]
        [ExpectedException(typeof(WrongGarageException))]
        public void TestMethodAddCar3()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);

            cars.AddCar(new Car("Subaru", false, true));
            cars.AddCar(new Car("Saab", false, true));
            
        }
        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void TestMethodAddCar4()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);
            Car a = null;
            cars.AddCar(a);

        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TestMethodTakeOutCar()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);

            cars.TakeOutCar(new Car("Subaru", false, true));
            cars.TakeOutCar(new Car("Saab", false, true));


        }
        
        //[TestMethod]
        //[ExpectedException(typeof(CarNotReadyException))]
        //public void TestMethodTakeOutCar1()
        //{
        //    List<string> carTypes = new List<string>();
        //    carTypes.Add("Subaru");
        //    carTypes.Add("Toyota");
        //    carTypes.Add("Mitsubishi");
        //    Garage cars = new Garage(carTypes);
        //    Car a = new Car("Subaru", false, true);
        //    //cars.TakeOutCar(a);
        //    cars.AddCar(a);

        //    Assert.IsTrue(a.NeedsRepair == true);


        //}
        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void TestMethodFixCar()
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);
            //cars.AddCar(new Car("Subaru", false, false));
            Car a = new Car("Subaru", false, false);
            //cars.FixCar(a);
            cars.AddCar(a);
            //Assert.IsTrue(a.NeedsRepair == false);


        }
    }
}
