namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            WeekdayParsingGroupBox = new GroupBox();
            ParsingAnswer = new Label();
            ParsingInputingLabel = new Label();
            ParsingWeekdayButton = new Button();
            ParsingWeekdayTextbox = new TextBox();
            WeekdayParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(ParsingAnswer);
            WeekdayParsingGroupBox.Controls.Add(ParsingInputingLabel);
            WeekdayParsingGroupBox.Controls.Add(ParsingWeekdayButton);
            WeekdayParsingGroupBox.Controls.Add(ParsingWeekdayTextbox);
            WeekdayParsingGroupBox.Location = new Point(3, 3);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(397, 118);
            WeekdayParsingGroupBox.TabIndex = 13;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingAnswer
            // 
            ParsingAnswer.AutoSize = true;
            ParsingAnswer.Location = new Point(11, 90);
            ParsingAnswer.Name = "ParsingAnswer";
            ParsingAnswer.Size = new Size(174, 20);
            ParsingAnswer.TabIndex = 10;
            ParsingAnswer.Text = "     ";
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
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParsingGroupBox);
            Name = "WeekdayParsingControl";
            Size = new Size(402, 125);
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayParsingGroupBox;
        private Label ParsingAnswer;
        private Label ParsingInputingLabel;
        private Button ParsingWeekdayButton;
        private TextBox ParsingWeekdayTextbox;
    }
}
