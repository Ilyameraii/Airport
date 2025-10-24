using Airport.Interfaces;
using System.ComponentModel;

namespace Airport.Services
{
    internal class FlightRegistryService : IFlightRegistryService
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flight">Рейс</param>   
        public FlightRegistryService(BindingList<IFlightInfo> flights)
        {
            Flights = flights;
        }

        /// <summary>
        ///  Возвращает коллекцию информации о рейсах.
        /// </summary>
        public BindingList<IFlightInfo> Flights { get; private set; }
    }
}
