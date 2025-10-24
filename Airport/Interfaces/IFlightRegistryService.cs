namespace Airport.Interfaces
{
    /// <summary>
    /// Интерфейс, предоставляющий функциональность для управления реестром рейсов:
    /// получение списка рейсов, добавление нового рейса и удаление существующего.
    /// </summary>
    public interface IFlightRegistryService
    {

        /// <summary>
        ///  Возвращает коллекцию информации о рейсах.
        /// </summary>
        IEnumerable<IFlightInfo> Flights { get; }

        /// <summary>
        /// Метод добавления рейса
        /// </summary>
        /// <param name="flight">Рейс, который хотим добавить</param>
        void AddFlight(IFlightInfo flight);

        /// <summary>
        /// Метод удаления рейса
        /// </summary>
        /// <param name="flight">Выбранный рейс, который хотим удалить</param>
        void DeleteFlight(IFlightInfo flight);
    }
}
