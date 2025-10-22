namespace Airport.Interfaces
{
    public interface IFlightRegistryService
    {
        IEnumerable<IFlightInfo> Flights { get; }
        void AddFlight(IFlightInfo flight);
        void DeleteFlight(IFlightInfo flight);
    }
}
