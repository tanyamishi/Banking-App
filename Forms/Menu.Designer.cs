namespace Banking_App
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            newAccountToolStripMenuItem = new ToolStripMenuItem();
            newAccountToolStripMenuItem1 = new ToolStripMenuItem();
            attCustomersToolStripMenuItem = new ToolStripMenuItem();
            іншеToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newAccountToolStripMenuItem, іншеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1089, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newAccountToolStripMenuItem
            // 
            newAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAccountToolStripMenuItem1, attCustomersToolStripMenuItem });
            newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            newAccountToolStripMenuItem.Size = new Size(90, 24);
            newAccountToolStripMenuItem.Text = "Клієнтура";
            // 
            // newAccountToolStripMenuItem1
            // 
            newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            newAccountToolStripMenuItem1.Size = new Size(183, 26);
            newAccountToolStripMenuItem1.Text = "Новий клієнт";
            newAccountToolStripMenuItem1.Click += newAccountToolStripMenuItem1_Click;
            // 
            // attCustomersToolStripMenuItem
            // 
            attCustomersToolStripMenuItem.Name = "attCustomersToolStripMenuItem";
            attCustomersToolStripMenuItem.Size = new Size(183, 26);
            attCustomersToolStripMenuItem.Text = "Клієнти";
            attCustomersToolStripMenuItem.Click += attCustomersToolStripMenuItem_Click;
            // 
            // іншеToolStripMenuItem
            // 
            іншеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            іншеToolStripMenuItem.Name = "іншеToolStripMenuItem";
            іншеToolStripMenuItem.Size = new Size(56, 24);
            іншеToolStripMenuItem.Text = "Інше";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Вийти";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 697);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1107, 744);
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newAccountToolStripMenuItem;
        private ToolStripMenuItem newAccountToolStripMenuItem1;
        private ToolStripMenuItem attCustomersToolStripMenuItem;
        private ToolStripMenuItem іншеToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}