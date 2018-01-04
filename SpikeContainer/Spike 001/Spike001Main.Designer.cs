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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
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
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
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
            this.simpleButton1.Size = new System.Drawing.Size(273, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Spike One Test A - Proof of Concept";
            this.simpleButton1.Click += new System.EventHandler(this.testAToolStripMenuItem_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(13, 58);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(273, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Spike One Test B - Proof of Concept";
            this.simpleButton2.Click += new System.EventHandler(this.testBToolStripMenuItem_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 87);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(273, 23);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Spike One Test C - Grid 1 - Dev Test Bed";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(13, 116);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(273, 23);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Spike One Test D - WPF Control - Proof of Concept";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Spike001Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 219);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
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
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}