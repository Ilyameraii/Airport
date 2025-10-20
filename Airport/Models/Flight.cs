using Airport.Interfaces;

namespace Airport.Models
{
    public class Flight : IFlightInfo
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        public Flight() {
            ID = Guid.NewGuid();
            AirplaneType = "Неизвестный";


        }

        /// <summary>
        /// Айди рейса
        /// </summary>
        public Guid ID { get; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        public string AirplaneType { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        public decimal PassengerTax { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        public int NumberOfCrew { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        public decimal CrewTax { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        public decimal ServicePercentage { get; set; }

        /// <summary>
        /// Выручка
        /// </summary>
        public decimal Revenue => (NumberOfPassengers * PassengerTax + NumberOfCrew * CrewTax) * (1.0m + ServicePercentage);
    }
}
