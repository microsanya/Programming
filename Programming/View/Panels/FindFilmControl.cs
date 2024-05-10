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
        /// <summary>
        /// Инициализация объекта формы и фильмов с помощью FilmInitialize().
        /// </summary>
        public FindFilmControl()
        {
            InitializeComponent();
            FilmInitialize(_films);
        }

        // необходимые дополнительные переменные и методы ---------------------------------------
        /// <summary>
        /// Закрытое поле, хранящее массив фильмов.
        /// </summary>
        private Film[] _films = new Film[5];
        /// <summary>
        /// Ранее созданный фильм.
        /// </summary>
        private Film _currentFilm = new Film();

        /// <summary>
        /// Инициализация массива фильмов.
        /// </summary>
        /// <param name="films">Массив фильмов.</param>
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
        /// <summary>
        /// Поиск фильма с наибольшим рейтингом
        /// </summary>
        /// <param name="films">Массив фильмов.</param>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
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
        /// <summary>
        /// Вывод значений выбранных фильмов при выборе их в FilmsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// При изменении имени, изменение его и в массиве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// При изменении длительности, изменение её и в массиве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// При изменении года, изменение его и в массиве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// При изменении жанра, изменение его и в массиве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// При изменении рейтинга, изменение его и в массиве.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Функция кнопки поиска фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int indexMaxFilm = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = indexMaxFilm;
        }
    }
}
