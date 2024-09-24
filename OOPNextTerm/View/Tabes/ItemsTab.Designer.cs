namespace OOPNextTerm.View.Tabs
{
    partial class ItemsTab
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
            ItemsListBox = new ListBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ItemsListGroupBox = new GroupBox();
            SelectedItemGroupBox = new GroupBox();
            DescriptionTextBox = new TextBox();
            DecriptionLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            CostLabel = new Label();
            IDLabel = new Label();
            IdTextBox = new TextBox();
            ItemsListGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(378, 524);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.FlatStyle = FlatStyle.Popup;
            AddItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.Location = new Point(6, 560);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(157, 53);
            AddItemButton.TabIndex = 2;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.FlatStyle = FlatStyle.Popup;
            RemoveItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(227, 560);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(157, 53);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ItemsListGroupBox
            // 
            ItemsListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListGroupBox.Controls.Add(AddItemButton);
            ItemsListGroupBox.Controls.Add(ItemsListBox);
            ItemsListGroupBox.Controls.Add(RemoveItemButton);
            ItemsListGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsListGroupBox.Location = new Point(0, 0);
            ItemsListGroupBox.Name = "ItemsListGroupBox";
            ItemsListGroupBox.Size = new Size(391, 625);
            ItemsListGroupBox.TabIndex = 4;
            ItemsListGroupBox.TabStop = false;
            ItemsListGroupBox.Text = "Items";
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(DecriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IDLabel);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemGroupBox.Location = new Point(403, 0);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(560, 625);
            SelectedItemGroupBox.TabIndex = 5;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(6, 310);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(548, 303);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // DecriptionLabel
            // 
            DecriptionLabel.AutoSize = true;
            DecriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DecriptionLabel.Location = new Point(6, 287);
            DecriptionLabel.Name = "DecriptionLabel";
            DecriptionLabel.Size = new Size(88, 20);
            DecriptionLabel.TabIndex = 6;
            DecriptionLabel.Text = "Descriprion:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 153);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(548, 105);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(6, 130);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(65, 79);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(125, 27);
            CostTextBox.TabIndex = 3;
            CostTextBox.KeyPress += CostTextBox_KeyPress;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostLabel.Location = new Point(6, 86);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(6, 43);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(65, 36);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsListGroupBox);
            Name = "ItemsTab";
            Size = new Size(963, 625);
            ItemsListGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox ItemsListBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private GroupBox ItemsListGroupBox;
        private GroupBox SelectedItemGroupBox;
        private Label IDLabel;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private Label CostLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox DescriptionTextBox;
        private Label DecriptionLabel;
    }
}
