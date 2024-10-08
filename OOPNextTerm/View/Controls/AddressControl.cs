using OOPNextTerm.View.Tabes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPNextTerm.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Будущий адрес.
        /// </summary>
        public AddressControl NewAddress;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _customerAddress;

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address CustomerAddress
        {
            get
            {
                return _customerAddress;
            }
            set
            {
                _customerAddress = value;
            }
        }

        /// <summary>
        /// Инициализация AddressControl();
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            CustomerAddress = new Address();
        }

        /// <summary>
        /// Переменная для проверки, что листбокс не пустой.
        /// </summary>
        public bool ListBoxIsNull = false;

        /// <summary>
        /// Обновляет данные в пользовательском элементе управления на основе текущих значений свойства <see cref="CustomerAddress"/>.
        /// </summary>
        public void UpdateData(Address SomeAddress)
        {
            NewAddress.CustomerAddress = SomeAddress;

            IndexTextBox.Text = Convert.ToString(NewAddress.CustomerAddress.Index);
            CountryTextBox.Text = NewAddress.CustomerAddress.Country;
            CityTextBox.Text = NewAddress.CustomerAddress.City;
            StreetTextBox.Text = NewAddress.CustomerAddress.Street;
            BuildingTextBox.Text = NewAddress.CustomerAddress.Building;
            ApartmentTextBox.Text = Convert.ToString(NewAddress.CustomerAddress.Apartment);
        }

        /// <summary>
        /// Очистка формы.
        /// </summary>
        public void ClearForm()
        {
            IndexTextBox.Text = "0";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        /// <summary>
        /// Валидация строки с индексом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IndexTextBox.Text.Length < 7)
            {
                IndexTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.Index = Convert.ToInt32(IndexTextBox.Text);
            }
            else
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Валидация строки со страной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextBox.Text.Length < 50)
            {
                CountryTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.Country = CountryTextBox.Text;
            }
            else
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Валидация строки с городом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text.Length < 50)
            {
                CityTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.City = CityTextBox.Text;
            }
            else
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Валидация строки с улицей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StreetTextBox.Text.Length < 100)
            {
                StreetTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.Street = StreetTextBox.Text;
            }
            else
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Валидация строки со домом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingTextBox.Text.Length < 10)
            {
                BuildingTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.Building = BuildingTextBox.Text;
            }
            else
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Валидация строки с квартирой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ApartmentTextBox.Text.Length < 10)
            {
                ApartmentTextBox.BackColor = Color.White;
                NewAddress.CustomerAddress.Apartment = Convert.ToInt32(ApartmentTextBox.Text);
            }
            else
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Прогрузка формы со значениями.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
            IndexTextBox.Text = NewAddress.CustomerAddress.Index.ToString();
        }

        /// <summary>
        /// Конструктор для передачи адреса.
        /// </summary>
        /// <param name="address"></param>
        public AddressControl(Address address)
        {
            CustomerAddress = address;
        }
    }
}
