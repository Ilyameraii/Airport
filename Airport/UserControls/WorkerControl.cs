using Airport.Forms;
using Airport.Interfaces;
using System.ComponentModel;

namespace Airport.UserControls
{
    /// <summary>
    /// UI работника, в котором можно управлять реестром рейсов и просматривать информацию об этом реестре
    /// </summary>
    public partial class WorkerControl : UserControl
    {
        private readonly BindingSource bindingSource = new();

        private IFlightInfo? selectedFlight;

        private BindingList<IFlightInfo> flights;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flights">Список рейсов</param>
        public WorkerControl(BindingList<IFlightInfo> flights)
        {
            InitializeComponent();
            
            this.flights = flights;

            dataGridView.AutoGenerateColumns = false;
            // устанавливаем источник datagridview через BindingSource
            bindingSource.DataSource = flights;
            dataGridView.DataSource = bindingSource;

            GenerateFieldsOfDataGridView();
        }

        private void GenerateFieldsOfDataGridView()
        {
            // Стандартные колонки (привязаны к свойствам IFlightInfo)
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.AirplaneType),
                HeaderText = "Тип самолёта",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.ArrivalTime),
                HeaderText = "Время прибытия",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.NumberOfPassengers),
                HeaderText = "Пассажиров",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.PassengerTax),
                HeaderText = "Сбор на пассажира",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.NumberOfCrew),
                HeaderText = "Экипажа",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.CrewTax),
                HeaderText = "Сбор на экипаж",
                ReadOnly = true
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(IFlightInfo.ServicePercentage),
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
                if (dataGridView.Rows[e.RowIndex].DataBoundItem is IFlightInfo flight)
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

        /// <summary>
        /// Событие закрытия этого контрола
        /// </summary>
        public Action? OnExitClicked { get; set; }
        
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
                flights.Add(editListForm.ResultFlight);
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
            flights.Remove(selectedFlight);
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
            if (row.DataBoundItem is IFlightInfo flight)
            {
                selectedFlight = flight;
            }
        }
    }
}
