using Airport.Interfaces;

namespace Airport.UserControls
{
    /// <summary>
    /// UI администратора, который показывает отчет реестра
    /// </summary>
    public partial class AdministratorControl : UserControl
    {
        private readonly IReportInfo reportingService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="reportingService">Сервис отчета</param>
        public AdministratorControl(IReportInfo reportingService)
        {
            InitializeComponent();

            this.reportingService = reportingService;
            RefreshData(); // инициализация
        }

        /// <summary>
        /// Метод для обновления данных отчета
        /// </summary>
        public void RefreshData()
        {
            // Просто перечитываем значения из сервиса
            textBoxTotalPassangers.Text = reportingService.TotalPassangers.ToString();
            textBoxTotalArrivingFlights.Text = reportingService.TotalArrivingFlights.ToString();
            textBoxTotalCrew.Text = reportingService.TotalCrew.ToString();
            textBoxTotalRevenue.Text = reportingService.TotalRevenue.ToString();
        }

        /// <summary>
        /// Событие закрытия этого контрола
        /// </summary>
        public Action? OnExitClicked { get; set; }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            OnExitClicked?.Invoke();
        }
    }
}
