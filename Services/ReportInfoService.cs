using Repository.Contracts;
using Services.Contracts;

namespace Services
{
    /// <summary>
    /// Сервис, предоставляющий информацию для отчёта по рейсам
    /// </summary>
    public class ReportInfoService : IReportInfoService
    {
        private readonly IReportInfo storage;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="storage">хранилище</param>
        public ReportInfoService(IReportInfo storage)
        {
            this.storage = storage;
        }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public async Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalArrivingFlights(cancellationToken);
            return result;
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public async Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalCrew(cancellationToken);
            return result;
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public async Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalPassangers(cancellationToken);
            return result;
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public async Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
        {
            var result = await storage.TotalRevenue(cancellationToken);
            return result;
        }
    }
}
