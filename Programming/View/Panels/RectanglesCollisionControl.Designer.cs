namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            RectanglesNewGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CanvaPanel
            // 
            CanvaPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvaPanel.Location = new Point(371, 27);
            CanvaPanel.Name = "CanvaPanel";
            CanvaPanel.Size = new Size(459, 507);
            CanvaPanel.TabIndex = 30;
            // 
            // HeightTextBoxNew
            // 
            HeightTextBoxNew.Location = new Point(81, 473);
            HeightTextBoxNew.Name = "HeightTextBoxNew";
            HeightTextBoxNew.Size = new Size(125, 27);
            HeightTextBoxNew.TabIndex = 29;
            HeightTextBoxNew.TextChanged += HeightTextBoxNew_TextChanged;
            // 
            // WidthTextBoxNew
            // 
            WidthTextBoxNew.Location = new Point(81, 440);
            WidthTextBoxNew.Name = "WidthTextBoxNew";
            WidthTextBoxNew.Size = new Size(125, 27);
            WidthTextBoxNew.TabIndex = 28;
            WidthTextBoxNew.TextChanged += WidthTextBoxNew_TextChanged;
            // 
            // YTextBoxNew
            // 
            YTextBoxNew.Enabled = false;
            YTextBoxNew.Location = new Point(81, 403);
            YTextBoxNew.Name = "YTextBoxNew";
            YTextBoxNew.Size = new Size(125, 27);
            YTextBoxNew.TabIndex = 27;
            // 
            // XTextBoxNew
            // 
            XTextBoxNew.Enabled = false;
            XTextBoxNew.Location = new Point(81, 370);
            XTextBoxNew.Name = "XTextBoxNew";
            XTextBoxNew.Size = new Size(125, 27);
            XTextBoxNew.TabIndex = 26;
            // 
            // IDTextBoxNew
            // 
            IDTextBoxNew.Enabled = false;
            IDTextBoxNew.Location = new Point(81, 336);
            IDTextBoxNew.Name = "IDTextBoxNew";
            IDTextBoxNew.Size = new Size(125, 27);
            IDTextBoxNew.TabIndex = 25;
            // 
            // HeightLabelNew
            // 
            HeightLabelNew.AutoSize = true;
            HeightLabelNew.Location = new Point(23, 476);
            HeightLabelNew.Name = "HeightLabelNew";
            HeightLabelNew.Size = new Size(57, 20);
            HeightLabelNew.TabIndex = 24;
            HeightLabelNew.Text = "Height:";
            // 
            // WidthLabelNew
            // 
            WidthLabelNew.AutoSize = true;
            WidthLabelNew.Location = new Point(23, 443);
            WidthLabelNew.Name = "WidthLabelNew";
            WidthLabelNew.Size = new Size(52, 20);
            WidthLabelNew.TabIndex = 23;
            WidthLabelNew.Text = "Width:";
            // 
            // YLabelNew
            // 
            YLabelNew.AutoSize = true;
            YLabelNew.Location = new Point(23, 406);
            YLabelNew.Name = "YLabelNew";
            YLabelNew.Size = new Size(20, 20);
            YLabelNew.TabIndex = 22;
            YLabelNew.Text = "Y:";
            // 
            // XLabelNew
            // 
            XLabelNew.AutoSize = true;
            XLabelNew.Location = new Point(23, 373);
            XLabelNew.Name = "XLabelNew";
            XLabelNew.Size = new Size(21, 20);
            XLabelNew.TabIndex = 21;
            XLabelNew.Text = "X:";
            // 
            // IdLabelNew
            // 
            IdLabelNew.AutoSize = true;
            IdLabelNew.Location = new Point(23, 339);
            IdLabelNew.Name = "IdLabelNew";
            IdLabelNew.Size = new Size(27, 20);
            IdLabelNew.TabIndex = 20;
            IdLabelNew.Text = "ID:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(23, 309);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 19;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.BackgroundImage = Properties.Resources.remove_rectangle;
            DeleteRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteRectangleButton.FlatStyle = FlatStyle.Flat;
            DeleteRectangleButton.Location = new Point(192, 236);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(42, 40);
            DeleteRectangleButton.TabIndex = 18;
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.BackgroundImage = Properties.Resources.add_rectangle;
            AddRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.ImageAlign = ContentAlignment.TopLeft;
            AddRectangleButton.Location = new Point(105, 236);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(42, 40);
            AddRectangleButton.TabIndex = 17;
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // RectanglesNewGroupBox
            // 
            RectanglesNewGroupBox.Controls.Add(RectanglesViewlistBox);
            RectanglesNewGroupBox.Controls.Add(AddRectangleButton);
            RectanglesNewGroupBox.Controls.Add(DeleteRectangleButton);
            RectanglesNewGroupBox.Location = new Point(15, 18);
            RectanglesNewGroupBox.Name = "RectanglesNewGroupBox";
            RectanglesNewGroupBox.Size = new Size(350, 288);
            RectanglesNewGroupBox.TabIndex = 31;
            RectanglesNewGroupBox.TabStop = false;
            RectanglesNewGroupBox.Text = "Rectangles:";
            // 
            // RectanglesViewlistBox
            // 
            RectanglesViewlistBox.FormattingEnabled = true;
            RectanglesViewlistBox.ItemHeight = 20;
            RectanglesViewlistBox.Location = new Point(0, 26);
            RectanglesViewlistBox.Name = "RectanglesViewlistBox";
            RectanglesViewlistBox.Size = new Size(344, 204);
            RectanglesViewlistBox.TabIndex = 0;
            RectanglesViewlistBox.SelectedIndexChanged += RectanglesViewlistBox_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvaPanel);
            Controls.Add(HeightTextBoxNew);
            Controls.Add(WidthTextBoxNew);
            Controls.Add(YTextBoxNew);
            Controls.Add(XTextBoxNew);
            Controls.Add(IDTextBoxNew);
            Controls.Add(HeightLabelNew);
            Controls.Add(WidthLabelNew);
            Controls.Add(YLabelNew);
            Controls.Add(XLabelNew);
            Controls.Add(IdLabelNew);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(RectanglesNewGroupBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(845, 560);
            RectanglesNewGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CanvaPanel;
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
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private GroupBox RectanglesNewGroupBox;
        private ListBox RectanglesViewlistBox;
    }
}
