using Airport.Interfaces;
using System.ComponentModel;

namespace Airport.Services
{
    internal class FlightRegistryService : IFlightRegistryService
    {
        private readonly BindingList<IFlightInfo> flights = new();

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flight">Рейс</param>   
        public FlightRegistryService(BindingList<IFlightInfo> flights)
        {
            this.flights = flights ?? throw new ArgumentNullException(nameof(flights));
        }

        /// <summary>
        ///  Возвращает коллекцию информации о рейсах.
        /// </summary>
        public IEnumerable<IFlightInfo> Flights => flights;

        /// <summary>
        /// Метод добавления рейсов
        /// </summary>
        /// <param name="flight">Рейс, который хотим добавить</param>
        public void AddFlight(IFlightInfo flight)
        {
            flights.Add(flight);
        }

        /// <summary>
        /// Метод удаления рейса
        /// </summary>
        /// <param name="flight">Выбранный рейс, который хотим удалить</param>
        public void DeleteFlight(IFlightInfo flight)
        {
            flights.Remove(flight);
        }
    }
}
