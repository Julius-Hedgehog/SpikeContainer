namespace SpikeContainer.Spike_001
{
    partial class Spike001V3_Grid0
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenKeypadControl11 = new SpikeContainer.Spike_001.TenKeypadControl1();
            this.GrossWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TareWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(562, 388);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrossWeight,
            this.TareWeight,
            this.NetWeight});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tenKeypadControl11
            // 
            this.tenKeypadControl11.CurrentValue = "";
            this.tenKeypadControl11.Location = new System.Drawing.Point(591, 12);
            this.tenKeypadControl11.Name = "tenKeypadControl11";
            this.tenKeypadControl11.Size = new System.Drawing.Size(254, 416);
            this.tenKeypadControl11.TabIndex = 1;
            // 
            // GrossWeight
            // 
            this.GrossWeight.Caption = "Gross Weight (Lbs)";
            this.GrossWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GrossWeight.FieldName = "Gross";
            this.GrossWeight.Name = "GrossWeight";
            this.GrossWeight.Visible = true;
            this.GrossWeight.VisibleIndex = 0;
            // 
            // TareWeight
            // 
            this.TareWeight.Caption = "Tare Weight (lbs)";
            this.TareWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TareWeight.FieldName = "Tare";
            this.TareWeight.Name = "TareWeight";
            this.TareWeight.Visible = true;
            this.TareWeight.VisibleIndex = 1;
            // 
            // NetWeight
            // 
            this.NetWeight.Caption = "Net Weight (lbs)";
            this.NetWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetWeight.FieldName = "NetWeight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.OptionsColumn.AllowEdit = false;
            this.NetWeight.OptionsColumn.AllowFocus = false;
            this.NetWeight.OptionsColumn.ReadOnly = true;
            this.NetWeight.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetWeight", "Total Net (lbs) = {0:0.##}")});
            this.NetWeight.UnboundExpression = "[Gross] - [Tare]";
            this.NetWeight.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.NetWeight.Visible = true;
            this.NetWeight.VisibleIndex = 2;
            // 
            // Spike001V3_Grid0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 439);
            this.Controls.Add(this.tenKeypadControl11);
            this.Controls.Add(this.gridControl1);
            this.Name = "Spike001V3_Grid0";
            this.Text = "Spike001V3_Grid0";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TenKeypadControl1 tenKeypadControl11;
        public DevExpress.XtraGrid.Columns.GridColumn GrossWeight;
        public DevExpress.XtraGrid.Columns.GridColumn TareWeight;
        private DevExpress.XtraGrid.Columns.GridColumn NetWeight;
    }
}