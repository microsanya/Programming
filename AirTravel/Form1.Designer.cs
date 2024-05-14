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
            FlightsViewListBox = new ListBox();
            FlightsViewGroupBox = new GroupBox();
            ExtendedFlightViewGroupBox = new GroupBox();
            AddButtonPB = new PictureBox();
            AirlinePictureBox = new PictureBox();
            AirlineLabel = new Label();
            FTypeLabel = new Label();
            textBox1 = new TextBox();
            FTypeComboBox = new ComboBox();
            FTLabel = new Label();
            DTLabel = new Label();
            DTDataTimePicker = new DateTimePicker();
            DestinationTextBox = new TextBox();
            DestinationLabel = new Label();
            DPTextBox = new TextBox();
            DPLabel = new Label();
            SearchGroupBox = new GroupBox();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            DeleteButtonPB = new PictureBox();
            FlightsViewGroupBox.SuspendLayout();
            ExtendedFlightViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddButtonPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AirlinePictureBox).BeginInit();
            SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteButtonPB).BeginInit();
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
            ExtendedFlightViewGroupBox.Controls.Add(textBox1);
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
            // AddButtonPB
            // 
            AddButtonPB.BackgroundImage = Properties.Resources.add_flight;
            AddButtonPB.BackgroundImageLayout = ImageLayout.Center;
            AddButtonPB.Location = new Point(25, 505);
            AddButtonPB.Name = "AddButtonPB";
            AddButtonPB.Size = new Size(65, 65);
            AddButtonPB.TabIndex = 11;
            AddButtonPB.TabStop = false;
            // 
            // AirlinePictureBox
            // 
            AirlinePictureBox.Location = new Point(7, 315);
            AirlinePictureBox.Name = "AirlinePictureBox";
            AirlinePictureBox.Size = new Size(193, 184);
            AirlinePictureBox.TabIndex = 10;
            AirlinePictureBox.TabStop = false;
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
            // FTypeLabel
            // 
            FTypeLabel.AutoSize = true;
            FTypeLabel.Location = new Point(6, 238);
            FTypeLabel.Name = "FTypeLabel";
            FTypeLabel.Size = new Size(84, 20);
            FTypeLabel.TabIndex = 8;
            FTypeLabel.Text = "Flight Type:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 7;
            // 
            // FTypeComboBox
            // 
            FTypeComboBox.FormattingEnabled = true;
            FTypeComboBox.Location = new Point(6, 261);
            FTypeComboBox.Name = "FTypeComboBox";
            FTypeComboBox.Size = new Size(180, 28);
            FTypeComboBox.TabIndex = 6;
            // 
            // FTLabel
            // 
            FTLabel.AutoSize = true;
            FTLabel.Location = new Point(7, 185);
            FTLabel.Name = "FTLabel";
            FTLabel.Size = new Size(83, 20);
            FTLabel.TabIndex = 3;
            FTLabel.Text = "Flight time:";
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
            DTDataTimePicker.Location = new Point(6, 155);
            DTDataTimePicker.Name = "DTDataTimePicker";
            DTDataTimePicker.Size = new Size(180, 27);
            DTDataTimePicker.TabIndex = 4;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(6, 102);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(180, 27);
            DestinationTextBox.TabIndex = 3;
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
            SearchGroupBox.Controls.Add(SearchButton);
            SearchGroupBox.Controls.Add(SearchTextBox);
            SearchGroupBox.Location = new Point(583, 12);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(381, 577);
            SearchGroupBox.TabIndex = 3;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Text = "Search Flight:";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(139, 190);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search!";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(57, 157);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(266, 27);
            SearchTextBox.TabIndex = 0;
            // 
            // DeleteButtonPB
            // 
            DeleteButtonPB.BackgroundImage = Properties.Resources.delete_flight;
            DeleteButtonPB.Location = new Point(111, 505);
            DeleteButtonPB.Name = "DeleteButtonPB";
            DeleteButtonPB.Size = new Size(65, 65);
            DeleteButtonPB.TabIndex = 12;
            DeleteButtonPB.TabStop = false;
            // 
            // AirTravelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 601);
            Controls.Add(SearchGroupBox);
            Controls.Add(ExtendedFlightViewGroupBox);
            Controls.Add(FlightsViewGroupBox);
            Name = "AirTravelForm";
            Text = "Air Travel";
            FlightsViewGroupBox.ResumeLayout(false);
            ExtendedFlightViewGroupBox.ResumeLayout(false);
            ExtendedFlightViewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddButtonPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)AirlinePictureBox).EndInit();
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteButtonPB).EndInit();
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
        private TextBox textBox1;
        private PictureBox AirlinePictureBox;
        private Label AirlineLabel;
        private GroupBox SearchGroupBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private PictureBox AddButtonPB;
        private PictureBox DeleteButtonPB;
    }
}