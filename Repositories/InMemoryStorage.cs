using Entities.Models;
using Repository.Contracts;
using System.ComponentModel;

namespace Repository
{
    /// <summary>
    /// Сервис составления отчета о рейсах
    /// </summary>
    public class InMemoryStorage : IFlightRegistry, IReportInfo
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
        public Task<int> TotalPassangers(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfPassengers));
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public Task<int> TotalCrew(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfCrew));
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public Task<int> TotalArrivingFlights(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Count());
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public Task<decimal> TotalRevenue(CancellationToken cancellationToken)
        {
            decimal result = 0;
            foreach (var flight in flights)
            {
                var baseRevenue = flight.NumberOfPassengers * flight.PassengerTax +
                                  flight.NumberOfCrew * flight.CrewTax;
                var surcharge = baseRevenue * (flight.ServicePercentage / 100m);
                result += baseRevenue + surcharge;
            }
            return Task.FromResult(Math.Round(result, 2));
        }
    }
}