using Airport.Entites.Models;
using Airport.Services.Contracts;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Airport.Services
{
    /// <summary>
    /// Сервис составления отчета о рейсах
    /// </summary>
    public class InMemoryStorage: IFlightRegistryService, IReportInfo
    {
        private readonly BindingList<Flight> flights = new();

        /// <summary>
        /// Добавление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        public Task AddFlight(Flight flight, CancellationToken cancellationToken)
        {
            flights.Add(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        public Task DeleteFlight(Flight flight, CancellationToken cancellationToken)
        {
            flights.Remove(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Получение всего списка
        /// </summary>
        public Task<BindingList<Flight>> GetAll(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights);
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