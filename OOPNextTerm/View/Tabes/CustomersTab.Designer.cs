namespace OOPNextTerm.View.Tabes
{
    partial class CustomersTab
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
            Address address2 = new Address();
            CustomersGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            DiscountGroupBox = new GroupBox();
            RemoveDiscount = new Button();
            AddDiscount = new Button();
            DiscountsListBox = new ListBox();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            PriorityCheck = new CheckBox();
            CustomersPanel2 = new Panel();
            CustomersPanel = new Panel();
            FullNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            FullNameLabel = new Label();
            CustomerIDLabel = new Label();
            CustomerLayoutPanel = new TableLayoutPanel();
            CustomerDeliveryAddress = new Controls.AddressControl();
            CustomersGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            DiscountGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            CustomerLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(tableLayoutPanel1);
            CustomersGroupBox.Controls.Add(DiscountGroupBox);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(473, 614);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(RemoveCustomerButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddCustomerButton, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 353);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(461, 75);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCustomerButton.FlatStyle = FlatStyle.Popup;
            RemoveCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCustomerButton.Location = new Point(233, 3);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(225, 69);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCustomerButton.FlatStyle = FlatStyle.Popup;
            AddCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.Location = new Point(3, 3);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(224, 69);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(RemoveDiscount);
            DiscountGroupBox.Controls.Add(AddDiscount);
            DiscountGroupBox.Controls.Add(DiscountsListBox);
            DiscountGroupBox.Location = new Point(6, 431);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(464, 177);
            DiscountGroupBox.TabIndex = 2;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discounts:";
            // 
            // RemoveDiscount
            // 
            RemoveDiscount.FlatStyle = FlatStyle.Popup;
            RemoveDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveDiscount.Location = new Point(304, 105);
            RemoveDiscount.Name = "RemoveDiscount";
            RemoveDiscount.Size = new Size(160, 65);
            RemoveDiscount.TabIndex = 2;
            RemoveDiscount.Text = "Remove";
            RemoveDiscount.UseVisualStyleBackColor = true;
            RemoveDiscount.Click += RemoveDiscount_Click;
            // 
            // AddDiscount
            // 
            AddDiscount.FlatStyle = FlatStyle.Popup;
            AddDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddDiscount.Location = new Point(304, 26);
            AddDiscount.Name = "AddDiscount";
            AddDiscount.Size = new Size(160, 65);
            AddDiscount.TabIndex = 1;
            AddDiscount.Text = "Add";
            AddDiscount.UseVisualStyleBackColor = true;
            AddDiscount.Click += AddDiscount_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 20;
            DiscountsListBox.Location = new Point(6, 26);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(292, 144);
            DiscountsListBox.TabIndex = 0;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Top;
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(3, 23);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(467, 324);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.None;
            SelectedCustomerGroupBox.Controls.Add(PriorityCheck);
            SelectedCustomerGroupBox.Controls.Add(CustomersPanel2);
            SelectedCustomerGroupBox.Controls.Add(CustomersPanel);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDLabel);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedCustomerGroupBox.Location = new Point(485, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(474, 167);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // PriorityCheck
            // 
            PriorityCheck.AutoSize = true;
            PriorityCheck.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityCheck.Location = new Point(6, 121);
            PriorityCheck.Name = "PriorityCheck";
            PriorityCheck.Size = new Size(92, 24);
            PriorityCheck.TabIndex = 5;
            PriorityCheck.Text = "Is Priority";
            PriorityCheck.UseVisualStyleBackColor = true;
            PriorityCheck.CheckedChanged += PriorityCheck_CheckedChanged;
            // 
            // CustomersPanel2
            // 
            CustomersPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersPanel2.Location = new Point(0, 267);
            CustomersPanel2.Name = "CustomersPanel2";
            CustomersPanel2.Size = new Size(474, 250);
            CustomersPanel2.TabIndex = 1;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Location = new Point(0, 267);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(468, 347);
            CustomersPanel.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(91, 74);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(376, 27);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Enabled = false;
            CustomerIDTextBox.Location = new Point(91, 32);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(125, 27);
            CustomerIDTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(6, 77);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(79, 20);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerIDLabel.Location = new Point(6, 35);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(27, 20);
            CustomerIDLabel.TabIndex = 0;
            CustomerIDLabel.Text = "ID:";
            // 
            // CustomerLayoutPanel
            // 
            CustomerLayoutPanel.ColumnCount = 2;
            CustomerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CustomerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CustomerLayoutPanel.Controls.Add(CustomersGroupBox, 0, 0);
            CustomerLayoutPanel.Controls.Add(CustomerDeliveryAddress, 1, 0);
            CustomerLayoutPanel.Location = new Point(3, 3);
            CustomerLayoutPanel.Name = "CustomerLayoutPanel";
            CustomerLayoutPanel.RowCount = 1;
            CustomerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomerLayoutPanel.Size = new Size(959, 620);
            CustomerLayoutPanel.TabIndex = 3;
            // 
            // CustomerDeliveryAddress
            // 
            CustomerDeliveryAddress.Anchor = AnchorStyles.None;
            address2.Apartment = 0;
            address2.Building = " ";
            address2.City = " ";
            address2.Country = " ";
            address2.Index = 0;
            address2.Street = " ";
            CustomerDeliveryAddress.CustomerAddress = address2;
            CustomerDeliveryAddress.Location = new Point(482, 171);
            CustomerDeliveryAddress.Name = "CustomerDeliveryAddress";
            CustomerDeliveryAddress.Size = new Size(474, 277);
            CustomerDeliveryAddress.TabIndex = 1;
            CustomerDeliveryAddress.Load += addressControl1_Load;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomerLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(962, 626);
            CustomersGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            DiscountGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            CustomerLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Button RemoveCustomerButton;
        private Button AddCustomerButton;
        private ListBox CustomersListBox;
        private GroupBox SelectedCustomerGroupBox;
        private Panel CustomersPanel;
        private Label CustomerIDLabel;
        private TextBox FullNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label FullNameLabel;
        private TableLayoutPanel CustomerLayoutPanel;
        private Panel CustomersPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.AddressControl CustomerDeliveryAddress;
        private CheckBox PriorityCheck;
        private GroupBox DiscountGroupBox;
        private Button RemoveDiscount;
        private Button AddDiscount;
        private ListBox DiscountsListBox;
    }
}
