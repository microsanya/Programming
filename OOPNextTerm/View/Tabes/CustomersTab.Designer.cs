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
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            AddressTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            CustomerIDLabel = new Label();
            CustomersPanel = new Panel();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersGroupBox.Controls.Add(RemoveCustomerButton);
            CustomersGroupBox.Controls.Add(AddCustomerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(407, 620);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButton.FlatStyle = FlatStyle.Popup;
            RemoveCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCustomerButton.Location = new Point(231, 557);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(169, 57);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.FlatStyle = FlatStyle.Popup;
            AddCustomerButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.Location = new Point(6, 557);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(169, 57);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(6, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(394, 524);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(AddressTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomerGroupBox.Controls.Add(AddressLabel);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDLabel);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedCustomerGroupBox.Location = new Point(416, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(543, 267);
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
            AddressTextBox.Size = new Size(446, 142);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(91, 74);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(446, 27);
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
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersPanel.Location = new Point(416, 276);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.Size = new Size(543, 347);
            CustomersPanel.TabIndex = 2;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersPanel);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(962, 626);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
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
    }
}
