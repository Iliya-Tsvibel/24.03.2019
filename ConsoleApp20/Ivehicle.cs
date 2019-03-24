using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public interface IVehicle : IFixTotalLost
    {
        string Brand { get; }
        bool TotalLost { get; }
        bool NeedsRepair { get; set; }
    }
}
