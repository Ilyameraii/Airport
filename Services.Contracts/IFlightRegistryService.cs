using Entities.Models;

namespace Services.Contracts
{
    /// <summary>
    /// Интерфейс, предоставляющий доступ к добавлению и удалению самолетов, и просмотру всего списка самолетов
    /// </summary>
    public interface IFlightRegistryService
    {
        /// <summary>
        /// Добавление самолета
        /// </summary>
        Task AddFlightAsync(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление самолета
        /// </summary>
        Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Изменение самолета
        /// </summary>
        Task UpdateFlightAsync(Flight flight, CancellationToken cancellationToken);
            
        /// <summary>
        /// Возвращает список всех самолетов
        /// </summary>
        Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Возвращает самолет по айди
        /// </summary>
        Task<Flight?> GetFlightAsync(Guid id, CancellationToken cancellationToken);
    }
}
