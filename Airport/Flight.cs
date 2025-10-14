using Airport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Flight : IFlightInfo
    {
        public Flight(string airplaneType, DateTime arrivalTime, int numberOfPassengers,
            decimal passengerTax, int numberOfCrew, decimal crewTax, decimal servicePercentage)
        {
            ID = Guid.NewGuid();
            AirplaneType = airplaneType;
            ArrivalTime = arrivalTime;
            NumberOfPassengers = numberOfPassengers;
            PassengerTax = passengerTax;
            NumberOfCrew = numberOfCrew;
            CrewTax = crewTax;
            ServicePercentage = servicePercentage;
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


        public decimal Revenue => (NumberOfPassengers * PassengerTax + NumberOfCrew * CrewTax) * (1.0m + ServicePercentage);
    }
}
