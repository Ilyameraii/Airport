
using Airport.Services.Contracts;
using Airport.UserControls;

namespace Airport.Forms
{
    /// <summary>
    /// Главная форма, для ведения реестра рейсов и просмотра отчетов о рейсах
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly WorkerControl workerControl;
        private readonly AdministratorControl administratorControl;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flights">Список рейсов</param>
        /// <param name="reportingService">Сервис отчета реестра</param>
        public MainForm(IFlightRegistryService flightRegistryService, IReportInfo reportInfo)
        {
            InitializeComponent();

            workerControl = new(flightRegistryService);
            workerControl.Dock = DockStyle.Fill;
            workerControl.OnExitClicked = () => CloseUserControl(workerControl);

            administratorControl = new(reportInfo);
            administratorControl.Dock = DockStyle.Fill;

            administratorControl.OnExitClicked = () => CloseUserControl(administratorControl);
        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {

            ShowUserControl(workerControl);

        }

        private void ShowUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                Controls.Add(userControl);
                userControl.BringToFront();
            }

        }

        private void CloseUserControl(UserControl userControl)
        {
            if (userControl != null)
            {
                Controls.Remove(userControl);
            }
        }

        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
            administratorControl.RefreshData();
            ShowUserControl(administratorControl);
        }
    }
}
