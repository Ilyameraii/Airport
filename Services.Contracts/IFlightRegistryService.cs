using Entities.Models;
using System.ComponentModel;

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
        /// <param name="flight">экземпляр самолета</param>
        Task AddFlightAsync(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает список всех самолетов
        /// </summary>
        Task<BindingList<Flight>> GetAllAsync(CancellationToken cancellationToken);
    }
}
