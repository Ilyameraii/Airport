using Airport.Interfaces;
using Airport.Models;
using Airport.Services;
using System.ComponentModel;

namespace Airport
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Создаем зависимости вручную
            var flights = new BindingList<IFlightInfo>();
            var flightRegistryService = new FlightRegistryService(flights);
            var reportingService = new ReportingService(flights);

            Application.Run(new MainForm(flightRegistryService, reportingService));
        }
    }
}