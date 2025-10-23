using Airport.Interfaces;
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
        public decimal TotalRevenue => flights.Sum(f => f.Revenue); 
    }
}
