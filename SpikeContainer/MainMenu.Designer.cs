namespace SpikeContainer
{
    partial class MainMenu
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
            this.SpikeOne = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spikesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spikeOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spikeTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spikeOneSpurOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dexbtnSpike1Spur1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpikeOne
            // 
            this.SpikeOne.Location = new System.Drawing.Point(12, 27);
            this.SpikeOne.Name = "SpikeOne";
            this.SpikeOne.Size = new System.Drawing.Size(286, 23);
            this.SpikeOne.TabIndex = 0;
            this.SpikeOne.Text = "Spike One - Key Pad Pre Testing";
            this.SpikeOne.Click += new System.EventHandler(this.SpikeOne_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(0, 47);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spikesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spikesToolStripMenuItem
            // 
            this.spikesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spikeOneToolStripMenuItem,
            this.spikeTwoToolStripMenuItem,
            this.spikeOneSpurOneToolStripMenuItem});
            this.spikesToolStripMenuItem.Name = "spikesToolStripMenuItem";
            this.spikesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.spikesToolStripMenuItem.Text = "Spikes A Group Projects";
            // 
            // spikeOneToolStripMenuItem
            // 
            this.spikeOneToolStripMenuItem.Name = "spikeOneToolStripMenuItem";
            this.spikeOneToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.spikeOneToolStripMenuItem.Text = "Spike One";
            this.spikeOneToolStripMenuItem.Click += new System.EventHandler(this.SpikeOne_Click);
            // 
            // spikeTwoToolStripMenuItem
            // 
            this.spikeTwoToolStripMenuItem.Name = "spikeTwoToolStripMenuItem";
            this.spikeTwoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.spikeTwoToolStripMenuItem.Text = "Spike Two";
            this.spikeTwoToolStripMenuItem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spikeOneSpurOneToolStripMenuItem
            // 
            this.spikeOneSpurOneToolStripMenuItem.Name = "spikeOneSpurOneToolStripMenuItem";
            this.spikeOneSpurOneToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.spikeOneSpurOneToolStripMenuItem.Text = "Spike One Spur One";
            this.spikeOneSpurOneToolStripMenuItem.Click += new System.EventHandler(this.dexbtnSpike1Spur1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 89);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(286, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Spike Two - Dev Express Grid Learning";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dexbtnSpike1Spur1
            // 
            this.dexbtnSpike1Spur1.Location = new System.Drawing.Point(43, 56);
            this.dexbtnSpike1Spur1.Name = "dexbtnSpike1Spur1";
            this.dexbtnSpike1Spur1.Size = new System.Drawing.Size(286, 23);
            this.dexbtnSpike1Spur1.TabIndex = 3;
            this.dexbtnSpike1Spur1.Text = "Spike One - Spur One";
            this.dexbtnSpike1Spur1.Click += new System.EventHandler(this.dexbtnSpike1Spur1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 118);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(286, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Spike Three - Dev Express Combo/List Box Learning";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 448);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dexbtnSpike1Spur1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SpikeOne);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Spike Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SpikeOne;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spikesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spikeOneToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ToolStripMenuItem spikeTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spikeOneSpurOneToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton dexbtnSpike1Spur1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

