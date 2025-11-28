namespace Repository.Contracts
{
    /// <summary>
    /// Интерфейс, предоставляющий информацию для отчёта по рейсам
    /// </summary>
    public interface IReportInfo
    {

        /// <summary>
        /// Сумма всех пассажиров
        /// </summary>
        Task<int> TotalPassangers(CancellationToken cancellationToken);

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        Task<int> TotalArrivingFlights(CancellationToken cancellationToken);

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        Task<int> TotalCrew(CancellationToken cancellationToken);

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        Task<decimal> TotalRevenue(CancellationToken cancellationToken);
    }
}
