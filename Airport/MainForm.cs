using Airport.Interfaces;
using Airport.Models;
using Airport.Services;
using Airport.UserControls;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Airport
{
    public partial class MainForm : Form
    {
        // типа база данных рейсов
        private List<IFlightInfo> flights = new();

        private WorkerControl workerControl;

        public MainForm()
        {
            InitializeComponent();

            workerControl = new(flights);
            workerControl.Dock = DockStyle.Fill;
            workerControl.OnButtonClicked = () => CloseUserControl(workerControl);
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
    }
}
