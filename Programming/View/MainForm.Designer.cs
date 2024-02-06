namespace Programming
{
    partial class MainForm
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
            TabControlOfEnums = new TabControl();
            Enums = new TabPage();
            TabControlOfEnums.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlOfEnums
            // 
            TabControlOfEnums.Controls.Add(Enums);
            TabControlOfEnums.Location = new Point(253, 12);
            TabControlOfEnums.Name = "TabControlOfEnums";
            TabControlOfEnums.SelectedIndex = 0;
            TabControlOfEnums.Size = new Size(318, 170);
            TabControlOfEnums.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(310, 137);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            Enums.Click += tabPage1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlOfEnums);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            TabControlOfEnums.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlOfEnums;
        private TabPage Enums;
    }
}