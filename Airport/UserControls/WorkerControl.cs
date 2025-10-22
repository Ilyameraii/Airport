using Airport.Forms;
using Airport.Interfaces;
using Airport.Models;
using Airport.Services;
using System.ComponentModel;

namespace Airport.UserControls
{
    public partial class WorkerControl : UserControl
    {
        private readonly BindingSource bindingSource = new();

        private readonly IFlightRegistryService flightRegistryService= null!;

        private IFlightInfo? selectedFlight = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="flightRegistryService">Сервис реестра рейсов</param>
        /// <param name="flights">Список рейсов</param>
        public WorkerControl(IFlightRegistryService flightRegistryService)
        {
            InitializeComponent();

            // устанавливаем сервис
            this.flightRegistryService = flightRegistryService;

            // устанавливаем источник datagridview через BindingSource
            bindingSource.DataSource = flightRegistryService.Flights;
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
                flightRegistryService.AddFlight(editListForm.ResultFlight);
                UpdateData(); // сервис уже изменил коллекцию
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
                UpdateData(); // сервис уже изменил коллекцию
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // кнопка не будет срабатывать, если не конкретный рейс не выбран
            if (selectedFlight == null)
            {
                return;
            }
            flightRegistryService.DeleteFlight(selectedFlight.ID);
            UpdateData(); // сервис уже изменил коллекцию
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
