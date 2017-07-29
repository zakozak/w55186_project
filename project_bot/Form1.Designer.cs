namespace project_bot
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
            this.showStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFromStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStoreToolStripMenuItem,
            this.storeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showStoreToolStripMenuItem
            // 
            this.showStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOrdersToolStripMenuItem,
            this.addOrderToolStripMenuItem});
            this.showStoreToolStripMenuItem.Name = "showStoreToolStripMenuItem";
            this.showStoreToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.showStoreToolStripMenuItem.Text = "Orders";
            // 
            // showOrdersToolStripMenuItem
            // 
            this.showOrdersToolStripMenuItem.Name = "showOrdersToolStripMenuItem";
            this.showOrdersToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.showOrdersToolStripMenuItem.Text = "Show orders";
            this.showOrdersToolStripMenuItem.Click += new System.EventHandler(this.showOrdersToolStripMenuItem_Click);
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addOrderToolStripMenuItem.Text = "Add order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStoreToolStripMenuItem1,
            this.addToStoreToolStripMenuItem,
            this.deleteFromStoreToolStripMenuItem});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // showStoreToolStripMenuItem1
            // 
            this.showStoreToolStripMenuItem1.Name = "showStoreToolStripMenuItem1";
            this.showStoreToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.showStoreToolStripMenuItem1.Text = "Show store";
            this.showStoreToolStripMenuItem1.Click += new System.EventHandler(this.showStoreToolStripMenuItem1_Click);
            // 
            // addToStoreToolStripMenuItem
            // 
            this.addToStoreToolStripMenuItem.Name = "addToStoreToolStripMenuItem";
            this.addToStoreToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addToStoreToolStripMenuItem.Text = "Add to store";
            this.addToStoreToolStripMenuItem.Click += new System.EventHandler(this.addToStoreToolStripMenuItem_Click);
            // 
            // deleteFromStoreToolStripMenuItem
            // 
            this.deleteFromStoreToolStripMenuItem.Name = "deleteFromStoreToolStripMenuItem";
            this.deleteFromStoreToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteFromStoreToolStripMenuItem.Text = "Delete from store";
            this.deleteFromStoreToolStripMenuItem.Click += new System.EventHandler(this.deleteFromStoreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 532);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFromStoreToolStripMenuItem;
    }
}

