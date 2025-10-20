using Airport.Extensions;
using Airport.Interfaces;
using Airport.Models;

namespace Airport.Forms
{
    public partial class EditListForm : Form
    {
        private readonly IFlightInfo currentFlight = null!;

        /// <summary>
        /// Конструктор
        /// </summary>
        public EditListForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="currentFlight">Выбранный для редактирования рейс</param>
        public EditListForm(IFlightInfo currentFlight)
        {

            InitializeComponent();

            this.currentFlight = currentFlight;

            // биндим контролы
            AddBindingsForControls();

            // возвращать будем измененный currentFlight
            ResultFlight = currentFlight;

        }

        /// <summary>
        /// Результирующий рейс
        /// </summary>
        public IFlightInfo? ResultFlight { get; private set; }

        private void AddBindingsForControls()
        {
            airplaneTypePicker.AddBindings(x => x.Text, currentFlight, c => c.AirplaneType);
            arrivalTimePicker.AddBindings(x => x.Value, currentFlight, c => c.ArrivalTime);
            numberOfPassengersPicker.AddBindings(x => x.Value, currentFlight, c => c.NumberOfPassengers);
            passengerTaxPicker.AddBindings(x => x.Value, currentFlight, c => c.PassengerTax);
            numberOfCrewPicker.AddBindings(x => x.Value, currentFlight, c => c.NumberOfCrew);
            crewTaxPicker.AddBindings(x => x.Value, currentFlight, c => c.CrewTax);
            servicePercentagePicker.AddBindings(x => x.Value, currentFlight, c => c.ServicePercentage);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Заполнение данных рейса из введенных значений
            ResultFlight = new Flight
            {
                AirplaneType = airplaneTypePicker.Text,
                ArrivalTime = arrivalTimePicker.Value,
                NumberOfPassengers = (int)numberOfPassengersPicker.Value,
                PassengerTax = passengerTaxPicker.Value,
                NumberOfCrew = (int)numberOfCrewPicker.Value,
                CrewTax = crewTaxPicker.Value,
                ServicePercentage = servicePercentagePicker.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Вы уверены, что хотите очистить форму?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ClearForm();
            }

        }

        // очистка заполненной формы
        private void ClearForm()
        {
            airplaneTypePicker.Text = string.Empty;
            arrivalTimePicker.Value = DateTime.Now;
            numberOfPassengersPicker.Value = 0;
            passengerTaxPicker.Value = 0;
            numberOfCrewPicker.Value = 0;
            crewTaxPicker.Value = 0;
            servicePercentagePicker.Value = 0;
        }
    }
}