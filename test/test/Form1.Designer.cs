namespace test
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testyechuvchilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testyechishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boshlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiqishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testyechuvchilToolStripMenuItem,
            this.adminstratorToolStripMenuItem,
            this.chiqishToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testyechuvchilToolStripMenuItem
            // 
            this.testyechuvchilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testyechishToolStripMenuItem});
            this.testyechuvchilToolStripMenuItem.Name = "testyechuvchilToolStripMenuItem";
            this.testyechuvchilToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.testyechuvchilToolStripMenuItem.Text = "test_yechuvchilar";
            this.testyechuvchilToolStripMenuItem.Click += new System.EventHandler(this.testyechuvchilToolStripMenuItem_Click);
            // 
            // testyechishToolStripMenuItem
            // 
            this.testyechishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boshlashToolStripMenuItem});
            this.testyechishToolStripMenuItem.Name = "testyechishToolStripMenuItem";
            this.testyechishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testyechishToolStripMenuItem.Text = "test_yechish";
            // 
            // boshlashToolStripMenuItem
            // 
            this.boshlashToolStripMenuItem.Name = "boshlashToolStripMenuItem";
            this.boshlashToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boshlashToolStripMenuItem.Text = "boshlash";
            this.boshlashToolStripMenuItem.Click += new System.EventHandler(this.boshlashToolStripMenuItem_Click);
            // 
            // adminstratorToolStripMenuItem
            // 
            this.adminstratorToolStripMenuItem.Name = "adminstratorToolStripMenuItem";
            this.adminstratorToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.adminstratorToolStripMenuItem.Text = "adminstrator";
            this.adminstratorToolStripMenuItem.Click += new System.EventHandler(this.adminstratorToolStripMenuItem_Click);
            // 
            // chiqishToolStripMenuItem
            // 
            this.chiqishToolStripMenuItem.Name = "chiqishToolStripMenuItem";
            this.chiqishToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.chiqishToolStripMenuItem.Text = "chiqish";
            this.chiqishToolStripMenuItem.Click += new System.EventHandler(this.chiqishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testyechuvchilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminstratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testyechishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiqishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boshlashToolStripMenuItem;
    }
}

