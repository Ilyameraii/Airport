using Repository.Contracts;
using Services.Contracts;

namespace Services
{
    public class ReportInfoService : IReportInfoService
    {
        private readonly IReportInfo storage;
        public ReportInfoService(IReportInfo storage)
        {
            this.storage = storage;
        }

        public async Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalArrivingFlights(cancellationToken);
            return result;
        }

        public async Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalCrew(cancellationToken);
            return result;
        }

        public async Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalPassangers(cancellationToken);
            return result;
        }

        public async Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalRevenue(cancellationToken);
            return result;
        }
    }
}
