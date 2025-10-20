namespace Airport.Interfaces
{
    public interface IFlightInfo
    {
        Guid ID { get; }
        string AirplaneType { get; }
        DateTime ArrivalTime { get; }
        int NumberOfPassengers { get; }
        decimal PassengerTax { get; }
        int NumberOfCrew { get; }
        decimal CrewTax { get; }
        decimal ServicePercentage { get; } 
        decimal Revenue { get; }
    }
}
