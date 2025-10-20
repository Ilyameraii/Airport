using Airport.Interfaces;
using Airport.UserControls;

namespace Airport
{
    public partial class MainForm : Form
    {

        private readonly WorkerControl workerControl;
        private readonly AdministratorControl administratorControl;


        public MainForm(IEnumerable<IFlightInfo> flights, IFlightRegistryService flightRegistryService, IReportInfo reportingService)
        {
            InitializeComponent();

            workerControl = new(flightRegistryService);
            workerControl.Dock = DockStyle.Fill;
            workerControl.OnExitClicked = () => CloseUserControl(workerControl);

            administratorControl = new(reportingService);
            administratorControl.Dock = DockStyle.Fill;

            administratorControl.OnExitClicked = () => CloseUserControl(administratorControl);
        }

        private void buttonWorker_Click(object sender, EventArgs rrrrrrre)
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
