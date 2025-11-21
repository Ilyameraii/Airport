using Airport.Entites.Models;
using System.ComponentModel;

namespace Airport.Services.Contracts
{
    public interface IFlightRegistryService
    {
        void AddFlight(Flight flight);
        void DeleteFlight(Flight flight);
        BindingList<Flight> GetAll();
    }
}
