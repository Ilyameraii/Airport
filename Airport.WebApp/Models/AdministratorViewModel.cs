namespace Airport.WebApp.Models;

public class AdministratorViewModel
{
    /// <summary>
    /// Общее количество прибывших рейсов
    /// </summary>
    public int TotalArrivingFlights { get; set; }

    /// <summary>
    /// Общее количество пассажиров
    /// </summary>
    public int TotalPassengers { get; set; }

    /// <summary>
    /// Общее количество экипажа
    /// </summary>
    public int TotalCrew { get; set; }

    /// <summary>
    /// Общий доход
    /// </summary>
    public decimal TotalRevenue { get; set; }
}