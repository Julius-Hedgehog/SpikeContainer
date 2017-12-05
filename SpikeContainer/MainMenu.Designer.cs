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
            this.SuspendLayout();
            // 
            // SpikeOne
            // 
            this.SpikeOne.Location = new System.Drawing.Point(13, 46);
            this.SpikeOne.Name = "SpikeOne";
            this.SpikeOne.Size = new System.Drawing.Size(342, 23);
            this.SpikeOne.TabIndex = 0;
            this.SpikeOne.Text = "Spike One - Key Pad Pre Testing";
            this.SpikeOne.Click += new System.EventHandler(this.SpikeOne_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 448);
            this.Controls.Add(this.SpikeOne);
            this.Name = "MainMenu";
            this.Text = "Spike Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SpikeOne;
    }
}

