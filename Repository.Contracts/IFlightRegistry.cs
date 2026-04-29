using Entities.Models;

namespace Repository.Contracts
{
    /// <summary>
    /// Интерфейс, предоставляющий доступ к добавлению и удалению самолетов, и просмотру всего списка самолетов
    /// </summary>
    public interface IFlightRegistry
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
        /// Получение самолета по айди
        /// </summary>
        Task<Flight?> GetFlightAsync(Guid id, CancellationToken cancellationToken);
    }
}
