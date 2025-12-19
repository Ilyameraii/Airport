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
        public Task AddFlightAsync(Flight flight, CancellationToken cancellationToken = default)
        {
            flights.Add(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        public Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken = default)
        {
            flights.Remove(flight);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Изменение самолета
        /// </summary>
        public Task UpdateFlightAsync(Flight newFlight, CancellationToken cancellationToken = default)
        {
            var flight = flights.FirstOrDefault(f => f.Id == newFlight.Id);
            if (flight != null)
            {
                // Копируем значения свойств
                flight.AirplaneType = newFlight.AirplaneType;
                flight.ArrivalTime = newFlight.ArrivalTime;
                flight.NumberOfPassengers = newFlight.NumberOfPassengers;
                flight.PassengerTax = newFlight.PassengerTax;
                flight.NumberOfCrew = newFlight.NumberOfCrew;
                flight.CrewTax = newFlight.CrewTax;
                flight.ServicePercentage = newFlight.ServicePercentage;
            }
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Получение всего списка
        /// </summary>
        public Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(flights);
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public Task<int> TotalPassengersAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfPassengers));
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public Task<int> TotalCrewAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(flights.Sum(f => f.NumberOfCrew));
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(flights.Count);
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken = default)
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
        
        /// <summary>
        /// Получение самолета по айди
        /// </summary>
        public Task<Flight?> GetFlightAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var flight = flights.FirstOrDefault(f => f.Id == id);
            return Task.FromResult(flight);
        }
    }
}