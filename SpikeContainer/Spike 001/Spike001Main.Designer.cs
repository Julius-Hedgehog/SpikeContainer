namespace SpikeContainer.Spike_001
{
    partial class Spike001Main
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
            this.testAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testAToolStripMenuItem,
            this.testBToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(231, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testAToolStripMenuItem
            // 
            this.testAToolStripMenuItem.Name = "testAToolStripMenuItem";
            this.testAToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.testAToolStripMenuItem.Text = "Test A";
            this.testAToolStripMenuItem.Click += new System.EventHandler(this.testAToolStripMenuItem_Click);
            // 
            // testBToolStripMenuItem
            // 
            this.testBToolStripMenuItem.Name = "testBToolStripMenuItem";
            this.testBToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.testBToolStripMenuItem.Text = "Test B";
            this.testBToolStripMenuItem.Click += new System.EventHandler(this.testBToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(13, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(206, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Spike One Test A";
            this.simpleButton1.Click += new System.EventHandler(this.testAToolStripMenuItem_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(13, 58);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(206, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Spike One Test B";
            this.simpleButton2.Click += new System.EventHandler(this.testBToolStripMenuItem_Click);
            // 
            // Spike001Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 87);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Spike001Main";
            this.Text = "Spike001Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testBToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}