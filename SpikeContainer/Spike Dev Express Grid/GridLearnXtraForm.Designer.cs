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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrossLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TareLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetResultLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 536);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1120, 275);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(13, 261);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1120, 239);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(13, 13);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1119, 200);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Index,
            this.GrossLbs,
            this.TareLbs,
            this.NetResultLbs});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView3_CustomDrawRowIndicator);
            this.gridView3.ShownEditor += new System.EventHandler(this.gridView3_ShownEditor);
            this.gridView3.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView3_ValidateRow);
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            this.gridView3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView3_KeyDown);
            this.gridView3.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView3_ValidatingEditor);
            // 
            // Index
            // 
            this.Index.Caption = "Index";
            this.Index.FieldName = "Index";
            this.Index.Name = "Index";
            this.Index.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Index.Visible = true;
            this.Index.VisibleIndex = 0;
            // 
            // GrossLbs
            // 
            this.GrossLbs.Caption = "Gross Weight";
            this.GrossLbs.FieldName = "GrossLbs";
            this.GrossLbs.Name = "GrossLbs";
            this.GrossLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.GrossLbs.Visible = true;
            this.GrossLbs.VisibleIndex = 1;
            // 
            // TareLbs
            // 
            this.TareLbs.Caption = "Tare Weight";
            this.TareLbs.FieldName = "TareLbs";
            this.TareLbs.Name = "TareLbs";
            this.TareLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TareLbs.Visible = true;
            this.TareLbs.VisibleIndex = 2;
            // 
            // NetResultLbs
            // 
            this.NetResultLbs.Caption = "Net Weight";
            this.NetResultLbs.FieldName = "NetResultLbs";
            this.NetResultLbs.Name = "NetResultLbs";
            this.NetResultLbs.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.NetResultLbs.Visible = true;
            this.NetResultLbs.VisibleIndex = 3;
            // 
            // GridLearnXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 846);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "GridLearnXtraForm";
            this.Text = "GridLearnXtraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridLearnXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.GridLearnXtraForm_Load);
            this.Shown += new System.EventHandler(this.GridLearnXtraForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Index;
        private DevExpress.XtraGrid.Columns.GridColumn GrossLbs;
        private DevExpress.XtraGrid.Columns.GridColumn TareLbs;
        private DevExpress.XtraGrid.Columns.GridColumn NetResultLbs;
    }
}