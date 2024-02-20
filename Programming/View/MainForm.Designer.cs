﻿namespace Programming
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
            TabControlOfEnums = new TabControl();
            Enums = new TabPage();
            ParsingAnswer = new Label();
            EnumarationsGroupBox = new GroupBox();
            EnumarationLabel = new Label();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            IntingValueLabel = new Label();
            IntingValueTextbox = new TextBox();
            WeekdayParsingGroupBox = new GroupBox();
            ParsingInputingLabel = new Label();
            ParsingWeekdayButton = new Button();
            ParsingWeekdayTextbox = new TextBox();
            SeasonHandleGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            ChooseSeasonLabel = new Label();
            TabControlOfEnums.SuspendLayout();
            Enums.SuspendLayout();
            EnumarationsGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlOfEnums
            // 
            TabControlOfEnums.Controls.Add(Enums);
            TabControlOfEnums.Dock = DockStyle.Fill;
            TabControlOfEnums.Location = new Point(0, 0);
            TabControlOfEnums.Name = "TabControlOfEnums";
            TabControlOfEnums.SelectedIndex = 0;
            TabControlOfEnums.Size = new Size(839, 688);
            TabControlOfEnums.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(EnumarationsGroupBox);
            Enums.Controls.Add(WeekdayParsingGroupBox);
            Enums.Controls.Add(SeasonHandleGroupBox);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(831, 655);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
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
            EnumarationsGroupBox.Size = new Size(805, 426);
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
            EnumsListBox.Size = new Size(194, 344);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(211, 46);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(186, 344);
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
            WeekdayParsingGroupBox.Location = new Point(18, 438);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(397, 178);
            WeekdayParsingGroupBox.TabIndex = 12;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
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
            SeasonHandleGroupBox.Location = new Point(421, 438);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(402, 178);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 688);
            Controls.Add(TabControlOfEnums);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            TabControlOfEnums.ResumeLayout(false);
            Enums.ResumeLayout(false);
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlOfEnums;
        private TabPage Enums;
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
    }
}