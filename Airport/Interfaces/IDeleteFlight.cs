using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Interfaces
{
    public interface IDeleteFlight
    {
        void DeleteFlight(Guid ID);
    }
}
