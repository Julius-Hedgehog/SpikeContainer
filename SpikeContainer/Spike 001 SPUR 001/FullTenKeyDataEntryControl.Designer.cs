namespace SpikeContainer.Spike_001_SPUR_001
{
    partial class FullTenKeyDataEntryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tenKeyPadControl1_11 = new SpikeContainer.Spike_001.TenKeyPadControl1_1();
            this.clearClearEntryKeyPadControl1 = new SpikeContainer.Spike_001_SPUR_001.ClearClearEntryKeyPadControl();
            this.dialogResultsControl1 = new SpikeContainer.Spike_001_SPUR_001.DialogResultsControl();
            this.SuspendLayout();
            // 
            // tenKeyPadControl1_11
            // 
            this.tenKeyPadControl1_11.Location = new System.Drawing.Point(0, -3);
            this.tenKeyPadControl1_11.Name = "tenKeyPadControl1_11";
            this.tenKeyPadControl1_11.Size = new System.Drawing.Size(243, 327);
            this.tenKeyPadControl1_11.TabIndex = 0;
            // 
            // clearClearEntryKeyPadControl1
            // 
            this.clearClearEntryKeyPadControl1.Location = new System.Drawing.Point(0, 324);
            this.clearClearEntryKeyPadControl1.Name = "clearClearEntryKeyPadControl1";
            this.clearClearEntryKeyPadControl1.Size = new System.Drawing.Size(243, 82);
            this.clearClearEntryKeyPadControl1.TabIndex = 1;
            // 
            // dialogResultsControl1
            // 
            this.dialogResultsControl1.Location = new System.Drawing.Point(0, 407);
            this.dialogResultsControl1.Name = "dialogResultsControl1";
            this.dialogResultsControl1.Size = new System.Drawing.Size(243, 82);
            this.dialogResultsControl1.TabIndex = 2;
            // 
            // FullTenKeyDataEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dialogResultsControl1);
            this.Controls.Add(this.clearClearEntryKeyPadControl1);
            this.Controls.Add(this.tenKeyPadControl1_11);
            this.Name = "FullTenKeyDataEntryControl";
            this.Size = new System.Drawing.Size(243, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private Spike_001.TenKeyPadControl1_1 tenKeyPadControl1_11;
        private ClearClearEntryKeyPadControl clearClearEntryKeyPadControl1;
        private DialogResultsControl dialogResultsControl1;
    }
}
