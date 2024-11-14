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
            TOTALNUM = new Label();
            TOTALLabel = new Label();
            DAmountNum = new Label();
            DAmount = new Label();
            DiscountsListBox = new CheckedListBox();
            DiscountLabel = new Label();
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
            CartContainer.Panel2.Controls.Add(TOTALNUM);
            CartContainer.Panel2.Controls.Add(TOTALLabel);
            CartContainer.Panel2.Controls.Add(DAmountNum);
            CartContainer.Panel2.Controls.Add(DAmount);
            CartContainer.Panel2.Controls.Add(DiscountsListBox);
            CartContainer.Panel2.Controls.Add(DiscountLabel);
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
            // TOTALNUM
            // 
            TOTALNUM.AutoSize = true;
            TOTALNUM.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TOTALNUM.Location = new Point(263, 569);
            TOTALNUM.Name = "TOTALNUM";
            TOTALNUM.Size = new Size(60, 41);
            TOTALNUM.TabIndex = 14;
            TOTALNUM.Text = "0,0";
            // 
            // TOTALLabel
            // 
            TOTALLabel.AutoSize = true;
            TOTALLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TOTALLabel.Location = new Point(265, 549);
            TOTALLabel.Name = "TOTALLabel";
            TOTALLabel.Size = new Size(58, 20);
            TOTALLabel.TabIndex = 13;
            TOTALLabel.Text = "TOTAL:";
            // 
            // DAmountNum
            // 
            DAmountNum.AutoSize = true;
            DAmountNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DAmountNum.Location = new Point(446, 466);
            DAmountNum.Name = "DAmountNum";
            DAmountNum.Size = new Size(60, 41);
            DAmountNum.TabIndex = 12;
            DAmountNum.Text = "0,0";
            // 
            // DAmount
            // 
            DAmount.AutoSize = true;
            DAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DAmount.Location = new Point(411, 428);
            DAmount.Name = "DAmount";
            DAmount.Size = new Size(137, 20);
            DAmount.TabIndex = 11;
            DAmount.Text = "Discount Amount:";
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.BackColor = SystemColors.Control;
            DiscountsListBox.BorderStyle = BorderStyle.None;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(14, 428);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(251, 110);
            DiscountsListBox.TabIndex = 10;
            DiscountsListBox.SelectedIndexChanged += DiscountsListBox_SelectedIndexChanged;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountLabel.Location = new Point(14, 405);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(82, 20);
            DiscountLabel.TabIndex = 9;
            DiscountLabel.Text = "Discounts:";
            // 
            // ClearCartButton
            // 
            ClearCartButton.FlatStyle = FlatStyle.Popup;
            ClearCartButton.Location = new Point(411, 332);
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
            RemoveItemButton.Location = new Point(263, 332);
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
            CreateOrderButton.Location = new Point(14, 332);
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
            AmountTotalLabel.Location = new Point(446, 288);
            AmountTotalLabel.Name = "AmountTotalLabel";
            AmountTotalLabel.Size = new Size(60, 41);
            AmountTotalLabel.TabIndex = 5;
            AmountTotalLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(482, 257);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(71, 20);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 20;
            CartListBox.Location = new Point(14, 70);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(539, 184);
            CartListBox.TabIndex = 3;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(14, 47);
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
        private Label TOTALNUM;
        private Label TOTALLabel;
        private Label DAmountNum;
        private Label DAmount;
        private CheckedListBox DiscountsListBox;
        private Label DiscountLabel;
    }
}
