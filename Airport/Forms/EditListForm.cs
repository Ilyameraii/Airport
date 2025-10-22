using Airport.Extensions;
using Airport.Interfaces;
using Airport.Models;
using System.ComponentModel.DataAnnotations;

namespace Airport.Forms
{
    public partial class EditListForm : Form
    {
        private readonly IFlightInfo currentFlight = new Flight();

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

        }

        /// <summary>
        /// Результирующий рейс
        /// </summary>
        public IFlightInfo? ResultFlight { get; private set; }

        private void EditListForm_Load(object sender, EventArgs e)
        {
            AddBindingsForControls();
            arrivalTimePicker.MinDate = DateTime.Now;
            // Заполнение данных рейса из введенных значений
            ResultFlight = currentFlight;
        }

        private void AddBindingsForControls()
        {
            airplaneTypePicker.AddBindings(x => x.Text, currentFlight, c => c.AirplaneType, errorProvider);
            arrivalTimePicker.AddBindings(x => x.Value, currentFlight, c => c.ArrivalTime, errorProvider);
            numberOfPassengersPicker.AddBindings(x => x.Value, currentFlight, c => c.NumberOfPassengers, errorProvider);
            passengerTaxPicker.AddBindings(x => x.Value, currentFlight, c => c.PassengerTax, errorProvider);
            numberOfCrewPicker.AddBindings(x => x.Value, currentFlight, c => c.NumberOfCrew, errorProvider);
            crewTaxPicker.AddBindings(x => x.Value, currentFlight, c => c.CrewTax, errorProvider);
            servicePercentagePicker.AddBindings(x => x.Value, currentFlight, c => c.ServicePercentage, errorProvider);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ResultFlight == null)
            {
                return;
            }
            var context = new ValidationContext(ResultFlight);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(ResultFlight, context, results, true))
            {
                MessageBox.Show("У вас ошибки в заполнении данных","Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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