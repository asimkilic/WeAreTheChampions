
namespace FormUI.Forms
{
    partial class FrmHome
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
            this.panelMdi = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.karşılaşmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMdi
            // 
            this.panelMdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdi.Location = new System.Drawing.Point(0, 24);
            this.panelMdi.Name = "panelMdi";
            this.panelMdi.Size = new System.Drawing.Size(1229, 717);
            this.panelMdi.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karşılaşmalarToolStripMenuItem,
            this.takımlarToolStripMenuItem,
            this.oyuncularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karşılaşmalarToolStripMenuItem
            // 
            this.karşılaşmalarToolStripMenuItem.Name = "karşılaşmalarToolStripMenuItem";
            this.karşılaşmalarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.karşılaşmalarToolStripMenuItem.Text = "Karşılaşmalar";
            // 
            // takımlarToolStripMenuItem
            // 
            this.takımlarToolStripMenuItem.Name = "takımlarToolStripMenuItem";
            this.takımlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.takımlarToolStripMenuItem.Text = "Takımlar";
            // 
            // oyuncularToolStripMenuItem
            // 
            this.oyuncularToolStripMenuItem.Name = "oyuncularToolStripMenuItem";
            this.oyuncularToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.oyuncularToolStripMenuItem.Text = "Oyuncular";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1229, 741);
            this.Controls.Add(this.panelMdi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMdi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karşılaşmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncularToolStripMenuItem;
    }
}