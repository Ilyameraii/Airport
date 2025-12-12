using Airport.Forms;
using Microsoft.Extensions.Logging;
using Repository;
using Serilog;
using Services;

namespace Airport.App
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
            var databaseStorage = new DatabaseStorage();

            Directory.CreateDirectory("logs");
            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs/app.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Seq(
                     serverUrl: "http://localhost:5341",   
                     apiKey: "wupjwOk7CesZUYreEBlH")       
                .CreateLogger();

            // Создаём фабрику Microsoft.Extensions.Logging поверх Serilog
            var loggerFactory = new LoggerFactory().AddSerilog(serilogLogger);

            var flightLogger = loggerFactory.CreateLogger<FlightRegistryService>();
            var reportLogger = loggerFactory.CreateLogger<ReportInfoService>();

            var flightRegistryService = new FlightRegistryService(databaseStorage, flightLogger);
            var reportInfoService = new ReportInfoService(databaseStorage, reportLogger);


            Application.Run(new MainForm(flightRegistryService, reportInfoService));
        }
    }
}