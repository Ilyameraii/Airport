namespace Airport.Interfaces
{
    /// <summary>
    /// Интерфейс, предоставляющий информацию о рейсе
    /// </summary>
    public interface IFlightInfo
    {
        /// <summary>
        /// Айди рейса
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        string AirplaneType { get; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        DateTime ArrivalTime { get; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        int NumberOfPassengers { get; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        decimal PassengerTax { get; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        int NumberOfCrew { get; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        decimal CrewTax { get; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        decimal ServicePercentage { get; }
    }
}
