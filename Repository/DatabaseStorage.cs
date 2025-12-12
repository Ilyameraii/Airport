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
        /// <param name="flight">экземпляр самолета</param>
        public async Task AddFlight(Flight flight, CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            context.Flights.Add(flight);
            await context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        public async Task DeleteFlight(Flight flight, CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            context.Flights.Remove(flight);
            await context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Получение всего списка
        /// </summary>
        public async Task<List<Flight>> GetAll(CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            return await context.Flights.ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public async Task<int> TotalPassangers(CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Sum(f => f.NumberOfPassengers);
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public async Task<int> TotalCrew(CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Sum(f => f.NumberOfCrew);
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public async Task<int> TotalArrivingFlights(CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
            var flights = await context.Flights.ToListAsync(cancellationToken);
            return flights.Count;
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public async Task<decimal> TotalRevenue(CancellationToken cancellationToken)
        {
            using var context = new DatabaseContext();
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
    }
}
