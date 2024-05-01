namespace Programming.View.Panels
{
    partial class FindFilmControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FilmGroupBox = new GroupBox();
            FilmFindButton = new Button();
            RatingTextBox = new TextBox();
            RatingLabel = new Label();
            GenreTextBox = new TextBox();
            GenreLabel = new Label();
            YearTextBox = new TextBox();
            YearLabel = new Label();
            DurationTextBox = new TextBox();
            DurationLabel = new Label();
            FilmNameTextBox = new TextBox();
            NameLabel = new Label();
            FilmsListBox = new ListBox();
            FilmGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmGroupBox
            // 
            FilmGroupBox.Controls.Add(FilmFindButton);
            FilmGroupBox.Controls.Add(RatingTextBox);
            FilmGroupBox.Controls.Add(RatingLabel);
            FilmGroupBox.Controls.Add(GenreTextBox);
            FilmGroupBox.Controls.Add(GenreLabel);
            FilmGroupBox.Controls.Add(YearTextBox);
            FilmGroupBox.Controls.Add(YearLabel);
            FilmGroupBox.Controls.Add(DurationTextBox);
            FilmGroupBox.Controls.Add(DurationLabel);
            FilmGroupBox.Controls.Add(FilmNameTextBox);
            FilmGroupBox.Controls.Add(NameLabel);
            FilmGroupBox.Controls.Add(FilmsListBox);
            FilmGroupBox.Location = new Point(0, 3);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(413, 552);
            FilmGroupBox.TabIndex = 2;
            FilmGroupBox.TabStop = false;
            FilmGroupBox.Text = "Films";
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(162, 515);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(94, 29);
            FilmFindButton.TabIndex = 11;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            FilmFindButton.Click += FilmFindButton_Click;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(162, 393);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 10;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(162, 370);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 9;
            RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(162, 307);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 8;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(162, 284);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre:";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(162, 219);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 6;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(162, 196);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(40, 20);
            YearLabel.TabIndex = 5;
            YearLabel.Text = "Year:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(162, 126);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 4;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(162, 103);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 3;
            DurationLabel.Text = "Duration:";
            // 
            // FilmNameTextBox
            // 
            FilmNameTextBox.Location = new Point(162, 37);
            FilmNameTextBox.Name = "FilmNameTextBox";
            FilmNameTextBox.Size = new Size(125, 27);
            FilmNameTextBox.TabIndex = 2;
            FilmNameTextBox.EnabledChanged += FilmNameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(162, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 20;
            FilmsListBox.Items.AddRange(new object[] { "Film 1", "Film 2", "Film 3", "Film 4", "Film 5" });
            FilmsListBox.Location = new Point(6, 20);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(150, 524);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // FindFilmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmGroupBox);
            Name = "FindFilmControl";
            Size = new Size(417, 556);
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmGroupBox;
        private Button FilmFindButton;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox YearTextBox;
        private Label YearLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox FilmNameTextBox;
        private Label NameLabel;
        private ListBox FilmsListBox;
    }
}
