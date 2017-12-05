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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tenKeypadControl1 = new SpikeContainer.Spike_001.TenKeypadControl();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tenKeypadControl1
            // 
            this.tenKeypadControl1.Location = new System.Drawing.Point(464, 12);
            this.tenKeypadControl1.Name = "tenKeypadControl1";
            this.tenKeypadControl1.Size = new System.Drawing.Size(254, 417);
            this.tenKeypadControl1.TabIndex = 0;
            // 
            // Spike001Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tenKeypadControl1);
            this.Name = "Spike001Main";
            this.Text = "Spike001Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TenKeypadControl tenKeypadControl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}