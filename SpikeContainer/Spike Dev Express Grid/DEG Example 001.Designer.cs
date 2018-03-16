namespace SpikeContainer.Spike_Dev_Express_Grid
{
    partial class DEG_Example_001
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
            this.components = new System.ComponentModel.Container();
            this.testMesDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testMesDbDataSet = new SpikeContainer.TestMesDbDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new SpikeContainer.TestMesDbDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new SpikeContainer.TestMesDbDataSetTableAdapters.TableAdapterManager();
            this.locationsTableAdapter1 = new SpikeContainer.TestMesDbDataSetTableAdapters.LocationsTableAdapter();
            this.pkgHistTableAdapter1 = new SpikeContainer.TestMesDbDataSetTableAdapters.PkgHistTableAdapter();
            this.statusTableAdapter1 = new SpikeContainer.TestMesDbDataSetTableAdapters.StatusTableAdapter();
            this.warehousesTableAdapter1 = new SpikeContainer.TestMesDbDataSetTableAdapters.WarehousesTableAdapter();
            this.workOrdersTableAdapter1 = new SpikeContainer.TestMesDbDataSetTableAdapters.WorkOrdersTableAdapter();
            this.workOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWorkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActStartLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActCheckLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDyeLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentWorkOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQcCheckInDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQcCheckInBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQcReleasedDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQcReleasedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // testMesDbDataSetBindingSource
            // 
            this.testMesDbDataSetBindingSource.DataSource = this.testMesDbDataSet;
            this.testMesDbDataSetBindingSource.Position = 0;
            // 
            // testMesDbDataSet
            // 
            this.testMesDbDataSet.DataSetName = "TestMesDbDataSet";
            this.testMesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.testMesDbDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArelContainersTableAdapter = null;
            this.tableAdapterManager.ArelLotsRecipeTableAdapter = null;
            this.tableAdapterManager.ArelLotsTableAdapter = null;
            this.tableAdapterManager.AutomatedEmailTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BinsTableAdapter = null;
            this.tableAdapterManager.DhPlanTableAdapter = null;
            this.tableAdapterManager.LocalVariablesTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = this.locationsTableAdapter1;
            this.tableAdapterManager.MenuItemsTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.PermissionsTableAdapter = null;
            this.tableAdapterManager.PkgHistTableAdapter = this.pkgHistTableAdapter1;
            this.tableAdapterManager.Pro2SQLTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter1;
            this.tableAdapterManager.SystemParamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpikeContainer.TestMesDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehousesTableAdapter = this.warehousesTableAdapter1;
            this.tableAdapterManager.WoConsuptionStepsTableAdapter = null;
            this.tableAdapterManager.WorkOrdersTableAdapter = this.workOrdersTableAdapter1;
            // 
            // locationsTableAdapter1
            // 
            this.locationsTableAdapter1.ClearBeforeFill = true;
            // 
            // pkgHistTableAdapter1
            // 
            this.pkgHistTableAdapter1.ClearBeforeFill = true;
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter1
            // 
            this.warehousesTableAdapter1.ClearBeforeFill = true;
            // 
            // workOrdersTableAdapter1
            // 
            this.workOrdersTableAdapter1.ClearBeforeFill = true;
            // 
            // workOrdersBindingSource
            // 
            this.workOrdersBindingSource.DataMember = "WorkOrders";
            this.workOrdersBindingSource.DataSource = this.testMesDbDataSetBindingSource;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.workOrdersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkOrder,
            this.colItem,
            this.colMasterItem,
            this.colColor,
            this.colActStartLbs,
            this.colActCheckLbs,
            this.colStatus,
            this.colDyeLot,
            this.colParentWorkOrder,
            this.colQcCheckInDt,
            this.colQcCheckInBy,
            this.colQcReleasedDt,
            this.colQcReleasedBy,
            this.colMilLot,
            this.colClosedBy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colWorkOrder
            // 
            this.colWorkOrder.FieldName = "WorkOrder";
            this.colWorkOrder.Name = "colWorkOrder";
            this.colWorkOrder.Visible = true;
            this.colWorkOrder.VisibleIndex = 0;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 1;
            // 
            // colMasterItem
            // 
            this.colMasterItem.FieldName = "MasterItem";
            this.colMasterItem.Name = "colMasterItem";
            this.colMasterItem.Visible = true;
            this.colMasterItem.VisibleIndex = 2;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 3;
            // 
            // colActStartLbs
            // 
            this.colActStartLbs.FieldName = "ActStartLbs";
            this.colActStartLbs.Name = "colActStartLbs";
            this.colActStartLbs.Visible = true;
            this.colActStartLbs.VisibleIndex = 4;
            // 
            // colActCheckLbs
            // 
            this.colActCheckLbs.FieldName = "ActCheckLbs";
            this.colActCheckLbs.Name = "colActCheckLbs";
            this.colActCheckLbs.Visible = true;
            this.colActCheckLbs.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // colDyeLot
            // 
            this.colDyeLot.FieldName = "DyeLot";
            this.colDyeLot.Name = "colDyeLot";
            this.colDyeLot.Visible = true;
            this.colDyeLot.VisibleIndex = 7;
            // 
            // colParentWorkOrder
            // 
            this.colParentWorkOrder.FieldName = "ParentWorkOrder";
            this.colParentWorkOrder.Name = "colParentWorkOrder";
            this.colParentWorkOrder.Visible = true;
            this.colParentWorkOrder.VisibleIndex = 8;
            // 
            // colQcCheckInDt
            // 
            this.colQcCheckInDt.FieldName = "QcCheckInDt";
            this.colQcCheckInDt.Name = "colQcCheckInDt";
            this.colQcCheckInDt.Visible = true;
            this.colQcCheckInDt.VisibleIndex = 9;
            // 
            // colQcCheckInBy
            // 
            this.colQcCheckInBy.FieldName = "QcCheckInBy";
            this.colQcCheckInBy.Name = "colQcCheckInBy";
            this.colQcCheckInBy.Visible = true;
            this.colQcCheckInBy.VisibleIndex = 10;
            // 
            // colQcReleasedDt
            // 
            this.colQcReleasedDt.FieldName = "QcReleasedDt";
            this.colQcReleasedDt.Name = "colQcReleasedDt";
            this.colQcReleasedDt.Visible = true;
            this.colQcReleasedDt.VisibleIndex = 11;
            // 
            // colQcReleasedBy
            // 
            this.colQcReleasedBy.FieldName = "QcReleasedBy";
            this.colQcReleasedBy.Name = "colQcReleasedBy";
            this.colQcReleasedBy.Visible = true;
            this.colQcReleasedBy.VisibleIndex = 12;
            // 
            // colMilLot
            // 
            this.colMilLot.FieldName = "MilLot";
            this.colMilLot.Name = "colMilLot";
            this.colMilLot.Visible = true;
            this.colMilLot.VisibleIndex = 13;
            // 
            // colClosedBy
            // 
            this.colClosedBy.FieldName = "ClosedBy";
            this.colClosedBy.Name = "colClosedBy";
            this.colClosedBy.Visible = true;
            this.colClosedBy.VisibleIndex = 14;
            // 
            // DEG_Example_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 340);
            this.Controls.Add(this.gridControl1);
            this.Name = "DEG_Example_001";
            this.Text = "DEG_Example_001";
            this.Load += new System.EventHandler(this.DEG_Example_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TestMesDbDataSet testMesDbDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TestMesDbDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TestMesDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource testMesDbDataSetBindingSource;
        private TestMesDbDataSetTableAdapters.PkgHistTableAdapter pkgHistTableAdapter1;
        private TestMesDbDataSetTableAdapters.WorkOrdersTableAdapter workOrdersTableAdapter1;
        private TestMesDbDataSetTableAdapters.StatusTableAdapter statusTableAdapter1;
        private TestMesDbDataSetTableAdapters.WarehousesTableAdapter warehousesTableAdapter1;
        private TestMesDbDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter1;
        private System.Windows.Forms.BindingSource workOrdersBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterItem;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colActStartLbs;
        private DevExpress.XtraGrid.Columns.GridColumn colActCheckLbs;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDyeLot;
        private DevExpress.XtraGrid.Columns.GridColumn colParentWorkOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colQcCheckInDt;
        private DevExpress.XtraGrid.Columns.GridColumn colQcCheckInBy;
        private DevExpress.XtraGrid.Columns.GridColumn colQcReleasedDt;
        private DevExpress.XtraGrid.Columns.GridColumn colQcReleasedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colMilLot;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedBy;
    }
}