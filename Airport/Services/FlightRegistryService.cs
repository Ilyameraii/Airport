using Airport.Interfaces;
using Airport.Models;
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
        public IList<IFlightInfo> Flights => flights;
        public void AddFlight(IFlightInfo flight)
        {
            flights.Add(flight);
        }

        public void DeleteFlight(Guid ID)
        {
            var flight = flights.Where(f => f.ID == ID).FirstOrDefault();
            if (flight != null)
            {
                flights.Remove(flight);
            }
        }
    }
}
