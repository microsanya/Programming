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
            TabControlOfItems = new TabControl();
            EnumsTabPage = new TabPage();
            enumsChecking1 = new View.Panels.EnumsChecking();
            seasonControl1 = new View.Panels.SeasonControl();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            ClassesTabPage = new TabPage();
            findFilmControl1 = new View.Panels.FindFilmControl();
            findRectangleControl1 = new View.Panels.FindRectangleControl();
            RectanglesTabPage = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            TabControlOfItems.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlOfItems
            // 
            TabControlOfItems.Controls.Add(EnumsTabPage);
            TabControlOfItems.Controls.Add(ClassesTabPage);
            TabControlOfItems.Controls.Add(RectanglesTabPage);
            TabControlOfItems.Dock = DockStyle.Fill;
            TabControlOfItems.Location = new Point(0, 0);
            TabControlOfItems.Name = "TabControlOfItems";
            TabControlOfItems.SelectedIndex = 0;
            TabControlOfItems.Size = new Size(839, 586);
            TabControlOfItems.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(enumsChecking1);
            EnumsTabPage.Controls.Add(seasonControl1);
            EnumsTabPage.Controls.Add(weekdayParsingControl1);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(831, 553);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // enumsChecking1
            // 
            enumsChecking1.Location = new Point(0, 0);
            enumsChecking1.Name = "enumsChecking1";
            enumsChecking1.Size = new Size(831, 396);
            enumsChecking1.TabIndex = 17;
            // 
            // seasonControl1
            // 
            seasonControl1.Location = new Point(409, 393);
            seasonControl1.Name = "seasonControl1";
            seasonControl1.Size = new Size(422, 157);
            seasonControl1.TabIndex = 16;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(0, 391);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(415, 162);
            weekdayParsingControl1.TabIndex = 15;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(findFilmControl1);
            ClassesTabPage.Controls.Add(findRectangleControl1);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(831, 553);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // findFilmControl1
            // 
            findFilmControl1.Location = new Point(413, -3);
            findFilmControl1.Name = "findFilmControl1";
            findFilmControl1.Size = new Size(422, 579);
            findFilmControl1.TabIndex = 3;
            // 
            // findRectangleControl1
            // 
            findRectangleControl1.Location = new Point(0, -3);
            findRectangleControl1.Name = "findRectangleControl1";
            findRectangleControl1.Size = new Size(427, 560);
            findRectangleControl1.TabIndex = 2;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(rectanglesCollisionControl1);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(831, 553);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(825, 547);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 586);
            Controls.Add(TabControlOfItems);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            TabControlOfItems.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            RectanglesTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControlOfItems;
        private TabPage EnumsTabPage;
        private TabPage ClassesTabPage;
        private TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonControl seasonControl1;
        private View.Panels.EnumsChecking enumsChecking1;
        private View.Panels.FindRectangleControl findRectangleControl1;
        private View.Panels.FindFilmControl findFilmControl1;
    }
}