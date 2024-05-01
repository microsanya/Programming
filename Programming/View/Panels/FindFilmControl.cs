using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class FindFilmControl : UserControl
    {
        public FindFilmControl()
        {
            InitializeComponent();
            FilmInitialize(_films);
        }
        // необходимые дополнительные переменные и методы ---------------------------------------
        // ФИЛЬМЫ
        // закрытое поле, хранящее массив фильмов
        private Film[] _films = new Film[5];
        // ранее созданный фильм
        private Film _currentFilm = new Film();
        //инициализация массива фильмов
        private void FilmInitialize(Film[] films)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            for (int i = 0; i < 5; ++i)
            {
                films[i] = new Film(Convert.ToString((FilmNames)rnd.Next(0, 7)), rnd.Next(1, 300), rnd.Next(1900, 2024),
                    Convert.ToString((Genre)rnd.Next(0, 5)), rnd.Next(1, 10));
            }
        }
        // поиск фильма с наибольшим рейтингом
        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxRating = 0;
            int indexMaxFilm = 0;
            for (int i = 0; i < films.Length; ++i)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    indexMaxFilm = i;
                }
            }
            return indexMaxFilm;
        }
        // вывод значений выбранных фильмов при выборе их в FilmsListBox
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedItem != null)
            {
                _currentFilm = _films[FilmsListBox.SelectedIndex];
                FilmNameTextBox.Text = Convert.ToString(_currentFilm.Name);
                DurationTextBox.Text = Convert.ToString(_currentFilm.Duration);
                YearTextBox.Text = Convert.ToString(_currentFilm.Year);
                GenreTextBox.Text = Convert.ToString(_currentFilm.Genre);
                RatingTextBox.Text = Convert.ToString(_currentFilm.Rating);
            }
        }
        // при изменении имени, изменение его и в массиве
        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // проверка на то, не ввел ли пользователь вместо текста число
            bool isNumber = int.TryParse(FilmNameTextBox.Text, out int numericValue);
            if (isNumber == false)
            {
                _films[FilmsListBox.SelectedIndex].Name = Convert.ToString(FilmNameTextBox.Text);
                FilmNameTextBox.BackColor = AppColors.Standart;
            }
            else
            {
                FilmNameTextBox.BackColor = AppColors.Error;
            }
        }
        // при изменении длительности, изменение её и в массиве
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(DurationTextBox.Text) > 0)
                {
                    _films[FilmsListBox.SelectedIndex].Duration = Convert.ToInt32(DurationTextBox.Text);
                    DurationTextBox.BackColor = AppColors.Standart;
                }
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.Error;
            }
        }
        // при изменении года, изменение его и в массиве
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(YearTextBox.Text) >= 1900 && Convert.ToInt32(YearTextBox.Text) <= 2024)
                {
                    _films[FilmsListBox.SelectedIndex].Year = Convert.ToInt32(YearTextBox.Text);
                    YearTextBox.BackColor = AppColors.Standart;
                }
            }
            catch
            {
                YearTextBox.BackColor = AppColors.Error;
            }
        }
        // при изменении жанра, изменение его и в массиве
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            // проверка на то, не ввел ли пользователь вместо текста число
            bool isNumber = int.TryParse(GenreTextBox.Text, out int numericValue);
            if (isNumber == false)
            {
                _films[FilmsListBox.SelectedIndex].Genre = Convert.ToString(GenreTextBox.Text);
                GenreTextBox.BackColor = AppColors.Standart;
            }
            else
            {
                GenreTextBox.BackColor = AppColors.Error;
            }
        }
        // при изменении рейтинга, изменение его и в массиве
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(RatingTextBox.Text) >= 0 && Convert.ToInt32(RatingTextBox.Text) <= 10)
                {
                    _films[FilmsListBox.SelectedIndex].Rating = Convert.ToInt32(RatingTextBox.Text);
                    RatingTextBox.BackColor = AppColors.Standart;
                }
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.Error;
            }
        }
        // функция кнопки поиска фильма с наибольшим рейтингом
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int indexMaxFilm = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = indexMaxFilm;
        }
    }
}
