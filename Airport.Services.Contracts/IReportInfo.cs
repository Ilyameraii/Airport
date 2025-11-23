namespace Airport.Services.Contracts
{
    /// <summary>
    /// Интерфейс, предоставляющий информацию для отчёта по рейсам
    /// </summary>
    public interface IReportInfo
    {

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        Task<int> TotalPassangers();

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        Task<int> TotalArrivingFlights();

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        Task<int> TotalCrew();

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        Task<decimal> TotalRevenue();
    }
}
