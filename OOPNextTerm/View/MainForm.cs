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
        }

    }

}
