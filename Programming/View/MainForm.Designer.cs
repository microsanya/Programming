namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControlOfItems = new TabControl();
            EnumsTabPage = new TabPage();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            enumsChecking1 = new View.Panels.EnumsChecking();
            ClassesTabPage = new TabPage();
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
            RectanglesGroupBox = new GroupBox();
            IdTextBox = new TextBox();
            idLabel = new Label();
            YTextBox = new TextBox();
            XTextBox = new TextBox();
            CenterYLabel = new Label();
            CenterXLabel = new Label();
            CenterMainLabel = new Label();
            FindRectangleButton = new Button();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            LengthTextBox = new TextBox();
            LengthLabel = new Label();
            RectangleListBox = new ListBox();
            RectanglesTabPage = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            seasonControl1 = new View.Panels.SeasonControl();
            TabControlOfItems.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            FilmGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlOfItems
            // 
            TabControlOfItems.Controls.Add(EnumsTabPage);
            TabControlOfItems.Controls.Add(ClassesTabPage);
            TabControlOfItems.Controls.Add(RectanglesTabPage);
            TabControlOfItems.Dock = DockStyle.Fill;
            TabControlOfItems.Location = new Point(0, 0);
            TabControlOfItems.Name = "TabControlOfItems";
            TabControlOfItems.SelectedIndex = 0;
            TabControlOfItems.Size = new Size(839, 586);
            TabControlOfItems.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(seasonControl1);
            EnumsTabPage.Controls.Add(weekdayParsingControl1);
            EnumsTabPage.Controls.Add(enumsChecking1);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(831, 553);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(0, 391);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(415, 162);
            weekdayParsingControl1.TabIndex = 15;
            // 
            // enumsChecking1
            // 
            enumsChecking1.Location = new Point(0, 0);
            enumsChecking1.Name = "enumsChecking1";
            enumsChecking1.Size = new Size(831, 395);
            enumsChecking1.TabIndex = 14;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(FilmGroupBox);
            ClassesTabPage.Controls.Add(RectanglesGroupBox);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(831, 553);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
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
            FilmGroupBox.Location = new Point(461, 6);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(351, 362);
            FilmGroupBox.TabIndex = 1;
            FilmGroupBox.TabStop = false;
            FilmGroupBox.Text = "Films";
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(162, 315);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(94, 29);
            FilmFindButton.TabIndex = 11;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            FilmFindButton.Click += FilmFindButton_Click;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(162, 249);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 10;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(162, 226);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 9;
            RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(162, 196);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 8;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(162, 173);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre:";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(162, 143);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 6;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(162, 120);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(40, 20);
            YearLabel.TabIndex = 5;
            YearLabel.Text = "Year:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(162, 90);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 4;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(162, 67);
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
            FilmNameTextBox.TextChanged += FilmNameTextBox_TextChanged;
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
            FilmsListBox.Size = new Size(150, 324);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(idLabel);
            RectanglesGroupBox.Controls.Add(YTextBox);
            RectanglesGroupBox.Controls.Add(XTextBox);
            RectanglesGroupBox.Controls.Add(CenterYLabel);
            RectanglesGroupBox.Controls.Add(CenterXLabel);
            RectanglesGroupBox.Controls.Add(CenterMainLabel);
            RectanglesGroupBox.Controls.Add(FindRectangleButton);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(RectangleListBox);
            RectanglesGroupBox.Location = new Point(19, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(351, 362);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(162, 282);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(57, 27);
            IdTextBox.TabIndex = 14;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(162, 256);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 13;
            idLabel.Text = "ID:";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(237, 226);
            YTextBox.Name = "YTextBox";
            YTextBox.ReadOnly = true;
            YTextBox.Size = new Size(57, 27);
            YTextBox.TabIndex = 12;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(162, 226);
            XTextBox.Name = "XTextBox";
            XTextBox.ReadOnly = true;
            XTextBox.Size = new Size(57, 27);
            XTextBox.TabIndex = 11;
            // 
            // CenterYLabel
            // 
            CenterYLabel.AutoSize = true;
            CenterYLabel.Location = new Point(237, 203);
            CenterYLabel.Name = "CenterYLabel";
            CenterYLabel.Size = new Size(19, 20);
            CenterYLabel.TabIndex = 10;
            CenterYLabel.Text = "y:";
            // 
            // CenterXLabel
            // 
            CenterXLabel.AutoSize = true;
            CenterXLabel.Location = new Point(164, 203);
            CenterXLabel.Name = "CenterXLabel";
            CenterXLabel.Size = new Size(19, 20);
            CenterXLabel.TabIndex = 9;
            CenterXLabel.Text = "x:";
            // 
            // CenterMainLabel
            // 
            CenterMainLabel.AutoSize = true;
            CenterMainLabel.Location = new Point(159, 183);
            CenterMainLabel.Name = "CenterMainLabel";
            CenterMainLabel.Size = new Size(55, 20);
            CenterMainLabel.TabIndex = 8;
            CenterMainLabel.Text = "Center:";
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.FlatStyle = FlatStyle.System;
            FindRectangleButton.Location = new Point(162, 315);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 7;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(162, 152);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(162, 129);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(162, 99);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 4;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(162, 76);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 3;
            WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(162, 46);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(162, 23);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 1;
            LengthLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.ItemHeight = 20;
            RectangleListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox.Location = new Point(6, 20);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(150, 324);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(rectanglesCollisionControl1);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(831, 553);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(825, 547);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // seasonControl1
            // 
            seasonControl1.Location = new Point(409, 393);
            seasonControl1.Name = "seasonControl1";
            seasonControl1.Size = new Size(422, 157);
            seasonControl1.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 586);
            Controls.Add(TabControlOfItems);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            TabControlOfItems.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlOfItems;
        private TabPage EnumsTabPage;
        private TabPage ClassesTabPage;
        private GroupBox RectanglesGroupBox;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private ListBox RectangleListBox;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private Button FindRectangleButton;
        private GroupBox FilmGroupBox;
        private ListBox FilmsListBox;
        private Label DurationLabel;
        private TextBox FilmNameTextBox;
        private Label NameLabel;
        private TextBox DurationTextBox;
        private Label YearLabel;
        private TextBox YearTextBox;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private Button FilmFindButton;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Label CenterYLabel;
        private Label CenterXLabel;
        private Label CenterMainLabel;
        private TextBox IdTextBox;
        private Label idLabel;
        private TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumsChecking enumsChecking1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonControl seasonControl1;
    }
}