namespace OOPNextTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainControl = new TabControl();
            tabPage1 = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            CustomersPage = new TabPage();
            CustomersTab = new View.Tabes.CustomersTab();
            MainControl.SuspendLayout();
            tabPage1.SuspendLayout();
            CustomersPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainControl
            // 
            MainControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainControl.Controls.Add(tabPage1);
            MainControl.Controls.Add(CustomersPage);
            MainControl.Location = new Point(0, 0);
            MainControl.Name = "MainControl";
            MainControl.SelectedIndex = 0;
            MainControl.Size = new Size(978, 664);
            MainControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTab);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(970, 631);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(964, 625);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(970, 631);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(964, 625);
            CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 664);
            Controls.Add(MainControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            MainControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainControl;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage CustomersPage;
        private View.Tabes.CustomersTab CustomersTab;
    }
}
