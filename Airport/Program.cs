using Airport.Interfaces;
using Airport.Services;
using System.ComponentModel;
using Airport.Forms;

namespace Airport
{
    /// <summary>
    /// Класс Program - точка входа в программу
    /// </summary>
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
            var reportingService = new ReportingService(flights);

            Application.Run(new MainForm(flights, reportingService));
        }
    }
}