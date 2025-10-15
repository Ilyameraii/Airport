using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Interfaces
{
    public interface IFlightInfo
    {
        Guid ID { get; }
        string AirplaneType { get; }
        DateTime ArrivalTime { get; }
        int NumberOfPassengers { get; }
        decimal PassengerTax { get; }
        int NumberOfCrew { get; }
        decimal CrewTax { get; }
        decimal ServicePercentage { get; } // например, 0.1 = 10%
        decimal Revenue { get; }
    }
}
