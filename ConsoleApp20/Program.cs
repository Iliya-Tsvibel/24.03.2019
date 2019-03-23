using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carTypes = new List<string>();
            carTypes.Add("Subaru");
            carTypes.Add("Toyota");
            carTypes.Add("Mitsubishi");
            Garage cars = new Garage(carTypes);

            cars.AddCar(new Car("Subaru", false, true));
            cars.AddCar(new Car("Saab", false, true));

            //List<string> list = new List<string> { "Subaru", "Toyota", "Mitsubishi" };
            //Garage garage = new Garage(list);
            //Car a = new Car("Subaru", false, true);
            ////Car b = new Car("Saab", false, true);
            //garage.AddCar(a);
            ////garage.AddCar(b);
        }
    }
}
