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
            CartsTab = new TabPage();
            CartsTab1 = new View.Tabes.CartsTab();
            OrdersPage = new TabPage();
            ordersTab1 = new View.Tabes.OrdersTab();
            MainControl.SuspendLayout();
            tabPage1.SuspendLayout();
            CustomersPage.SuspendLayout();
            CartsTab.SuspendLayout();
            OrdersPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainControl
            // 
            MainControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainControl.Controls.Add(tabPage1);
            MainControl.Controls.Add(CustomersPage);
            MainControl.Controls.Add(CartsTab);
            MainControl.Controls.Add(OrdersPage);
            MainControl.Location = new Point(0, 0);
            MainControl.Name = "MainControl";
            MainControl.SelectedIndex = 0;
            MainControl.Size = new Size(1110, 664);
            MainControl.TabIndex = 0;
            MainControl.SelectedIndexChanged += MainControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ItemsTab);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1117, 631);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1111, 625);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(966, 631);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(960, 625);
            CustomersTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(CartsTab1);
            CartsTab.Location = new Point(4, 29);
            CartsTab.Name = "CartsTab";
            CartsTab.Padding = new Padding(3);
            CartsTab.Size = new Size(966, 631);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // CartsTab1
            // 
            CartsTab1.Customers = null;
            CartsTab1.Dock = DockStyle.Fill;
            CartsTab1.Items = null;
            CartsTab1.Location = new Point(3, 3);
            CartsTab1.Name = "CartsTab1";
            CartsTab1.Size = new Size(960, 625);
            CartsTab1.TabIndex = 0;
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(ordersTab1);
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(1102, 631);
            OrdersPage.TabIndex = 3;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.SelectedOrder = null;
            ordersTab1.Size = new Size(1096, 625);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 664);
            Controls.Add(MainControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            MainControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            OrdersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainControl;
        private TabPage tabPage1;
        private View.Tabs.ItemsTab ItemsTab;
        private TabPage CustomersPage;
        private View.Tabes.CustomersTab CustomersTab;
        private TabPage CartsTab;
        private View.Tabes.CartsTab CartsTab1;
        private TabPage OrdersPage;
        private View.Tabes.OrdersTab ordersTab1;
    }
}
