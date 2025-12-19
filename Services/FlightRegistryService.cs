using Entities.Models;
using Microsoft.Extensions.Logging;
using Repository.Contracts;
using Services.Contracts;
using System.ComponentModel;
using System.Diagnostics;

namespace Services
{
    /// <summary>
    /// Сервис для добавления и удаления самолетов, просмотра всего списка самолетов
    /// </summary>
    /// <remarks>
    /// Конструктор
    /// </remarks>
    public class FlightRegistryService(IFlightRegistry storage, ILogger<FlightRegistryService> logger) : IFlightRegistryService
    {
        private readonly ILogger<FlightRegistryService> logger = logger;
        private readonly IFlightRegistry storage = storage;

        /// <summary>
        /// Добавление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        public async Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.AddFlight(flight, cancellationToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(AddFlightAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(AddFlightAsync), stopwatch.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Удаление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        public async Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.DeleteFlight(flight, cancellationToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(DeleteFlightAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(DeleteFlightAsync), stopwatch.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Возвращает список всех самолетов
        /// </summary>
        public async Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                var result = await storage.GetAll(cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка в методе {MethodName}", nameof(GetAllAsync));
                throw;
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationMilliseconds} мс", nameof(GetAllAsync), stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
