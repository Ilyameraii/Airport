using Airport.Entites.Models;
using System.ComponentModel;

namespace Airport.Services.Contracts
{
    /// <summary>
    /// Интерфейс, предоставляющий доступ к добавлению и удалению самолетов, и просмотру всего списка самолетов
    /// </summary>
    public interface IFlightRegistryService
    {
        void AddFlight(Flight flight);
        void DeleteFlight(Flight flight);
        BindingList<Flight> GetAll();
    }
}
