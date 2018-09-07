namespace SpikeContainer.SPIKE_015
{
    partial class XtraForm3
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
            this.xtraUserControl12 = new SpikeContainer.SPIKE_015.XtraUserControl1();
            this.xtraUserControl11 = new SpikeContainer.SPIKE_015.XtraUserControl1();
            this.SuspendLayout();
            // 
            // xtraUserControl12
            // 
            this.xtraUserControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraUserControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xtraUserControl12.Location = new System.Drawing.Point(99, 3);
            this.xtraUserControl12.Name = "xtraUserControl12";
            this.xtraUserControl12.Size = new System.Drawing.Size(90, 90);
            this.xtraUserControl12.TabIndex = 1;
            // 
            // xtraUserControl11
            // 
            this.xtraUserControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraUserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xtraUserControl11.Location = new System.Drawing.Point(3, 3);
            this.xtraUserControl11.Name = "xtraUserControl11";
            this.xtraUserControl11.Size = new System.Drawing.Size(90, 90);
            this.xtraUserControl11.TabIndex = 0;
            // 
            // XtraForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 185);
            this.Controls.Add(this.xtraUserControl12);
            this.Controls.Add(this.xtraUserControl11);
            this.Name = "XtraForm3";
            this.Text = "Spike 015 :: A.01";
            this.SizeChanged += new System.EventHandler(this.XtraForm3_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraUserControl1 xtraUserControl11;
        private XtraUserControl1 xtraUserControl12;
    }
}