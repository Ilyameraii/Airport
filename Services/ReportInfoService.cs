using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Services.Contracts;
using System.Diagnostics;

namespace Services
{
    public class ReportInfoService : IReportInfoService
    {
        private readonly ILogger<ReportInfoService> logger;
        private readonly IReportInfo storage;

        public ReportInfoService(IReportInfo storage, ILogger<ReportInfoService> logger)
        {
            this.storage = storage;
            this.logger = logger;
        }

        public async Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalArrivingFlights(cancellationToken);
                return result;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(TotalArrivingFlightsAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }

        public async Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalCrew(cancellationToken);
                return result;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(TotalCrewAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }

        public async Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalPassangers(cancellationToken);
                return result;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(TotalPassangersAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }

        public async Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
        {

            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalRevenue(cancellationToken);
                return result;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(TotalRevenueAsync), stopwatch.Elapsed.TotalSeconds);
            }
        }
    }
}
