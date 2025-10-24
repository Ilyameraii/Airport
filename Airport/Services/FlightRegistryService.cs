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

        /// <summary>
        /// Метод добавления рейсов
        /// </summary>
        /// <param name="flight">Рейс, который хотим добавить</param>
        public void AddFlight(IFlightInfo flight)
        {
            Flights.Add(flight);
        }

        /// <summary>
        /// Метод удаления рейса
        /// </summary>
        /// <param name="flight">Выбранный рейс, который хотим удалить</param>
        public void DeleteFlight(IFlightInfo flight)
        {
            Flights.Remove(flight);
        }
    }
}
