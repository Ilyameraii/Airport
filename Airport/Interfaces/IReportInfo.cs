namespace Airport.Interfaces
{
    /// <summary>
    /// Интерфейс, предоставляющий информацию для отчёта по рейсам
    /// </summary>
    public interface IReportInfo
    {

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        int TotalPassangers { get; }

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        int TotalArrivingFlights { get; }

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        int TotalCrew { get; }

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        decimal TotalRevenue { get; }
    }
}
