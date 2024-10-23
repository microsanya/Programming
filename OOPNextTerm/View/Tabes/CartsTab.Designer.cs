namespace OOPNextTerm.View.Tabes
{
    partial class CartsTab
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
            CartContainer = new SplitContainer();
            ItemsCartGroupBox = new GroupBox();
            AddToCartButton = new Button();
            ItemsCartListBox = new ListBox();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            AmountTotalLabel = new Label();
            AmountLabel = new Label();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomersComboBox = new ComboBox();
            CustomersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CartContainer).BeginInit();
            CartContainer.Panel1.SuspendLayout();
            CartContainer.Panel2.SuspendLayout();
            CartContainer.SuspendLayout();
            ItemsCartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CartContainer
            // 
            CartContainer.Dock = DockStyle.Fill;
            CartContainer.Location = new Point(0, 0);
            CartContainer.Name = "CartContainer";
            // 
            // CartContainer.Panel1
            // 
            CartContainer.Panel1.Controls.Add(ItemsCartGroupBox);
            // 
            // CartContainer.Panel2
            // 
            CartContainer.Panel2.Controls.Add(ClearCartButton);
            CartContainer.Panel2.Controls.Add(RemoveItemButton);
            CartContainer.Panel2.Controls.Add(CreateOrderButton);
            CartContainer.Panel2.Controls.Add(AmountTotalLabel);
            CartContainer.Panel2.Controls.Add(AmountLabel);
            CartContainer.Panel2.Controls.Add(CartListBox);
            CartContainer.Panel2.Controls.Add(CartLabel);
            CartContainer.Panel2.Controls.Add(CustomersComboBox);
            CartContainer.Panel2.Controls.Add(CustomersLabel);
            CartContainer.Size = new Size(954, 634);
            CartContainer.SplitterDistance = 394;
            CartContainer.TabIndex = 0;
            // 
            // ItemsCartGroupBox
            // 
            ItemsCartGroupBox.Controls.Add(AddToCartButton);
            ItemsCartGroupBox.Controls.Add(ItemsCartListBox);
            ItemsCartGroupBox.Dock = DockStyle.Fill;
            ItemsCartGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsCartGroupBox.Location = new Point(0, 0);
            ItemsCartGroupBox.Name = "ItemsCartGroupBox";
            ItemsCartGroupBox.Size = new Size(394, 634);
            ItemsCartGroupBox.TabIndex = 0;
            ItemsCartGroupBox.TabStop = false;
            ItemsCartGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.FlatStyle = FlatStyle.Popup;
            AddToCartButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddToCartButton.Location = new Point(131, 549);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(142, 61);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add to cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsCartListBox
            // 
            ItemsCartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsCartListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsCartListBox.FormattingEnabled = true;
            ItemsCartListBox.ItemHeight = 20;
            ItemsCartListBox.Location = new Point(6, 26);
            ItemsCartListBox.Name = "ItemsCartListBox";
            ItemsCartListBox.Size = new Size(382, 504);
            ItemsCartListBox.TabIndex = 0;
            // 
            // ClearCartButton
            // 
            ClearCartButton.FlatStyle = FlatStyle.Popup;
            ClearCartButton.Location = new Point(411, 549);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(142, 61);
            ClearCartButton.TabIndex = 8;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.FlatStyle = FlatStyle.Popup;
            RemoveItemButton.Location = new Point(263, 549);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(142, 61);
            RemoveItemButton.TabIndex = 7;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.FlatStyle = FlatStyle.Popup;
            CreateOrderButton.Location = new Point(14, 549);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(142, 61);
            CreateOrderButton.TabIndex = 6;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountTotalLabel
            // 
            AmountTotalLabel.AutoSize = true;
            AmountTotalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AmountTotalLabel.Location = new Point(411, 476);
            AmountTotalLabel.Name = "AmountTotalLabel";
            AmountTotalLabel.Size = new Size(60, 41);
            AmountTotalLabel.TabIndex = 5;
            AmountTotalLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(411, 456);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(71, 20);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 20;
            CartListBox.Location = new Point(14, 94);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(539, 344);
            CartListBox.TabIndex = 3;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(14, 61);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(102, 10);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(451, 28);
            CustomersComboBox.TabIndex = 1;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersLabel.Location = new Point(14, 10);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(82, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartContainer);
            Name = "CartsTab";
            Size = new Size(954, 634);
            CartContainer.Panel1.ResumeLayout(false);
            CartContainer.Panel2.ResumeLayout(false);
            CartContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CartContainer).EndInit();
            CartContainer.ResumeLayout(false);
            ItemsCartGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer CartContainer;
        private GroupBox ItemsCartGroupBox;
        private ListBox ItemsCartListBox;
        private ListBox CartListBox;
        private Label CartLabel;
        private ComboBox CustomersComboBox;
        private Label CustomersLabel;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
        private Label AmountTotalLabel;
        private Label AmountLabel;
        private Button AddToCartButton;
    }
}
