using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Bike : IFixTotalLost
    {
       

        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }
        public int EngineVolume { get; set; }

        public Bike(string brand, bool totalLost, bool needsRepair, int engineVolume)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;
            EngineVolume = engineVolume;
            if (TotalLost == true && NeedsRepair == false)
            {
                throw new RepairMismatchException("The car doesnt need care");
            }
        }
        public bool CanFixTotalLost()
        {
            return true;
        }


    }
}
