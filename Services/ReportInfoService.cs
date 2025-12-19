using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Services.Contracts;
using System.Diagnostics;

namespace Services
{
    /// <summary>
    /// Сервис для ведения отчета по рейсам
    /// </summary>
    /// <remarks>
    /// Конструктор
    /// </remarks>
    public class ReportInfoService(IReportInfo storage, ILogger<ReportInfoService> logger) : IReportInfoService
    {
        private readonly ILogger<ReportInfoService> logger = logger;
        private readonly IReportInfo storage = storage;

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        public async Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalArrivingFlightsAsync(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(TotalArrivingFlightsAsync));
                throw; 
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(TotalArrivingFlightsAsync), stopwatch.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        public async Task<int> TotalCrewAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalCrewAsync(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(TotalCrewAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(TotalCrewAsync), stopwatch.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        public async Task<int> TotalPassangersAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalPassangersAsync(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(TotalPassangersAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(TotalPassangersAsync), stopwatch.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        public async Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken)
        {

            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.TotalRevenueAsync(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(TotalRevenueAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(TotalRevenueAsync), stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
