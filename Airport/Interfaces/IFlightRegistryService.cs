namespace Airport.Interfaces
{
    public interface IFlightRegistryService
    {
        IList<IFlightInfo> Flights { get; }
        void AddFlight(IFlightInfo flight);
        void DeleteFlight(Guid ID);
    }
}
