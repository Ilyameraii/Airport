namespace Airport.Interfaces
{
    public interface IReportInfo
    {
        int TotalPassangers { get; }

        int TotalArrivingFlights { get; }

        int TotalCrew { get; }

        decimal TotalRevenue { get; }
    }
}
