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
            CustomersGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            AddressTextBox = new TextBox();
            CustomersPanel2 = new Panel();
            CustomersPanel = new Panel();
            FullNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            CustomerIDLabel = new Label();
            CustomerLayoutPanel = new TableLayoutPanel();
            CustomersGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            CustomerLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(tableLayoutPanel1);
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
            tableLayoutPanel1.Location = new Point(0, 536);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(467, 75);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCustomerButton.FlatStyle = FlatStyle.Popup;
            RemoveCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCustomerButton.Location = new Point(236, 3);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(228, 69);
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
            AddCustomerButton.Size = new Size(227, 69);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Top;
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(3, 23);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(467, 504);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(AddressTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomersPanel2);
            SelectedCustomerGroupBox.Controls.Add(CustomersPanel);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomerGroupBox.Controls.Add(AddressLabel);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDLabel);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedCustomerGroupBox.Location = new Point(485, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(474, 267);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(91, 119);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(376, 142);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // CustomersPanel2
            // 
            CustomersPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersPanel2.Location = new Point(0, 267);
            CustomersPanel2.Name = "CustomersPanel2";
            CustomersPanel2.Size = new Size(474, 350);
            CustomersPanel2.TabIndex = 1;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Location = new Point(0, 267);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(468, 347);
            CustomersPanel.TabIndex = 2;
            CustomersPanel.Paint += CustomersPanel_Paint;
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
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(6, 122);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address:";
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
            CustomerLayoutPanel.Location = new Point(3, 3);
            CustomerLayoutPanel.Name = "CustomerLayoutPanel";
            CustomerLayoutPanel.RowCount = 1;
            CustomerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomerLayoutPanel.Size = new Size(959, 620);
            CustomerLayoutPanel.TabIndex = 3;
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
        private TextBox AddressTextBox;
        private TextBox FullNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label AddressLabel;
        private Label FullNameLabel;
        private TableLayoutPanel CustomerLayoutPanel;
        private Panel CustomersPanel2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
