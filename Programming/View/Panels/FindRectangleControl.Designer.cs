namespace Programming.View.Panels
{
    partial class FindRectangleControl
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
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
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
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(400, 552);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(164, 412);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(57, 27);
            IdTextBox.TabIndex = 14;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(162, 389);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 13;
            idLabel.Text = "ID:";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(225, 323);
            YTextBox.Name = "YTextBox";
            YTextBox.ReadOnly = true;
            YTextBox.Size = new Size(57, 27);
            YTextBox.TabIndex = 12;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(162, 323);
            XTextBox.Name = "XTextBox";
            XTextBox.ReadOnly = true;
            XTextBox.Size = new Size(57, 27);
            XTextBox.TabIndex = 11;
            // 
            // CenterYLabel
            // 
            CenterYLabel.AutoSize = true;
            CenterYLabel.Location = new Point(225, 300);
            CenterYLabel.Name = "CenterYLabel";
            CenterYLabel.Size = new Size(19, 20);
            CenterYLabel.TabIndex = 10;
            CenterYLabel.Text = "y:";
            // 
            // CenterXLabel
            // 
            CenterXLabel.AutoSize = true;
            CenterXLabel.Location = new Point(162, 300);
            CenterXLabel.Name = "CenterXLabel";
            CenterXLabel.Size = new Size(19, 20);
            CenterXLabel.TabIndex = 9;
            CenterXLabel.Text = "x:";
            // 
            // CenterMainLabel
            // 
            CenterMainLabel.AutoSize = true;
            CenterMainLabel.Location = new Point(164, 280);
            CenterMainLabel.Name = "CenterMainLabel";
            CenterMainLabel.Size = new Size(55, 20);
            CenterMainLabel.TabIndex = 8;
            CenterMainLabel.Text = "Center:";
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.FlatStyle = FlatStyle.System;
            FindRectangleButton.Location = new Point(162, 515);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(94, 29);
            FindRectangleButton.TabIndex = 7;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(162, 216);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(162, 193);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(162, 130);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 4;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(162, 107);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 3;
            WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(162, 43);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 2;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(162, 20);
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
            RectangleListBox.Size = new Size(150, 524);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // FindRectangleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "FindRectangleControl";
            Size = new Size(406, 558);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private TextBox IdTextBox;
        private Label idLabel;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Label CenterYLabel;
        private Label CenterXLabel;
        private Label CenterMainLabel;
        private Button FindRectangleButton;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private ListBox RectangleListBox;
    }
}
