namespace AirTravel
{
    partial class AirTravelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirTravelForm));
            FlightsViewListBox = new ListBox();
            FlightsViewGroupBox = new GroupBox();
            ExtendedFlightViewGroupBox = new GroupBox();
            DeleteButtonPB = new PictureBox();
            AirlinePictureBox = new PictureBox();
            AirlineLabel = new Label();
            AddButtonPB = new PictureBox();
            FTypeLabel = new Label();
            FlightTimeTextBox = new TextBox();
            FTypeComboBox = new ComboBox();
            FTLabel = new Label();
            DTLabel = new Label();
            DTDataTimePicker = new DateTimePicker();
            DestinationTextBox = new TextBox();
            DestinationLabel = new Label();
            DPTextBox = new TextBox();
            DPLabel = new Label();
            SearchGroupBox = new GroupBox();
            CancelSearchButton = new Button();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            FlightsViewGroupBox.SuspendLayout();
            ExtendedFlightViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteButtonPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AirlinePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddButtonPB).BeginInit();
            SearchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FlightsViewListBox
            // 
            FlightsViewListBox.FormattingEnabled = true;
            FlightsViewListBox.ItemHeight = 20;
            FlightsViewListBox.Location = new Point(16, 26);
            FlightsViewListBox.Name = "FlightsViewListBox";
            FlightsViewListBox.Size = new Size(319, 544);
            FlightsViewListBox.TabIndex = 0;
            FlightsViewListBox.SelectedIndexChanged += FlightsViewListBox_SelectedIndexChanged;
            // 
            // FlightsViewGroupBox
            // 
            FlightsViewGroupBox.Controls.Add(FlightsViewListBox);
            FlightsViewGroupBox.Location = new Point(12, 12);
            FlightsViewGroupBox.Name = "FlightsViewGroupBox";
            FlightsViewGroupBox.Size = new Size(353, 577);
            FlightsViewGroupBox.TabIndex = 1;
            FlightsViewGroupBox.TabStop = false;
            FlightsViewGroupBox.Text = "Flights View";
            // 
            // ExtendedFlightViewGroupBox
            // 
            ExtendedFlightViewGroupBox.Controls.Add(DeleteButtonPB);
            ExtendedFlightViewGroupBox.Controls.Add(AirlinePictureBox);
            ExtendedFlightViewGroupBox.Controls.Add(AirlineLabel);
            ExtendedFlightViewGroupBox.Controls.Add(AddButtonPB);
            ExtendedFlightViewGroupBox.Controls.Add(FTypeLabel);
            ExtendedFlightViewGroupBox.Controls.Add(FlightTimeTextBox);
            ExtendedFlightViewGroupBox.Controls.Add(FTypeComboBox);
            ExtendedFlightViewGroupBox.Controls.Add(FTLabel);
            ExtendedFlightViewGroupBox.Controls.Add(DTLabel);
            ExtendedFlightViewGroupBox.Controls.Add(DTDataTimePicker);
            ExtendedFlightViewGroupBox.Controls.Add(DestinationTextBox);
            ExtendedFlightViewGroupBox.Controls.Add(DestinationLabel);
            ExtendedFlightViewGroupBox.Controls.Add(DPTextBox);
            ExtendedFlightViewGroupBox.Controls.Add(DPLabel);
            ExtendedFlightViewGroupBox.Location = new Point(371, 12);
            ExtendedFlightViewGroupBox.Name = "ExtendedFlightViewGroupBox";
            ExtendedFlightViewGroupBox.Size = new Size(206, 577);
            ExtendedFlightViewGroupBox.TabIndex = 2;
            ExtendedFlightViewGroupBox.TabStop = false;
            ExtendedFlightViewGroupBox.Text = "Extended Flight View";
            // 
            // DeleteButtonPB
            // 
            DeleteButtonPB.BackgroundImage = Properties.Resources.delete_flight;
            DeleteButtonPB.BackgroundImageLayout = ImageLayout.Center;
            DeleteButtonPB.Location = new Point(111, 505);
            DeleteButtonPB.Name = "DeleteButtonPB";
            DeleteButtonPB.Size = new Size(65, 65);
            DeleteButtonPB.TabIndex = 12;
            DeleteButtonPB.TabStop = false;
            DeleteButtonPB.Click += DeleteButtonPB_Click;
            DeleteButtonPB.MouseClick += DeleteButtonPB_MouseClick;
            DeleteButtonPB.MouseEnter += DeleteButtonPB_MouseEnter;
            DeleteButtonPB.MouseLeave += DeleteButtonPB_MouseLeave;
            // 
            // AirlinePictureBox
            // 
            AirlinePictureBox.BackgroundImageLayout = ImageLayout.Center;
            AirlinePictureBox.Location = new Point(7, 315);
            AirlinePictureBox.Name = "AirlinePictureBox";
            AirlinePictureBox.Size = new Size(193, 184);
            AirlinePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AirlinePictureBox.TabIndex = 10;
            AirlinePictureBox.TabStop = false;
            AirlinePictureBox.Click += AirlinePictureBox_Click;
            // 
            // AirlineLabel
            // 
            AirlineLabel.AutoSize = true;
            AirlineLabel.Location = new Point(7, 292);
            AirlineLabel.Name = "AirlineLabel";
            AirlineLabel.Size = new Size(55, 20);
            AirlineLabel.TabIndex = 9;
            AirlineLabel.Text = "Airline:";
            // 
            // AddButtonPB
            // 
            AddButtonPB.BackColor = SystemColors.Control;
            AddButtonPB.BackgroundImage = Properties.Resources.add_flight;
            AddButtonPB.BackgroundImageLayout = ImageLayout.Center;
            AddButtonPB.Location = new Point(25, 505);
            AddButtonPB.Name = "AddButtonPB";
            AddButtonPB.Size = new Size(65, 65);
            AddButtonPB.TabIndex = 11;
            AddButtonPB.TabStop = false;
            AddButtonPB.Click += AddButtonPB_Click;
            AddButtonPB.MouseClick += AddButtonPB_MouseClick;
            AddButtonPB.MouseEnter += AddButtonPB_MouseEnter;
            AddButtonPB.MouseLeave += AddButtonPB_MouseLeave;
            // 
            // FTypeLabel
            // 
            FTypeLabel.AutoSize = true;
            FTypeLabel.Location = new Point(6, 238);
            FTypeLabel.Name = "FTypeLabel";
            FTypeLabel.Size = new Size(84, 20);
            FTypeLabel.TabIndex = 8;
            FTypeLabel.Text = "Flight Type:";
            // 
            // FlightTimeTextBox
            // 
            FlightTimeTextBox.Location = new Point(6, 208);
            FlightTimeTextBox.Name = "FlightTimeTextBox";
            FlightTimeTextBox.Size = new Size(180, 27);
            FlightTimeTextBox.TabIndex = 7;
            FlightTimeTextBox.TextChanged += FlightTimeTextBox_TextChanged;
            // 
            // FTypeComboBox
            // 
            FTypeComboBox.FormattingEnabled = true;
            FTypeComboBox.Items.AddRange(new object[] { "Внутренний", "Международный", "None" });
            FTypeComboBox.Location = new Point(6, 261);
            FTypeComboBox.Name = "FTypeComboBox";
            FTypeComboBox.Size = new Size(180, 28);
            FTypeComboBox.TabIndex = 6;
            FTypeComboBox.SelectedIndexChanged += FTypeComboBox_SelectedIndexChanged;
            // 
            // FTLabel
            // 
            FTLabel.AutoSize = true;
            FTLabel.Location = new Point(7, 185);
            FTLabel.Name = "FTLabel";
            FTLabel.Size = new Size(128, 20);
            FTLabel.TabIndex = 3;
            FTLabel.Text = "Flight time (mins):";
            // 
            // DTLabel
            // 
            DTLabel.AutoSize = true;
            DTLabel.Location = new Point(6, 132);
            DTLabel.Name = "DTLabel";
            DTLabel.Size = new Size(113, 20);
            DTLabel.TabIndex = 5;
            DTLabel.Text = "Departure time:";
            // 
            // DTDataTimePicker
            // 
            DTDataTimePicker.Location = new Point(6, 157);
            DTDataTimePicker.Name = "DTDataTimePicker";
            DTDataTimePicker.Size = new Size(180, 27);
            DTDataTimePicker.TabIndex = 4;
            DTDataTimePicker.ValueChanged += DTDataTimePicker_ValueChanged;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(6, 102);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(180, 27);
            DestinationTextBox.TabIndex = 3;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(6, 79);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(88, 20);
            DestinationLabel.TabIndex = 2;
            DestinationLabel.Text = "Destination:";
            // 
            // DPTextBox
            // 
            DPTextBox.Location = new Point(7, 49);
            DPTextBox.Name = "DPTextBox";
            DPTextBox.Size = new Size(180, 27);
            DPTextBox.TabIndex = 1;
            DPTextBox.TextChanged += DPTextBox_TextChanged;
            // 
            // DPLabel
            // 
            DPLabel.AutoSize = true;
            DPLabel.Location = new Point(1, 26);
            DPLabel.Name = "DPLabel";
            DPLabel.Size = new Size(118, 20);
            DPLabel.TabIndex = 0;
            DPLabel.Text = "Departure point:";
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(CancelSearchButton);
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchTextBox);
            SearchGroupBox.Location = new Point(583, 12);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(381, 577);
            SearchGroupBox.TabIndex = 3;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search Flight:";
            // 
            // CancelSearchButton
            // 
            CancelSearchButton.Location = new Point(130, 260);
            CancelSearchButton.Name = "CancelSearchButton";
            CancelSearchButton.Size = new Size(117, 29);
            CancelSearchButton.TabIndex = 2;
            CancelSearchButton.Text = "Cancel Search";
            CancelSearchButton.UseVisualStyleBackColor = true;
            CancelSearchButton.Click += CancelSearchButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(139, 158);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search!";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(54, 208);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(266, 27);
            SearchTextBox.TabIndex = 0;
            // 
            // AirTravelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 601);
            Controls.Add(SearchGroupBox);
            Controls.Add(ExtendedFlightViewGroupBox);
            Controls.Add(FlightsViewGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AirTravelForm";
            Text = "Air Travel";
            Load += AirTravelForm_Load;
            FlightsViewGroupBox.ResumeLayout(false);
            ExtendedFlightViewGroupBox.ResumeLayout(false);
            ExtendedFlightViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteButtonPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)AirlinePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddButtonPB).EndInit();
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox FlightsViewListBox;
        private GroupBox FlightsViewGroupBox;
        private GroupBox ExtendedFlightViewGroupBox;
        private Label DPLabel;
        private Label DTLabel;
        private DateTimePicker DTDataTimePicker;
        private TextBox DestinationTextBox;
        private Label DestinationLabel;
        private TextBox DPTextBox;
        private ComboBox FTypeComboBox;
        private Label FTLabel;
        private Label FTypeLabel;
        private TextBox FlightTimeTextBox;
        private PictureBox AirlinePictureBox;
        private Label AirlineLabel;
        private GroupBox SearchGroupBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private PictureBox AddButtonPB;
        private PictureBox DeleteButtonPB;
        private Button CancelSearchButton;
    }
}