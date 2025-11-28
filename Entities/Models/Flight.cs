using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    /// <summary>
    /// Модель рейса
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public Flight() {
            Id = Guid.NewGuid();
            AirplaneType = AirplaneType.Boing;
            ArrivalTime = DateTime.Now;
            NumberOfPassengers = 1;
            NumberOfCrew = 1;

        }

        /// <summary>
        /// Айди рейса
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        [Required(ErrorMessage = "Тип обязателен для заполнения")]
        public AirplaneType AirplaneType { get; set; }

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
    }
}
