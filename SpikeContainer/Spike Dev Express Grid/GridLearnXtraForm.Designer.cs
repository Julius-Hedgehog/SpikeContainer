namespace SpikeContainer.Spike_Dev_Express_Grid
{
    partial class GridLearnXtraForm
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gross = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Net = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 35);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1120, 799);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControl2_FocusedViewChanged);
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            this.gridControl2.Enter += new System.EventHandler(this.gridControl2_Enter);
            this.gridControl2.Leave += new System.EventHandler(this.gridControl2_Leave);
            this.gridControl2.Validating += new System.ComponentModel.CancelEventHandler(this.gridControl2_Validating);
            this.gridControl2.Validated += new System.EventHandler(this.gridControl2_Validated);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Gross,
            this.Tare,
            this.Net});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            this.gridView2.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView2_InitNewRow);
            this.gridView2.ShownEditor += new System.EventHandler(this.gridView2_ShownEditor);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            this.gridView2.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridView2_FocusedColumnChanged);
            this.gridView2.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView2_ValidateRow);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            this.gridView2.RowCountChanged += new System.EventHandler(this.gridView2_RowCountChanged);
            // 
            // Gross
            // 
            this.Gross.Caption = "Gross Weight (lbs)";
            this.Gross.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Gross.FieldName = "GrossLbs";
            this.Gross.Name = "Gross";
            this.Gross.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Gross.Visible = true;
            this.Gross.VisibleIndex = 0;
            // 
            // Tare
            // 
            this.Tare.Caption = "Tare Weight (lbs)";
            this.Tare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Tare.FieldName = "TareLbs";
            this.Tare.Name = "Tare";
            this.Tare.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Tare.Visible = true;
            this.Tare.VisibleIndex = 1;
            // 
            // Net
            // 
            this.Net.Caption = "Net Weight (lbs)";
            this.Net.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Net.FieldName = "NetResultLbs";
            this.Net.Name = "Net";
            this.Net.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetResultLbs", "{0:0.##}")});
            this.Net.UnboundExpression = "[GrossLbs] - [TareLbs]";
            this.Net.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Net.Visible = true;
            this.Net.VisibleIndex = 2;
            // 
            // GridLearnXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 846);
            this.Controls.Add(this.gridControl2);
            this.Name = "GridLearnXtraForm";
            this.Text = "GridLearnXtraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridLearnXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.GridLearnXtraForm_Load);
            this.Shown += new System.EventHandler(this.GridLearnXtraForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn Gross;
        public DevExpress.XtraGrid.Columns.GridColumn Tare;
        public DevExpress.XtraGrid.Columns.GridColumn Net;
    }
}