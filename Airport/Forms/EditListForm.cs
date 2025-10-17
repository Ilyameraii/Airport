using Airport.Interfaces;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.Forms
{
    public partial class EditListForm : Form
    {
        public Flight? ResultFlight { get; private set; } = null!;

        public EditListForm()
        {
            InitializeComponent();
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