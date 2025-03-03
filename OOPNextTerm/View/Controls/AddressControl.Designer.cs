namespace OOPNextTerm.View.Controls
{
    partial class AddressControl
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
            AddressTableLayout = new TableLayoutPanel();
            AddressGroupBox = new GroupBox();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            IndexTextBox = new TextBox();
            ApartmentLabel = new Label();
            BuildingLabel = new Label();
            StreetLabel = new Label();
            CityLabel = new Label();
            CountryLabel = new Label();
            IndexLabel = new Label();
            AddressTableLayout.SuspendLayout();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressTableLayout
            // 
            AddressTableLayout.ColumnCount = 1;
            AddressTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddressTableLayout.Controls.Add(AddressGroupBox, 0, 0);
            AddressTableLayout.Dock = DockStyle.Fill;
            AddressTableLayout.Location = new Point(0, 0);
            AddressTableLayout.Name = "AddressTableLayout";
            AddressTableLayout.RowCount = 1;
            AddressTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddressTableLayout.Size = new Size(461, 310);
            AddressTableLayout.TabIndex = 0;
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(IndexTextBox);
            AddressGroupBox.Controls.Add(ApartmentLabel);
            AddressGroupBox.Controls.Add(BuildingLabel);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Controls.Add(CityLabel);
            AddressGroupBox.Controls.Add(CountryLabel);
            AddressGroupBox.Controls.Add(IndexLabel);
            AddressGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddressGroupBox.Location = new Point(3, 3);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(455, 304);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery CustomerAddress";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(344, 218);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(102, 27);
            ApartmentTextBox.TabIndex = 11;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(91, 218);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(158, 27);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(91, 144);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(355, 27);
            StreetTextBox.TabIndex = 9;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(288, 82);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(158, 27);
            CityTextBox.TabIndex = 8;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(91, 82);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(158, 27);
            CountryTextBox.TabIndex = 7;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(91, 31);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(125, 27);
            IndexTextBox.TabIndex = 6;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ApartmentLabel.Location = new Point(255, 221);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BuildingLabel.Location = new Point(6, 221);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StreetLabel.Location = new Point(6, 147);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 3;
            StreetLabel.Text = "Street:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(255, 85);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CountryLabel.Location = new Point(6, 89);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IndexLabel.Location = new Point(6, 34);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(79, 20);
            IndexLabel.TabIndex = 0;
            IndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressTableLayout);
            Name = "AddressControl";
            Size = new Size(461, 310);
            Load += AddressControl_Load;
            AddressTableLayout.ResumeLayout(false);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddressTableLayout;
        private GroupBox AddressGroupBox;
        private Label IndexLabel;
        private Label ApartmentLabel;
        private Label BuildingLabel;
        private Label StreetLabel;
        private Label CityLabel;
        private Label CountryLabel;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CityTextBox;
        private TextBox CountryTextBox;
        private TextBox IndexTextBox;
    }
}
