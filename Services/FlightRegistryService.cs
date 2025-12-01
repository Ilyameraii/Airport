using Entities.Models;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Services.Contracts;
using System.ComponentModel;
using System.Diagnostics;

namespace Services
{
    public class FlightRegistryService : IFlightRegistryService
    {

        private readonly ILogger<FlightRegistryService> logger;
        private readonly IFlightRegistry storage;

        public FlightRegistryService(IFlightRegistry storage, ILogger<FlightRegistryService> logger)
        {
            this.storage = storage;
            this.logger = logger;
        }

        public async Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.AddFlight(flight, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(AddFlightAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }

        public async Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.DeleteFlight(flight, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(DeleteFlightAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }

        public async Task<BindingList<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.GetAll(cancellationToken);
                return result;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(GetAllAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }
    }
}
