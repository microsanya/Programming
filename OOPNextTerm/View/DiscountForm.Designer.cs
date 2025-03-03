namespace OOPNextTerm.View
{
    partial class DiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountForm));
            PercentLabel = new Label();
            CategoryLabel = new Label();
            DCategoryComboBox = new ComboBox();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // PercentLabel
            // 
            PercentLabel.AutoSize = true;
            PercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PercentLabel.Location = new Point(12, 9);
            PercentLabel.Name = "PercentLabel";
            PercentLabel.Size = new Size(132, 20);
            PercentLabel.TabIndex = 0;
            PercentLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 60);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // DCategoryComboBox
            // 
            DCategoryComboBox.FormattingEnabled = true;
            DCategoryComboBox.Location = new Point(90, 57);
            DCategoryComboBox.Name = "DCategoryComboBox";
            DCategoryComboBox.Size = new Size(332, 28);
            DCategoryComboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            OKButton.FlatStyle = FlatStyle.Popup;
            OKButton.Location = new Point(174, 123);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(121, 50);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Location = new Point(301, 123);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(121, 50);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 188);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(DCategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DiscountForm";
            Text = "DiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentLabel;
        private Label CategoryLabel;
        private ComboBox DCategoryComboBox;
        private Button OKButton;
        private Button CancelButton;
    }
}