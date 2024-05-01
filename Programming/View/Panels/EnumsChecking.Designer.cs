namespace Programming.View.Panels
{
    partial class EnumsChecking
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
            EnumarationsGroupBox = new GroupBox();
            EnumarationLabel = new Label();
            ValueLabel = new Label();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            IntingValueLabel = new Label();
            IntingValueTextbox = new TextBox();
            EnumarationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumarationsGroupBox
            // 
            EnumarationsGroupBox.Controls.Add(EnumarationLabel);
            EnumarationsGroupBox.Controls.Add(ValueLabel);
            EnumarationsGroupBox.Controls.Add(EnumsListBox);
            EnumarationsGroupBox.Controls.Add(ValuesListBox);
            EnumarationsGroupBox.Controls.Add(IntingValueLabel);
            EnumarationsGroupBox.Controls.Add(IntingValueTextbox);
            EnumarationsGroupBox.Location = new Point(3, 3);
            EnumarationsGroupBox.Name = "EnumarationsGroupBox";
            EnumarationsGroupBox.Size = new Size(811, 389);
            EnumarationsGroupBox.TabIndex = 12;
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
            // EnumsChecking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumarationsGroupBox);
            Name = "EnumsChecking";
            Size = new Size(819, 396);
            EnumarationsGroupBox.ResumeLayout(false);
            EnumarationsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumarationsGroupBox;
        private Label EnumarationLabel;
        private Label ValueLabel;
        private ListBox EnumsListBox;
        private ListBox ValuesListBox;
        private Label IntingValueLabel;
        private TextBox IntingValueTextbox;
    }
}
