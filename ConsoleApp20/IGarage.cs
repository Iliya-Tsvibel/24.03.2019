using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public interface IGarage
    {
        void AddCar(Car car);
        void TakeOutCar(Car car);
        void FixCar(Car car);
    }

    //// Targil etgar
    //public interface IGarage<T>
    //{
    //    void FixVehicle(T vehicle);
    //    void TakeOutVehicle(T vehicle);
    //    void AddVehicle(T vehicle);
    //}


}
