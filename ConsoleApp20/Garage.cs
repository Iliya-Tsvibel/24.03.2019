using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Garage : IGarage
    {

        public List<Car> cars;
        public List<string> carTypes;

        public Garage(List<string> carTypes)
        {

            cars = new List<Car>();
            this.carTypes = carTypes;
        }



        public void AddCar(Car car)

        {
            if (car == null)
            {
                throw new CarNullException("The car is exist");
            }

            if (cars.Contains(car))
            {
                throw new CarAlreadyHereException($"Type of car: {car} alredy exist in list");
            }

            if (car.TotalLost == true)
            {
                throw new WeDoNotFixTotalLostException("Cell this car for the parts");
            }

            if (!carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException("You need another garage");
            }

           

            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException("Your car not need repair");
            }
            cars.Add(car);
     
        }

        public void TakeOutCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("The car is exist");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException($"Type of car: {car} not exist in list");
            }
            if (car.NeedsRepair == true)
            {
                throw new CarNotReadyException("Your car not ready yet");
            }
            cars.Remove(car);

        }

        public void FixCar(Car car)
        {
            if (car == null)
            {
                throw new CarNullException("The car is exist");
            }
            if (!cars.Contains(car))
            {
                throw new CarNotInGarageException($"Type of car: {car} not exist in list");
            }
            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException("Your car not need repair");
            }
            if (car.NeedsRepair == false)
            {
                throw new RepairMismatchException($"The car {car} dont need care or fixed");
            }

            car.NeedsRepair = false;

        }
           
     
    }
}
