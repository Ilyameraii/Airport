using Airport.Forms;
using Repository;
using Services;

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
            var databaseContext = new DatabaseStorage();
            var flightRegistryService = new FlightRegistryService(databaseContext);
            var reportInfoService = new ReportInfoService(databaseContext);

            Application.Run(new MainForm(flightRegistryService, reportInfoService));
        }
    }
}