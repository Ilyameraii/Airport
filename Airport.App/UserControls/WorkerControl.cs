using Airport.Entites.Models;
using Airport.Forms;
using Airport.Services.Contracts;

namespace Airport.UserControls
{
    /// <summary>
    /// UI работника, в котором можно управлять реестром рейсов и просматривать информацию об этом реестре
    /// </summary>
    public partial class WorkerControl : UserControl
    {
        /// <summary>
        /// Событие закрытия этого контрола
        /// </summary>
        public Action? OnExitClicked { get; set; }

        private readonly BindingSource bindingSource = new();
        private Flight? selectedFlight;
        private readonly IFlightRegistryService flightRegistryService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flights">Список рейсов</param>
        public WorkerControl(IFlightRegistryService flightRegistryService)
        {
            InitializeComponent();
            
            this.flightRegistryService = flightRegistryService;

            dataGridView.AutoGenerateColumns = false;
            // устанавливаем источник datagridview через BindingSource
            bindingSource.DataSource = flightRegistryService.GetAll();
            dataGridView.DataSource = bindingSource;

            GenerateFieldsOfDataGridView();
        }

        private void GenerateFieldsOfDataGridView()
        {
            // Стандартные колонки (привязаны к свойствам Flight)
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.AirplaneType),
                HeaderText = "Тип самолёта",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.ArrivalTime),
                HeaderText = "Время прибытия",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.NumberOfPassengers),
                HeaderText = "Пассажиров",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.PassengerTax),
                HeaderText = "Сбор на пассажира",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.NumberOfCrew),
                HeaderText = "Экипажа",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.CrewTax),
                HeaderText = "Сбор на экипаж",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Flight.ServicePercentage),
                HeaderText = "Процент за обслуживание",
                ReadOnly = true
            });
            // НЕПРИВЯЗАННАЯ колонка для выручки
            var revenueColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Выручка",
                Name = "RevenueColumn",
                ReadOnly = true
            };
            dataGridView.Columns.Add(revenueColumn);

            // Подписываемся на событие для вычисления значения
            dataGridView.CellFormatting += DataGridView_CellFormatting;
        }

        private void DataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что форматируем именно колонку выручки
            if (dataGridView.Columns[e.ColumnIndex].Name == "RevenueColumn")
            {
                if (dataGridView.Rows[e.RowIndex].DataBoundItem is Flight flight)
                {
                    var baseRevenue = flight.NumberOfPassengers * flight.PassengerTax +
                                      flight.NumberOfCrew * flight.CrewTax;
                    var surcharge = baseRevenue * (flight.ServicePercentage / 100m);
                    var revenue = Math.Round(baseRevenue + surcharge, 2);

                    e.Value = revenue.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        
        
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            OnExitClicked?.Invoke();
        }

        private void UpdateData()
        {
            // обновляем список
            bindingSource.ResetBindings(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using var editListForm = new EditListForm();
            if (editListForm.ShowDialog() == DialogResult.OK)
            {
                if (editListForm.ResultFlight == null)
                {
                    return;
                }
                flightRegistryService.AddFlight(editListForm.ResultFlight);
                UpdateData();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // кнопка не будет срабатывать, если не конкретный рейс не выбран
            if (selectedFlight == null)
            {
                return;
            }
            using var editListForm = new EditListForm(selectedFlight);
            if (editListForm.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // кнопка не будет срабатывать, если не конкретный рейс не выбран
            if (selectedFlight == null)
            {
                return;
            }
            flightRegistryService.DeleteFlight(selectedFlight);
            UpdateData();
        }

        // выбор самолета для редактирования/удаления
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Игнорируем клик по заголовкам (e.RowIndex < 0)
            if (e.RowIndex < 0)
            {
                return; 
            }

            // Получаем строку, по которой кликнули
            var row = dataGridView.Rows[e.RowIndex];

            // Получаем привязанный объект
            if (row.DataBoundItem is Flight flight)
            {
                selectedFlight = flight;
            }
        }
    }
}
