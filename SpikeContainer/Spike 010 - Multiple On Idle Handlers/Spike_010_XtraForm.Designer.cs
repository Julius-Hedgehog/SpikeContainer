namespace SpikeContainer.Spike_010___Multiple_On_Idle_Handlers
{
    partial class Spike_010_XtraForm
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
            this.applicationIdle1 = new Winforms.Components.ApplicationIdle();
            this.applicationIdle2 = new Winforms.Components.ApplicationIdle();
            this.applicationIdle3 = new Winforms.Components.ApplicationIdle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // applicationIdle1
            // 
            this.applicationIdle1.Idle += new System.EventHandler(this.ApplicationIdle1Idle);
            // 
            // applicationIdle2
            // 
            this.applicationIdle2.Idle += new System.EventHandler(this.ApplicationIdle2Idle);
            // 
            // applicationIdle3
            // 
            this.applicationIdle3.Idle += new System.EventHandler(this.ApplicationIdle3Idle);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(130, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(711, 576);
            this.textBox1.TabIndex = 2;
            // 
            // Spike_010_XtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 629);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Spike_010_XtraForm";
            this.Text = "Spike_010_XtraForm - Multiple On Idle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Winforms.Components.ApplicationIdle applicationIdle1;
        private Winforms.Components.ApplicationIdle applicationIdle2;
        private Winforms.Components.ApplicationIdle applicationIdle3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox textBox1;
    }
}