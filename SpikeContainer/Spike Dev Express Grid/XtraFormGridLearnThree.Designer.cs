namespace SpikeContainer.Spike_Dev_Express_Grid
{
    partial class XtraFormGridLearnThree
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
            this.Gross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Net = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(698, 458);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gross,
            this.Tare,
            this.Net});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowViewCaption = true;
            // 
            // Gross
            // 
            this.Gross.Caption = "Gross Weight (lbs)";
            this.Gross.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Gross.FieldName = "GrossLbs";
            this.Gross.Name = "Gross";
            this.Gross.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Gross.Visible = true;
            this.Gross.VisibleIndex = 0;
            // 
            // Tare
            // 
            this.Tare.Caption = "Tare Weight (lbs)";
            this.Tare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Tare.FieldName = "TareLbs";
            this.Tare.Name = "Tare";
            this.Tare.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Tare.Visible = true;
            this.Tare.VisibleIndex = 1;
            // 
            // Net
            // 
            this.Net.Caption = "Net Weight (lbs)";
            this.Net.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Net.FieldName = "NetResultLbs";
            this.Net.Name = "Net";
            this.Net.OptionsColumn.AllowEdit = false;
            this.Net.OptionsColumn.AllowFocus = false;
            this.Net.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetResultLbs", "{0:#.##}")});
            this.Net.UnboundExpression = "[GrossLbs] - [TareLbs]";
            this.Net.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Net.Visible = true;
            this.Net.VisibleIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 504);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraFormGridLearnThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 549);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraFormGridLearnThree";
            this.Text = "XtraFormGridLearnThree";
            this.Load += new System.EventHandler(this.XtraFormGridLearnThree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraGrid.Columns.GridColumn Gross;
        public DevExpress.XtraGrid.Columns.GridColumn Tare;
        public DevExpress.XtraGrid.Columns.GridColumn Net;
    }
}