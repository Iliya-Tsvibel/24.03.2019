using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class GarageT<T>:IGarageT<T> where T:IVehicle
    {
        
        List<T> vehicles;
        List<string> vehicleTypes;


        public GarageT(List<string> carTypes)
        {
            
            this.vehicleTypes = carTypes;
            vehicles = new List<T>();
        }

        public void AddVehicle(T vehicle)

        {
            if (vehicle == null)
            {
                throw new CarNullException("The car is exist");
            }

            if (vehicles.Contains(vehicle))
            {
                throw new CarAlreadyHereException($"Type of car: {vehicle} alredy exist in list");
            }

            if (vehicle.CanFixTotalLost() == true)
            {
                throw new WeDoNotFixTotalLostException("Cell this car for the parts");
            }

            if (!vehicleTypes.Contains(vehicle.Brand))
            {
                throw new WrongGarageException("You need another garage");
            }



            if (vehicle.NeedsRepair == false)
            {
                throw new RepairMismatchException("Your car not need repair");
            }
            vehicles.Add(vehicle);

        }

        public void TakeOutVehicle(T vehicle)
        {
            if (vehicle == null)
            {
                throw new CarNullException("The car is exist");
            }
            if (!vehicles.Contains(vehicle))
            {
                throw new CarNotInGarageException($"Type of car: {vehicle} not exist in list");
            }
            if (vehicle.NeedsRepair == true)
            {
                throw new CarNotReadyException("Your car not ready yet");
            }
            vehicles.Remove(vehicle);

        }

        public void FixVehicle(T vehicle)
        {
            if (vehicle == null)
            {
                throw new CarNullException("The car is exist");
            }
            if (!vehicles.Contains(vehicle))
            {
                throw new CarNotInGarageException($"Type of car: {vehicle} not exist in list");
            }
            if (vehicle.NeedsRepair == false)
            {
                throw new RepairMismatchException("Your car not need repair");
            }
            if (vehicle.NeedsRepair == false)
            {
                throw new RepairMismatchException($"The car {vehicle} dont need care or fixed");
            }

            vehicle.NeedsRepair = false;

        }
    }
}
