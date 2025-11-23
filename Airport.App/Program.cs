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
            var inMemoryStorage = new InMemoryStorage();

            Application.Run(new MainForm(inMemoryStorage, inMemoryStorage));
        }
    }
}