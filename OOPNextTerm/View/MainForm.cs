using OOPNextTerm.View.Tabes;
using System.Windows.Forms;

namespace OOPNextTerm
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Store _store = new Store();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab1.Items = _store.Items;
            CartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;

            ItemsTab.ItemsChanged += ItemsChanged;
        }

        private void MainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartsTab1.RefreshData();
            ordersTab1.RefreshData();
        }

        /// <summary>
        /// Изменение даты при обновлении информации о предмете.
        /// </summary>
        private void ItemsChanged(object? sender, EventArgs e)
        {
            CartsTab1.RefreshData();
            ordersTab1.RefreshData();
        }
    }

}
