using Airport.Forms;
using Microsoft.Extensions.Logging;
using Repository;
using Serilog;
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
            var inMemoryStorage = new InMemoryStorage();

            Directory.CreateDirectory("logs");
            var serilogLogger = new LoggerConfiguration()
                .WriteTo.File("logs/app.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            // Создаём фабрику Microsoft.Extensions.Logging поверх Serilog
            var loggerFactory = new LoggerFactory().AddSerilog(serilogLogger);

            var flightLogger = loggerFactory.CreateLogger<FlightRegistryService>();
            var reportLogger = loggerFactory.CreateLogger<ReportInfoService>();

            var flightRegistryService = new FlightRegistryService(inMemoryStorage, flightLogger);
            var reportInfoService = new ReportInfoService(inMemoryStorage, reportLogger);


            Application.Run(new MainForm(flightRegistryService, reportInfoService));
        }
    }
}