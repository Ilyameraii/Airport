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
            // устанавливаем источник datagridview через BindingSource
            bindingSource.DataSource = flights;
            dataGridView.DataSource = bindingSource;
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
