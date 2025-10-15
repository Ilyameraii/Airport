using Airport.Interfaces;
using Airport.Models;
using Airport.Services;

namespace Airport.UserControls
{
    public partial class WorkerControl : UserControl
    {
        private readonly List<IFlightInfo> items;
        private readonly BindingSource bindingSource = new();
        private readonly FlightRegistryService flightRegistryService;
        public WorkerControl(List<IFlightInfo> flights)
        {
            InitializeComponent();

            items = flights;

            flightRegistryService = new FlightRegistryService(items);

            bindingSource.DataSource = items;

            dataGridView1.DataSource = bindingSource;

            flightRegistryService.AddFlight(new Flight
            {
                AirplaneType = "Абоба",
                ArrivalTime = DateTime.Now,
                NumberOfPassengers = 5,
                PassengerTax = 5,
                NumberOfCrew = 3,
                CrewTax = 3,
                ServicePercentage = 1.1m,
            });

            bindingSource.ResetBindings(false);
        }

        public Action? OnButtonClicked { get; set; }
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            OnButtonClicked?.Invoke();
        }
    }
}
