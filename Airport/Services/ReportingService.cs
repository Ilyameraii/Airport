using Airport.Interfaces;
using Airport.Models;
using System.ComponentModel;

namespace Airport.Services
{
    internal class ReportingService : IReportInfo
    {
        private readonly BindingList<IFlightInfo> flights;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flights">Список рейсов</param>
        public ReportingService(BindingList<IFlightInfo> flights)
        {
            this.flights = flights;
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public int TotalPassangers => flights.Sum(f => f.NumberOfPassengers);

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public int TotalCrew => flights.Sum(f => f.NumberOfCrew);

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public int TotalArrivingFlights => flights.Count();

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public decimal TotalRevenue
        {
            get
            {
                decimal result = 0;
                foreach (var flight in flights)
                {
                    var baseRevenue = flight.NumberOfPassengers * flight.PassengerTax +
                                      flight.NumberOfCrew * flight.CrewTax;
                    var surcharge = baseRevenue * (flight.ServicePercentage / 100m);
                    result += baseRevenue + surcharge;
                }
                return Math.Round(result, 2);
            }
        }
    }
}
