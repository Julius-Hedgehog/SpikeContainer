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
            this.GrossLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TareLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetResultsLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(13, 13);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(664, 430);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Validated += new System.EventHandler(this.gridControl2_Validated);
            // 
            // gridView2
            // 
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GrossLbs,
            this.TareLbs,
            this.NetResultsLbs});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsCustomization.AllowColumnMoving = false;
            this.gridView2.OptionsCustomization.AllowColumnResizing = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsLayout.Columns.AddNewColumns = false;
            this.gridView2.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsMenu.EnableFooterMenu = false;
            this.gridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView2.OptionsNavigation.UseOfficePageNavigation = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "Weight Data - ";
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
            // GrossLbs
            // 
            this.GrossLbs.Caption = "Gross Weight (lbs)";
            this.GrossLbs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GrossLbs.FieldName = "GrossLbs";
            this.GrossLbs.Name = "GrossLbs";
            this.GrossLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.GrossLbs.Visible = true;
            this.GrossLbs.VisibleIndex = 0;
            // 
            // TareLbs
            // 
            this.TareLbs.Caption = "Tare Weight (lbs)";
            this.TareLbs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TareLbs.FieldName = "TareLbs";
            this.TareLbs.Name = "TareLbs";
            this.TareLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TareLbs.Visible = true;
            this.TareLbs.VisibleIndex = 1;
            // 
            // NetResultsLbs
            // 
            this.NetResultsLbs.Caption = "Net Weight (lbs)";
            this.NetResultsLbs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetResultsLbs.FieldName = "NetResultsLbs";
            this.NetResultsLbs.Name = "NetResultsLbs";
            this.NetResultsLbs.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetResultLbs", "{0:#.##}")});
            this.NetResultsLbs.UnboundExpression = "[GrossLbs] - [TareLbs]";
            this.NetResultsLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.NetResultsLbs.Visible = true;
            this.NetResultsLbs.VisibleIndex = 2;
            // 
            // GridLearnXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 474);
            this.Controls.Add(this.gridControl2);
            this.Name = "GridLearnXtraForm";
            this.Text = "GridLearnXtraForm - - Part Two Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridLearnXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.GridLearnXtraForm_Load);
            this.Shown += new System.EventHandler(this.GridLearnXtraForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Columns.GridColumn GrossLbs;
        private DevExpress.XtraGrid.Columns.GridColumn TareLbs;
        private DevExpress.XtraGrid.Columns.GridColumn NetResultLbs;//NetResultsLbs //NetResultLbs
        private DevExpress.XtraGrid.Columns.GridColumn NetResultsLbs;
    }
}