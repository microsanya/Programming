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
            EnumarationsGroupBox = new GroupBox();
            EnumarationLabel = new Label();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            IntingValueLabel = new Label();
            IntingValueTextbox = new TextBox();
            WeekdayParsingGroupBox = new GroupBox();
            ParsingAnswer = new Label();
            ParsingInputingLabel = new Label();
            ParsingWeekdayButton = new Button();
            ParsingWeekdayTextbox = new TextBox();
            SeasonHandleGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            ChooseSeasonLabel = new Label();
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
            CanvaPanel = new Panel();
            HeightTextBoxNew = new TextBox();
            WidthTextBoxNew = new TextBox();
            YTextBoxNew = new TextBox();
            XTextBoxNew = new TextBox();
            IDTextBoxNew = new TextBox();
            HeightLabelNew = new Label();
            WidthLabelNew = new Label();
            YLabelNew = new Label();
            XLabelNew = new Label();
            IdLabelNew = new Label();
            SelectedRectangleLabel = new Label();
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            RectanglesNewGroupBox = new GroupBox();
            RectanglesViewlistBox = new ListBox();
            TabControlOfItems.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            EnumarationsGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            FilmGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            RectanglesNewGroupBox.SuspendLayout();
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
            TabControlOfItems.Size = new Size(839, 552);
            TabControlOfItems.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(EnumarationsGroupBox);
            EnumsTabPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsTabPage.Controls.Add(SeasonHandleGroupBox);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(831, 519);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumarationsGroupBox
            // 
            EnumarationsGroupBox.Controls.Add(EnumarationLabel);
            EnumarationsGroupBox.Controls.Add(ValueLabel);
            EnumarationsGroupBox.Controls.Add(EnumsListBox);
            EnumarationsGroupBox.Controls.Add(ValuesListBox);
            EnumarationsGroupBox.Controls.Add(IntingValueLabel);
            EnumarationsGroupBox.Controls.Add(IntingValueTextbox);
            EnumarationsGroupBox.Location = new Point(18, 6);
            EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            EnumarationsGroupBox.Size = new Size(792, 389);
            EnumarationsGroupBox.TabIndex = 11;
            EnumarationsGroupBox.TabStop = false;
            EnumarationsGroupBox.Text = "Enumarations";
            // 
            // EnumarationLabel
            // 
            EnumarationLabel.AutoSize = true;
            EnumarationLabel.Location = new Point(11, 23);
            EnumarationLabel.Name = "EnumarationLabel";
            EnumarationLabel.Size = new Size(149, 20);
            EnumarationLabel.TabIndex = 3;
            EnumarationLabel.Text = "Choose enumaration:";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(211, 23);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(100, 20);
            ValueLabel.TabIndex = 4;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneManufactures", "Weekday" });
            EnumsListBox.Location = new Point(11, 46);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(194, 324);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(211, 46);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(186, 324);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // IntingValueLabel
            // 
            IntingValueLabel.AutoSize = true;
            IntingValueLabel.Location = new Point(403, 23);
            IntingValueLabel.Name = "IntingValueLabel";
            IntingValueLabel.Size = new Size(68, 20);
            IntingValueLabel.TabIndex = 5;
            IntingValueLabel.Text = "Int value:";
            // 
            // IntingValueTextbox
            // 
            IntingValueTextbox.Location = new Point(403, 46);
            IntingValueTextbox.Name = "IntingValueTextbox";
            IntingValueTextbox.Size = new Size(125, 27);
            IntingValueTextbox.TabIndex = 2;
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(ParsingAnswer);
            WeekdayParsingGroupBox.Controls.Add(ParsingInputingLabel);
            WeekdayParsingGroupBox.Controls.Add(ParsingWeekdayButton);
            WeekdayParsingGroupBox.Controls.Add(ParsingWeekdayTextbox);
            WeekdayParsingGroupBox.Location = new Point(18, 401);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(397, 110);
            WeekdayParsingGroupBox.TabIndex = 12;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingAnswer
            // 
            ParsingAnswer.AutoSize = true;
            ParsingAnswer.Location = new Point(11, 90);
            ParsingAnswer.Name = "ParsingAnswer";
            ParsingAnswer.Size = new Size(53, 20);
            ParsingAnswer.TabIndex = 10;
            ParsingAnswer.Text = "           ";
            // 
            // ParsingInputingLabel
            // 
            ParsingInputingLabel.AutoSize = true;
            ParsingInputingLabel.Location = new Point(11, 37);
            ParsingInputingLabel.Name = "ParsingInputingLabel";
            ParsingInputingLabel.Size = new Size(158, 20);
            ParsingInputingLabel.TabIndex = 7;
            ParsingInputingLabel.Text = "Type value for parsing:";
            // 
            // ParsingWeekdayButton
            // 
            ParsingWeekdayButton.Location = new Point(284, 59);
            ParsingWeekdayButton.Name = "ParsingWeekdayButton";
            ParsingWeekdayButton.Size = new Size(94, 29);
            ParsingWeekdayButton.TabIndex = 9;
            ParsingWeekdayButton.Text = "Parse";
            ParsingWeekdayButton.UseVisualStyleBackColor = true;
            ParsingWeekdayButton.Click += ParsingWeekdayButton_Click;
            // 
            // ParsingWeekdayTextbox
            // 
            ParsingWeekdayTextbox.Location = new Point(11, 60);
            ParsingWeekdayTextbox.Name = "ParsingWeekdayTextbox";
            ParsingWeekdayTextbox.Size = new Size(267, 27);
            ParsingWeekdayTextbox.TabIndex = 8;
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(GoButton);
            SeasonHandleGroupBox.Controls.Add(SeasonsComboBox);
            SeasonHandleGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonHandleGroupBox.Location = new Point(421, 401);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(402, 110);
            SeasonHandleGroupBox.TabIndex = 13;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(163, 58);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonsComboBox.Location = new Point(6, 60);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(151, 28);
            SeasonsComboBox.TabIndex = 1;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.ImageAlign = ContentAlignment.TopCenter;
            ChooseSeasonLabel.Location = new Point(6, 37);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(110, 20);
            ChooseSeasonLabel.TabIndex = 0;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(FilmGroupBox);
            ClassesTabPage.Controls.Add(RectanglesGroupBox);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(831, 519);
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
            RectanglesTabPage.Controls.Add(CanvaPanel);
            RectanglesTabPage.Controls.Add(HeightTextBoxNew);
            RectanglesTabPage.Controls.Add(WidthTextBoxNew);
            RectanglesTabPage.Controls.Add(YTextBoxNew);
            RectanglesTabPage.Controls.Add(XTextBoxNew);
            RectanglesTabPage.Controls.Add(IDTextBoxNew);
            RectanglesTabPage.Controls.Add(HeightLabelNew);
            RectanglesTabPage.Controls.Add(WidthLabelNew);
            RectanglesTabPage.Controls.Add(YLabelNew);
            RectanglesTabPage.Controls.Add(XLabelNew);
            RectanglesTabPage.Controls.Add(IdLabelNew);
            RectanglesTabPage.Controls.Add(SelectedRectangleLabel);
            RectanglesTabPage.Controls.Add(DeleteRectangleButton);
            RectanglesTabPage.Controls.Add(AddRectangleButton);
            RectanglesTabPage.Controls.Add(RectanglesNewGroupBox);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(831, 519);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // CanvaPanel
            // 
            CanvaPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvaPanel.Location = new Point(364, 6);
            CanvaPanel.Name = "CanvaPanel";
            CanvaPanel.Size = new Size(459, 507);
            CanvaPanel.TabIndex = 15;
            // 
            // HeightTextBoxNew
            // 
            HeightTextBoxNew.Location = new Point(64, 460);
            HeightTextBoxNew.Name = "HeightTextBoxNew";
            HeightTextBoxNew.Size = new Size(125, 27);
            HeightTextBoxNew.TabIndex = 14;
            HeightTextBoxNew.TextChanged += HeightTextBoxNew_TextChanged;
            // 
            // WidthTextBoxNew
            // 
            WidthTextBoxNew.Location = new Point(64, 427);
            WidthTextBoxNew.Name = "WidthTextBoxNew";
            WidthTextBoxNew.Size = new Size(125, 27);
            WidthTextBoxNew.TabIndex = 13;
            WidthTextBoxNew.TextChanged += WidthTextBoxNew_TextChanged;
            // 
            // YTextBoxNew
            // 
            YTextBoxNew.Enabled = false;
            YTextBoxNew.Location = new Point(64, 394);
            YTextBoxNew.Name = "YTextBoxNew";
            YTextBoxNew.Size = new Size(125, 27);
            YTextBoxNew.TabIndex = 12;
            // 
            // XTextBoxNew
            // 
            XTextBoxNew.Enabled = false;
            XTextBoxNew.Location = new Point(64, 361);
            XTextBoxNew.Name = "XTextBoxNew";
            XTextBoxNew.Size = new Size(125, 27);
            XTextBoxNew.TabIndex = 11;
            // 
            // IDTextBoxNew
            // 
            IDTextBoxNew.Enabled = false;
            IDTextBoxNew.Location = new Point(64, 329);
            IDTextBoxNew.Name = "IDTextBoxNew";
            IDTextBoxNew.Size = new Size(125, 27);
            IDTextBoxNew.TabIndex = 10;
            // 
            // HeightLabelNew
            // 
            HeightLabelNew.AutoSize = true;
            HeightLabelNew.Location = new Point(8, 463);
            HeightLabelNew.Name = "HeightLabelNew";
            HeightLabelNew.Size = new Size(57, 20);
            HeightLabelNew.TabIndex = 9;
            HeightLabelNew.Text = "Height:";
            // 
            // WidthLabelNew
            // 
            WidthLabelNew.AutoSize = true;
            WidthLabelNew.Location = new Point(8, 430);
            WidthLabelNew.Name = "WidthLabelNew";
            WidthLabelNew.Size = new Size(52, 20);
            WidthLabelNew.TabIndex = 8;
            WidthLabelNew.Text = "Width:";
            // 
            // YLabelNew
            // 
            YLabelNew.AutoSize = true;
            YLabelNew.Location = new Point(8, 397);
            YLabelNew.Name = "YLabelNew";
            YLabelNew.Size = new Size(20, 20);
            YLabelNew.TabIndex = 7;
            YLabelNew.Text = "Y:";
            // 
            // XLabelNew
            // 
            XLabelNew.AutoSize = true;
            XLabelNew.Location = new Point(8, 364);
            XLabelNew.Name = "XLabelNew";
            XLabelNew.Size = new Size(21, 20);
            XLabelNew.TabIndex = 6;
            XLabelNew.Text = "X:";
            // 
            // IdLabelNew
            // 
            IdLabelNew.AutoSize = true;
            IdLabelNew.Location = new Point(8, 332);
            IdLabelNew.Name = "IdLabelNew";
            IdLabelNew.Size = new Size(27, 20);
            IdLabelNew.TabIndex = 5;
            IdLabelNew.Text = "ID:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(8, 297);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 4;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.BackgroundImage = Properties.Resources.remove_rectangle;
            DeleteRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(196, 239);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(42, 40);
            DeleteRectangleButton.TabIndex = 3;
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.BackgroundImage = Properties.Resources.add_rectangle;
            AddRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.ImageAlign = ContentAlignment.TopLeft;
            AddRectangleButton.Location = new Point(123, 239);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(42, 40);
            AddRectangleButton.TabIndex = 2;
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // RectanglesNewGroupBox
            // 
            RectanglesNewGroupBox.Controls.Add(RectanglesViewlistBox);
            RectanglesNewGroupBox.Location = new Point(8, 6);
            RectanglesNewGroupBox.Name = "RectanglesNewGroupBox";
            RectanglesNewGroupBox.Size = new Size(350, 288);
            RectanglesNewGroupBox.TabIndex = 16;
            RectanglesNewGroupBox.TabStop = false;
            RectanglesNewGroupBox.Text = "Rectangles:";
            // 
            // RectanglesViewlistBox
            // 
            RectanglesViewlistBox.FormattingEnabled = true;
            RectanglesViewlistBox.ItemHeight = 20;
            RectanglesViewlistBox.Location = new Point(6, 23);
            RectanglesViewlistBox.Name = "RectanglesViewlistBox";
            RectanglesViewlistBox.Size = new Size(335, 204);
            RectanglesViewlistBox.TabIndex = 0;
            RectanglesViewlistBox.SelectedIndexChanged += RectanglesViewlistBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 552);
            Controls.Add(TabControlOfItems);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            TabControlOfItems.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            ClassesTabPage.ResumeLayout(false);
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            RectanglesTabPage.PerformLayout();
            RectanglesNewGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlOfItems;
        private TabPage EnumsTabPage;
        private ListBox EnumsListBox;
        private Label IntingValueLabel;
        private Label ValueLabel;
        private Label EnumarationLabel;
        private TextBox IntingValueTextbox;
        private ListBox ValuesListBox;
        private Button ParsingWeekdayButton;
        private TextBox ParsingWeekdayTextbox;
        private Label ParsingInputingLabel;
        private Label ParsingAnswer;
        private GroupBox EnumarationsGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private GroupBox SeasonHandleGroupBox;
        private Label ChooseSeasonLabel;
        private ComboBox SeasonsComboBox;
        private Button GoButton;
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
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private ListBox RectanglesViewlistBox;
        private TextBox HeightTextBoxNew;
        private TextBox WidthTextBoxNew;
        private TextBox YTextBoxNew;
        private TextBox XTextBoxNew;
        private TextBox IDTextBoxNew;
        private Label HeightLabelNew;
        private Label WidthLabelNew;
        private Label YLabelNew;
        private Label XLabelNew;
        private Label IdLabelNew;
        private Label SelectedRectangleLabel;
        private Panel CanvaPanel;
        private GroupBox RectanglesNewGroupBox;
    }
}