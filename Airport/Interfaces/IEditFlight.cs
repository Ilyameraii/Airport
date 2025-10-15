using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Interfaces
{
    public interface IEditFlight
    {
        bool EditFlight(Flight updatedFlight);
    }
}
