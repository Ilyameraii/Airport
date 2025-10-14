using Airport.Interfaces;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Services
{
    internal class ReportingService : IReportInfo
    {
        private IEnumerable<Flight> flights;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flights">Рейсы</param>
        public ReportingService(IEnumerable<Flight> flights)
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
        public int TotalCrew=>flights.Sum(f => f.NumberOfCrew);

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
