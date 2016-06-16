namespace TileGame
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.panMap = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookForTroubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harvestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookForTreasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.Location = new System.Drawing.Point(12, 12);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(750, 750);
            this.panMap.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.lookForTroubleToolStripMenuItem,
            this.harvestToolStripMenuItem,
            this.fightToolStripMenuItem,
            this.lookForTreasureToolStripMenuItem,
            this.barterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 158);
            this.contextMenuStrip1.Text = "Look for Trouble";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.testToolStripMenuItem.Text = "Forage";
            // 
            // lookForTroubleToolStripMenuItem
            // 
            this.lookForTroubleToolStripMenuItem.Name = "lookForTroubleToolStripMenuItem";
            this.lookForTroubleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lookForTroubleToolStripMenuItem.Text = "Look for Trouble";
            // 
            // harvestToolStripMenuItem
            // 
            this.harvestToolStripMenuItem.Name = "harvestToolStripMenuItem";
            this.harvestToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.harvestToolStripMenuItem.Text = "Harvest";
            // 
            // fightToolStripMenuItem
            // 
            this.fightToolStripMenuItem.Name = "fightToolStripMenuItem";
            this.fightToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fightToolStripMenuItem.Text = "Fight";
            this.fightToolStripMenuItem.Click += new System.EventHandler(this.fightToolStripMenuItem_Click);
            // 
            // lookForTreasureToolStripMenuItem
            // 
            this.lookForTreasureToolStripMenuItem.Name = "lookForTreasureToolStripMenuItem";
            this.lookForTreasureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lookForTreasureToolStripMenuItem.Text = "Look for Treasure";
            // 
            // barterToolStripMenuItem
            // 
            this.barterToolStripMenuItem.Name = "barterToolStripMenuItem";
            this.barterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.barterToolStripMenuItem.Text = "Barter";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 781);
            this.Controls.Add(this.panMap);
            this.Name = "MainWindow";
            this.Text = "Austera";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.action_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookForTroubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harvestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookForTreasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barterToolStripMenuItem;
    }
}

