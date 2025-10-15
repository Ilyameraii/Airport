using Airport.Interfaces;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Services
{
    internal class FlightRegistryService : IAddFlight, IDeleteFlight, IEditFlight
    {
        private List<IFlightInfo> flights;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flight">Рейс</param>
        public FlightRegistryService(List<IFlightInfo> flights)
        {
            this.flights = flights;
        }

        public IReadOnlyList<IFlightInfo> GetAllFlights() => flights.AsReadOnly();

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

        public bool EditFlight(Flight updatedFlight)
        {
            var index = flights.FindIndex(f => f.ID == updatedFlight.ID);
            if (index == -1) return false;
            flights[index] = updatedFlight;
            return true;
        }



    }
}
