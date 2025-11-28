using Entities.Models;
using Repository.Contracts;
using Services.Contracts;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO.IsolatedStorage;

namespace Services
{
    public class FlightRegistryService : IFlightRegistryService
    {
        private readonly IFlightRegistry storage;
        public FlightRegistryService(IFlightRegistry storage)
        {
            this.storage = storage;
        }

        public async Task AddFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await storage.AddFlight(flight, cancellationToken);
        }

        public async Task DeleteFlightAsync(Flight flight, CancellationToken cancellationToken)
        {
            await storage.DeleteFlight(flight, cancellationToken);
        }

        public async Task<BindingList<Flight>> GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await storage.GetAll(cancellationToken);
            return result;
        }
    }
}
