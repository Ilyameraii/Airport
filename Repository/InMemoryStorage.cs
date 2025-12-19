using Entities.Models;
using Repository.Contracts;
namespace Repository
{
    /// <summary>
    /// Сервис составления отчета о рейсах
    /// </summary>
    public class InMemoryStorage : IFlightRegistry, IReportInfo
    {
        private readonly List<Flight> flights = [];

        /// <summary>
        /// Добавление самолета
        /// </summary>
        public Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            flights.Add(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        public Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            flights.Remove(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Получение всего списка
        /// </summary>
        public Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights);
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfPassengers));
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfCrew));
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(flights.Count);
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
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

        public Task<Flight?> GetFlightAsync(Guid id, CancellationToken cancellationToken)
        {
            var flight = flights.FirstOrDefault(f => f.Id == id);
            return Task.FromResult(flight);
        }
    }
}