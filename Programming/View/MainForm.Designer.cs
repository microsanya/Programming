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
            TabControlOfEnums = new TabControl();
            Enums = new TabPage();
            ParsingInputingLabel = new Label();
            ParsingWeekdayButton = new Button();
            ParsingWeekdayTextbox = new TextBox();
            ParsingLabelNaming = new Label();
            IntingValueLabel = new Label();
            ValueLabel = new Label();
            EnumarationLabel = new Label();
            IntingValueTextbox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            ParsingAnswer = new Label();
            TabControlOfEnums.SuspendLayout();
            Enums.SuspendLayout();
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
            Enums.Controls.Add(ParsingAnswer);
            Enums.Controls.Add(ParsingWeekdayButton);
            Enums.Controls.Add(ParsingWeekdayTextbox);
            Enums.Controls.Add(ParsingInputingLabel);
            Enums.Controls.Add(ParsingLabelNaming);
            Enums.Controls.Add(IntingValueLabel);
            Enums.Controls.Add(ValueLabel);
            Enums.Controls.Add(EnumarationLabel);
            Enums.Controls.Add(IntingValueTextbox);
            Enums.Controls.Add(ValuesListBox);
            Enums.Controls.Add(EnumsListBox);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(831, 655);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // ParsingInputingLabel
            // 
            ParsingInputingLabel.AutoSize = true;
            ParsingInputingLabel.Location = new Point(29, 439);
            ParsingInputingLabel.Name = "ParsingInputingLabel";
            ParsingInputingLabel.Size = new Size(158, 20);
            ParsingInputingLabel.TabIndex = 7;
            ParsingInputingLabel.Text = "Type value for parsing:";
            // 
            // ParsingWeekdayButton
            // 
            ParsingWeekdayButton.Location = new Point(302, 460);
            ParsingWeekdayButton.Name = "ParsingWeekdayButton";
            ParsingWeekdayButton.Size = new Size(94, 29);
            ParsingWeekdayButton.TabIndex = 9;
            ParsingWeekdayButton.Text = "Parse";
            ParsingWeekdayButton.UseVisualStyleBackColor = true;
            ParsingWeekdayButton.Click += ParsingWeekdayButton_Click;
            // 
            // ParsingWeekdayTextbox
            // 
            ParsingWeekdayTextbox.Location = new Point(29, 462);
            ParsingWeekdayTextbox.Name = "ParsingWeekdayTextbox";
            ParsingWeekdayTextbox.Size = new Size(267, 27);
            ParsingWeekdayTextbox.TabIndex = 8;
            // 
            // ParsingLabelNaming
            // 
            ParsingLabelNaming.AutoSize = true;
            ParsingLabelNaming.Location = new Point(8, 410);
            ParsingLabelNaming.Name = "ParsingLabelNaming";
            ParsingLabelNaming.Size = new Size(122, 20);
            ParsingLabelNaming.TabIndex = 6;
            ParsingLabelNaming.Text = "Weekday parsing";
            // 
            // IntingValueLabel
            // 
            IntingValueLabel.AutoSize = true;
            IntingValueLabel.Location = new Point(421, 8);
            IntingValueLabel.Name = "IntingValueLabel";
            IntingValueLabel.Size = new Size(68, 20);
            IntingValueLabel.TabIndex = 5;
            IntingValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(229, 8);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(100, 20);
            ValueLabel.TabIndex = 4;
            ValueLabel.Text = "Choose value:";
            // 
            // EnumarationLabel
            // 
            EnumarationLabel.AutoSize = true;
            EnumarationLabel.Location = new Point(29, 8);
            EnumarationLabel.Name = "EnumarationLabel";
            EnumarationLabel.Size = new Size(149, 20);
            EnumarationLabel.TabIndex = 3;
            EnumarationLabel.Text = "Choose enumaration:";
            // 
            // IntingValueTextbox
            // 
            IntingValueTextbox.Location = new Point(421, 39);
            IntingValueTextbox.Name = "IntingValueTextbox";
            IntingValueTextbox.Size = new Size(125, 27);
            IntingValueTextbox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(229, 39);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(186, 344);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneManufactures", "Weekday" });
            EnumsListBox.Location = new Point(29, 39);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(194, 344);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // ParsingAnswer
            // 
            ParsingAnswer.AutoSize = true;
            ParsingAnswer.Location = new Point(29, 501);
            ParsingAnswer.Name = "ParsingAnswer";
            ParsingAnswer.Size = new Size(53, 20);
            ParsingAnswer.TabIndex = 10;
            ParsingAnswer.Text = "           ";
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
            Enums.PerformLayout();
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
        private Label ParsingLabelNaming;
        private Button ParsingWeekdayButton;
        private TextBox ParsingWeekdayTextbox;
        private Label ParsingInputingLabel;
        private Label ParsingAnswer;
    }
}