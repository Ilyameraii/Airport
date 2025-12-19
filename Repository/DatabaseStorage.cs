using Entities.Models;
using Repository.Contracts;
using Context;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DatabaseStorage : IFlightRegistry, IReportInfo
    {
        /// <summary>
        /// Добавление самолета
        /// </summary>
        public async Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            context.Flights.Add(flight);
            await context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        public async Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            context.Flights.Remove(flight);
            await context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Изменение самолета
        /// </summary>
        public async Task UpdateFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();

            var entity = await context.Flights
                .FirstOrDefaultAsync(x => x.Id == flight.Id, cancellationToken);

            if (entity == null)
                throw new InvalidOperationException("Рейс не найден");

            entity.AirplaneType = flight.AirplaneType;
            entity.ArrivalTime = flight.ArrivalTime;
            entity.NumberOfPassengers = flight.NumberOfPassengers;
            entity.PassengerTax = flight.PassengerTax;
            entity.NumberOfCrew = flight.NumberOfCrew;
            entity.CrewTax = flight.CrewTax;
            entity.ServicePercentage = flight.ServicePercentage;

            await context.SaveChangesAsync(cancellationToken);
        }

        
        /// <summary>
        /// Получение всего списка
        /// </summary>
        public async Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            return await context.Flights.ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public async Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Sum(f => f.NumberOfPassengers);
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public async Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Sum(f => f.NumberOfCrew);
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public async Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Count;
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public async Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);

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

        public async Task<Flight?> GetFlightAsync(Guid id, CancellationToken cancellationToken)
        {
            await using var context = new DatabaseContext();
            var flight = await context.Flights.FirstOrDefaultAsync(f => f.Id == id, cancellationToken: cancellationToken);
            return flight;
        }
        
    }
}
