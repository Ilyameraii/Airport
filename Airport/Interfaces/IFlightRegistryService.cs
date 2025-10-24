using System.ComponentModel;

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
        BindingList<IFlightInfo> Flights { get; }
    }
}
