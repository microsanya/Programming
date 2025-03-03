namespace OOPNextTerm.View.Tabes
{
    partial class PriorityOrdersTab
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
            Address address3 = new Address();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedOrderGroupBox = new GroupBox();
            CreatedPicked = new DateTimePicker();
            DelTimeComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            IdTextBox = new TextBox();
            DelTimeLabel = new Label();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IDLabel = new Label();
            OrderItemsGroupBox = new GroupBox();
            ClearOrderButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            TotalLabel = new Label();
            AmountLabel = new Label();
            ItemsListBox = new ListBox();
            DeliveryAddressControl = new Controls.AddressControl();
            tableLayoutPanel1.SuspendLayout();
            SelectedOrderGroupBox.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SelectedOrderGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(OrderItemsGroupBox, 0, 2);
            tableLayoutPanel1.Controls.Add(DeliveryAddressControl, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.7289047F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.2710953F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 307F));
            tableLayoutPanel1.Size = new Size(852, 765);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(CreatedPicked);
            SelectedOrderGroupBox.Controls.Add(DelTimeComboBox);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(DelTimeLabel);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IDLabel);
            SelectedOrderGroupBox.Dock = DockStyle.Fill;
            SelectedOrderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedOrderGroupBox.Location = new Point(3, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(846, 189);
            SelectedOrderGroupBox.TabIndex = 0;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "SelectedOrder";
            // 
            // CreatedPicked
            // 
            CreatedPicked.Enabled = false;
            CreatedPicked.Location = new Point(94, 89);
            CreatedPicked.Name = "CreatedPicked";
            CreatedPicked.Size = new Size(196, 27);
            CreatedPicked.TabIndex = 8;
            // 
            // DelTimeComboBox
            // 
            DelTimeComboBox.FormattingEnabled = true;
            DelTimeComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DelTimeComboBox.Location = new Point(528, 36);
            DelTimeComboBox.Name = "DelTimeComboBox";
            DelTimeComboBox.Size = new Size(196, 28);
            DelTimeComboBox.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "New", "Processing", "Assembly", "Sent", "Delivered", "Returned", "Abandoned" });
            StatusComboBox.Location = new Point(94, 137);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(196, 28);
            StatusComboBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(94, 36);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(196, 27);
            IdTextBox.TabIndex = 4;
            // 
            // DelTimeLabel
            // 
            DelTimeLabel.AutoSize = true;
            DelTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DelTimeLabel.Location = new Point(419, 39);
            DelTimeLabel.Name = "DelTimeLabel";
            DelTimeLabel.Size = new Size(103, 20);
            DelTimeLabel.TabIndex = 3;
            DelTimeLabel.Text = "Delivery Time:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.Location = new Point(6, 140);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedLabel.Location = new Point(6, 89);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 1;
            CreatedLabel.Text = "Created:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(6, 39);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Controls.Add(ClearOrderButton);
            OrderItemsGroupBox.Controls.Add(RemoveButton);
            OrderItemsGroupBox.Controls.Add(AddButton);
            OrderItemsGroupBox.Controls.Add(TotalLabel);
            OrderItemsGroupBox.Controls.Add(AmountLabel);
            OrderItemsGroupBox.Controls.Add(ItemsListBox);
            OrderItemsGroupBox.Dock = DockStyle.Fill;
            OrderItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderItemsGroupBox.Location = new Point(3, 460);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Size = new Size(846, 302);
            OrderItemsGroupBox.TabIndex = 2;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "OrderItems";
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.FlatStyle = FlatStyle.Popup;
            ClearOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearOrderButton.Location = new Point(493, 212);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(135, 55);
            ClearOrderButton.TabIndex = 5;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.FlatStyle = FlatStyle.Popup;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(166, 212);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(135, 55);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(6, 212);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(135, 55);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(725, 229);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(69, 46);
            TotalLabel.TabIndex = 2;
            TotalLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(769, 196);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(71, 20);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "Amount:";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(6, 35);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(834, 144);
            ItemsListBox.TabIndex = 0;
            // 
            // DeliveryAddressControl
            // 
            address3.Apartment = 0;
            address3.Building = " ";
            address3.City = " ";
            address3.Country = " ";
            address3.Index = 0;
            address3.Street = " ";
            DeliveryAddressControl.CustomerAddress = address3;
            DeliveryAddressControl.Location = new Point(3, 198);
            DeliveryAddressControl.Name = "DeliveryAddressControl";
            DeliveryAddressControl.Size = new Size(846, 256);
            DeliveryAddressControl.TabIndex = 3;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(852, 765);
            tableLayoutPanel1.ResumeLayout(false);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            OrderItemsGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SelectedOrderGroupBox;
        private Label DelTimeLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IDLabel;
        private GroupBox groupBox2;
        private GroupBox OrderItemsGroupBox;
        private TextBox IdTextBox;
        private ComboBox StatusComboBox;
        private ComboBox DelTimeComboBox;
        private Controls.AddressControl DeliveryAddressControl;
        private Button ClearOrderButton;
        private Button RemoveButton;
        private Button AddButton;
        private Label TotalLabel;
        private Label AmountLabel;
        private ListBox ItemsListBox;
        private DateTimePicker CreatedPicked;
    }
}
