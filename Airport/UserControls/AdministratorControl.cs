using Airport.Extensions;
using Airport.Interfaces;
using Airport.Services;

namespace Airport.UserControls
{
    public partial class AdministratorControl : UserControl
    {
        private readonly IReportInfo reportingService;
        public AdministratorControl(IReportInfo reportingService)
        {
            InitializeComponent();

            this.reportingService = reportingService;
            RefreshData(); // инициализация
        }

        // 🔁 Публичный метод для обновления
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            OnExitClicked?.Invoke();
        }
    }
}
