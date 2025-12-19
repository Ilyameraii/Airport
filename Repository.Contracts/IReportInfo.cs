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
        Task<int> TotalPassangersAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Сумма всех рейсов
        /// </summary>
        Task<int> TotalArrivingFlightsAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Сумма всех экипажей
        /// </summary>
        Task<int> TotalCrewAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Суммарная выручка
        /// </summary>
        Task<decimal> TotalRevenueAsync(CancellationToken cancellationToken);
    }
}
