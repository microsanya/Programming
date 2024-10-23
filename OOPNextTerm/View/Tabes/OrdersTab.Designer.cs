namespace OOPNextTerm.View.Tabes
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Address address1 = new Address();
            OrdersContainer = new SplitContainer();
            OrdersGroupBox = new GroupBox();
            OrdersGridView = new DataGridView();
            TotalCountLabel = new Label();
            orderBindingSource6 = new BindingSource(components);
            AmountOrderLabel = new Label();
            OrderAddressControl = new Controls.AddressControl();
            orderBindingSource5 = new BindingSource(components);
            SelectedOrderGroupBox = new GroupBox();
            OrderDate = new DateTimePicker();
            StatusOrderComboBox = new ComboBox();
            orderBindingSource3 = new BindingSource(components);
            orderBindingSource4 = new BindingSource(components);
            IdOrderTextBox = new TextBox();
            orderBindingSource1 = new BindingSource(components);
            StatusLabel = new Label();
            CreatedOrderLabel = new Label();
            IdOrderLabel = new Label();
            orderBindingSource2 = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)OrdersContainer).BeginInit();
            OrdersContainer.Panel1.SuspendLayout();
            OrdersContainer.Panel2.SuspendLayout();
            OrdersContainer.SuspendLayout();
            OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource5).BeginInit();
            SelectedOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // OrdersContainer
            // 
            OrdersContainer.Dock = DockStyle.Fill;
            OrdersContainer.Location = new Point(0, 0);
            OrdersContainer.Name = "OrdersContainer";
            // 
            // OrdersContainer.Panel1
            // 
            OrdersContainer.Panel1.Controls.Add(OrdersGroupBox);
            // 
            // OrdersContainer.Panel2
            // 
            OrdersContainer.Panel2.Controls.Add(TotalCountLabel);
            OrdersContainer.Panel2.Controls.Add(AmountOrderLabel);
            OrdersContainer.Panel2.Controls.Add(OrderAddressControl);
            OrdersContainer.Panel2.Controls.Add(SelectedOrderGroupBox);
            OrdersContainer.Size = new Size(1092, 642);
            OrdersContainer.SplitterDistance = 504;
            OrdersContainer.TabIndex = 0;
            // 
            // OrdersGroupBox
            // 
            OrdersGroupBox.Controls.Add(OrdersGridView);
            OrdersGroupBox.Dock = DockStyle.Fill;
            OrdersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersGroupBox.Location = new Point(0, 0);
            OrdersGroupBox.Name = "OrdersGroupBox";
            OrdersGroupBox.Size = new Size(504, 642);
            OrdersGroupBox.TabIndex = 0;
            OrdersGroupBox.TabStop = false;
            OrdersGroupBox.Text = "Orders";
            // 
            // OrdersGridView
            // 
            OrdersGridView.AllowUserToAddRows = false;
            OrdersGridView.AllowUserToResizeColumns = false;
            OrdersGridView.AllowUserToResizeRows = false;
            OrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGridView.Dock = DockStyle.Fill;
            OrdersGridView.Location = new Point(3, 23);
            OrdersGridView.MultiSelect = false;
            OrdersGridView.Name = "OrdersGridView";
            OrdersGridView.RowHeadersVisible = false;
            OrdersGridView.RowHeadersWidth = 51;
            OrdersGridView.RowTemplate.Height = 29;
            OrdersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersGridView.Size = new Size(498, 616);
            OrdersGridView.TabIndex = 0;
            OrdersGridView.SelectionChanged += OrdersGridView_SelectionChanged;
            // 
            // TotalCountLabel
            // 
            TotalCountLabel.AutoSize = true;
            TotalCountLabel.DataBindings.Add(new Binding("Text", orderBindingSource6, "TotalAmount", true));
            TotalCountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCountLabel.Location = new Point(432, 472);
            TotalCountLabel.Name = "TotalCountLabel";
            TotalCountLabel.Size = new Size(60, 41);
            TotalCountLabel.TabIndex = 3;
            TotalCountLabel.Text = "0.0";
            // 
            // orderBindingSource6
            // 
            orderBindingSource6.DataSource = typeof(Order);
            // 
            // AmountOrderLabel
            // 
            AmountOrderLabel.AutoSize = true;
            AmountOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountOrderLabel.Location = new Point(459, 434);
            AmountOrderLabel.Name = "AmountOrderLabel";
            AmountOrderLabel.Size = new Size(71, 20);
            AmountOrderLabel.TabIndex = 2;
            AmountOrderLabel.Text = "Amount:";
            // 
            // OrderAddressControl
            // 
            address1.Apartment = 0;
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 0;
            address1.Street = " ";
            OrderAddressControl.CustomerAddress = address1;
            OrderAddressControl.DataBindings.Add(new Binding("Tag", orderBindingSource5, "OrderAddress", true));
            OrderAddressControl.Location = new Point(3, 167);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(534, 264);
            OrderAddressControl.TabIndex = 1;
            // 
            // orderBindingSource5
            // 
            orderBindingSource5.DataSource = typeof(Order);
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(OrderDate);
            SelectedOrderGroupBox.Controls.Add(StatusOrderComboBox);
            SelectedOrderGroupBox.Controls.Add(IdOrderTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedOrderLabel);
            SelectedOrderGroupBox.Controls.Add(IdOrderLabel);
            SelectedOrderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedOrderGroupBox.Location = new Point(3, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(529, 158);
            SelectedOrderGroupBox.TabIndex = 0;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(81, 69);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(201, 27);
            OrderDate.TabIndex = 6;
            // 
            // StatusOrderComboBox
            // 
            StatusOrderComboBox.DataBindings.Add(new Binding("SelectedValue", orderBindingSource3, "OrderStatus", true));
            StatusOrderComboBox.DataBindings.Add(new Binding("Text", orderBindingSource4, "OrderStatus", true));
            StatusOrderComboBox.FormattingEnabled = true;
            StatusOrderComboBox.Items.AddRange(new object[] { "New", "Processing", "Assembly", "Sent", "Delivered", "Returned", "Abandone" });
            StatusOrderComboBox.Location = new Point(81, 110);
            StatusOrderComboBox.Name = "StatusOrderComboBox";
            StatusOrderComboBox.Size = new Size(201, 28);
            StatusOrderComboBox.TabIndex = 5;
            StatusOrderComboBox.SelectedIndexChanged += StatusOrderComboBox_SelectedIndexChanged;
            // 
            // orderBindingSource3
            // 
            orderBindingSource3.DataSource = typeof(Order);
            // 
            // orderBindingSource4
            // 
            orderBindingSource4.DataSource = typeof(Order);
            // 
            // IdOrderTextBox
            // 
            IdOrderTextBox.DataBindings.Add(new Binding("Text", orderBindingSource1, "Id", true));
            IdOrderTextBox.Enabled = false;
            IdOrderTextBox.Location = new Point(81, 26);
            IdOrderTextBox.Name = "IdOrderTextBox";
            IdOrderTextBox.ReadOnly = true;
            IdOrderTextBox.Size = new Size(201, 27);
            IdOrderTextBox.TabIndex = 3;
            // 
            // orderBindingSource1
            // 
            orderBindingSource1.DataSource = typeof(Order);
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.Location = new Point(6, 118);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // CreatedOrderLabel
            // 
            CreatedOrderLabel.AutoSize = true;
            CreatedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedOrderLabel.Location = new Point(6, 74);
            CreatedOrderLabel.Name = "CreatedOrderLabel";
            CreatedOrderLabel.Size = new Size(64, 20);
            CreatedOrderLabel.TabIndex = 1;
            CreatedOrderLabel.Text = "Created:";
            // 
            // IdOrderLabel
            // 
            IdOrderLabel.AutoSize = true;
            IdOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdOrderLabel.Location = new Point(6, 34);
            IdOrderLabel.Name = "IdOrderLabel";
            IdOrderLabel.Size = new Size(27, 20);
            IdOrderLabel.TabIndex = 0;
            IdOrderLabel.Text = "ID:";
            // 
            // orderBindingSource2
            // 
            orderBindingSource2.DataSource = typeof(Order);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersContainer);
            Name = "OrdersTab";
            Size = new Size(1092, 642);
            OrdersContainer.Panel1.ResumeLayout(false);
            OrdersContainer.Panel2.ResumeLayout(false);
            OrdersContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersContainer).EndInit();
            OrdersContainer.ResumeLayout(false);
            OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource5).EndInit();
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer OrdersContainer;
        private GroupBox OrdersGroupBox;
        private DataGridView OrdersGridView;
        private BindingSource orderBindingSource;
        private GroupBox SelectedOrderGroupBox;
        private TextBox IdOrderTextBox;
        private Label StatusLabel;
        private Label CreatedOrderLabel;
        private Label IdOrderLabel;
        private ComboBox StatusOrderComboBox;
        private Controls.AddressControl OrderAddressControl;
        private Label TotalCountLabel;
        private Label AmountOrderLabel;
        private BindingSource orderBindingSource1;
        private BindingSource orderBindingSource6;
        private BindingSource orderBindingSource5;
        private BindingSource orderBindingSource3;
        private BindingSource orderBindingSource4;
        private BindingSource orderBindingSource2;
        private DateTimePicker OrderDate;
    }
}
