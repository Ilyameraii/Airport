using Airport.Interfaces;
using System.ComponentModel.DataAnnotations;

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
            ArrivalTime = DateTime.Now;
            NumberOfPassengers = 1;
            NumberOfCrew = 1;

        }

        /// <summary>
        /// Айди рейса
        /// </summary>
        public Guid ID { get; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        [Required(ErrorMessage = "Тип обязателен для заполнения")]
        public string AirplaneType { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        [Required(ErrorMessage = "Количество пассажиров обязательно для заполнения")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        [Required(ErrorMessage ="Количество пассажиров обязательно для заполнения")]
        [Range(1,int.MaxValue,ErrorMessage = "Минимальное количество пассажиров - 1")]
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        [Required(ErrorMessage = "Сбор на пассажира обязателен для заполнения")]
        public decimal PassengerTax { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        [Required(ErrorMessage = "Количество экипажа обязательно для заполнения")]
        [Range(1, int.MaxValue, ErrorMessage = "Минимальное количество экипажа - 1")]
        public int NumberOfCrew { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        [Required(ErrorMessage = "Сбор на экипаж обязателен для заполнения")]
        public decimal CrewTax { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        [Required(ErrorMessage = "Процент обслуживания обязателен для заполнения")]
        public decimal ServicePercentage { get; set; }

        /// <summary>
        /// Выручка
        /// </summary>
        public decimal Revenue => (NumberOfPassengers * PassengerTax + NumberOfCrew * CrewTax) * (1.0m + ServicePercentage);
    }
}
