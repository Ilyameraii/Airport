using Entities.Models;
using Repository.Contracts;
using Services.Contracts;

namespace Services
{
	/// <summary>
	/// Сервис, предоставляющий доступ к добавлению и удалению самолетов, и просмотру всего списка самолетов
	/// </summary>
	public class FlightRegistryService : IFlightRegistryService
    {
        private readonly IFlightRegistry storage;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="storage">хранилище</param>
        public FlightRegistryService(IFlightRegistry storage)
        {
            this.storage = storage;
        }

		/// <summary>
		/// Добавление самолета
		/// </summary>
		/// <param name="flight">экземпляр самолета</param>
		public async Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await storage.AddFlight(flight, cancellationToken);
        }

		/// <summary>
		/// Удаление самолета
		/// </summary>
		/// <param name="flight">экземпляр самолета</param>
		public async Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await storage.DeleteFlight(flight, cancellationToken);
        }

		/// <summary>
		/// Возвращает список всех самолетов
		/// </summary>
		public async Task<List<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await storage.GetAll(cancellationToken);
            return result;
        }
    }
}
