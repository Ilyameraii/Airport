using Airport.Services.Contracts;
using System.Threading;

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
        }
        private async void AdministratorControl_Load(object sender, EventArgs e)
        {
            await RefreshData();
        }
        /// <summary>
        /// Метод для обновления данных отчета
        /// </summary>
        public async Task RefreshData()
        {
            var totalPassangers = await reportingService.TotalPassangers(CancellationToken.None);
            var totalArrivingFlights = await reportingService.TotalArrivingFlights(CancellationToken.None);
            var totalCrew = await reportingService.TotalCrew(CancellationToken.None);
            var totalRevenue = await reportingService.TotalRevenue(CancellationToken.None);

            // Просто перечитываем значения из сервиса
            textBoxTotalPassangers.Text = totalPassangers.ToString();
            textBoxTotalArrivingFlights.Text = totalArrivingFlights.ToString();
            textBoxTotalCrew.Text = totalCrew.ToString();
            textBoxTotalRevenue.Text = totalRevenue.ToString("C");
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
