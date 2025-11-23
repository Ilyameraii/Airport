using Airport.Entites.Models;
using System.ComponentModel;
using System.Threading;

namespace Airport.Services.Contracts
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
        Task AddFlight(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление самолета
        /// </summary>
        /// <param name="flight">экземпляр самолета</param>
        Task DeleteFlight(Flight flight, CancellationToken cancellationToken);

        /// <summary>
        /// Возвращает список всех самолетов
        /// </summary>
        Task<BindingList<Flight>> GetAll(CancellationToken cancellationToken);
    }
}
