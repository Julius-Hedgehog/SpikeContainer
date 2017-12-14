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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testMesDbDataSet = new SpikeContainer.TestMesDbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSerialNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShopOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasterItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLstOp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLstMach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowYds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCutOffYds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCutOffDefectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinWidth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQualCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossYds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetYds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspBegTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTareLbs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReInspReqd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReInspBegTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReInspEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoldPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoldFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReworked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRejected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBinNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLstShopOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRFG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelschedID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShadeGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMilLotRep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.packagesTableAdapter = new SpikeContainer.TestMesDbDataSetTableAdapters.PackagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.packagesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2653, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.testMesDbDataSet;
            // 
            // testMesDbDataSet
            // 
            this.testMesDbDataSet.DataSetName = "TestMesDbDataSet";
            this.testMesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSerialNo,
            this.colShopOrderNo,
            this.colItem,
            this.colMasterItem,
            this.colColor,
            this.colLstOp,
            this.colLstMach,
            this.colAllowYds,
            this.colCutOffYds,
            this.colCutOffDefectCode,
            this.colFinWidth,
            this.colGrade,
            this.colQualCode,
            this.colGrossYds,
            this.colNetYds,
            this.colInspBegTime,
            this.colInspEndTime,
            this.colNetLbs,
            this.colTareLbs,
            this.colReInspReqd,
            this.colReInspBegTime,
            this.colReInspEndTime,
            this.colHoldPiece,
            this.colHoldFor,
            this.colReworked,
            this.colRejected,
            this.colWarehouse,
            this.colLocation,
            this.colStatus,
            this.colChangedDate,
            this.colChangedBy,
            this.colBinNo,
            this.colPackFlag,
            this.colLstShopOrder,
            this.colFRFG,
            this.colDelschedID,
            this.colShadeGroup,
            this.colMilLotRep});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colShopOrderNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSerialNo
            // 
            this.colSerialNo.FieldName = "SerialNo";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.Visible = true;
            this.colSerialNo.VisibleIndex = 0;
            // 
            // colShopOrderNo
            // 
            this.colShopOrderNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colShopOrderNo.FieldName = "ShopOrderNo";
            this.colShopOrderNo.Name = "colShopOrderNo";
            this.colShopOrderNo.Visible = true;
            this.colShopOrderNo.VisibleIndex = 1;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 2;
            // 
            // colMasterItem
            // 
            this.colMasterItem.FieldName = "MasterItem";
            this.colMasterItem.Name = "colMasterItem";
            this.colMasterItem.Visible = true;
            this.colMasterItem.VisibleIndex = 3;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 4;
            // 
            // colLstOp
            // 
            this.colLstOp.FieldName = "LstOp";
            this.colLstOp.Name = "colLstOp";
            this.colLstOp.Visible = true;
            this.colLstOp.VisibleIndex = 5;
            // 
            // colLstMach
            // 
            this.colLstMach.FieldName = "LstMach";
            this.colLstMach.Name = "colLstMach";
            this.colLstMach.Visible = true;
            this.colLstMach.VisibleIndex = 6;
            // 
            // colAllowYds
            // 
            this.colAllowYds.FieldName = "AllowYds";
            this.colAllowYds.Name = "colAllowYds";
            this.colAllowYds.Visible = true;
            this.colAllowYds.VisibleIndex = 7;
            // 
            // colCutOffYds
            // 
            this.colCutOffYds.FieldName = "CutOffYds";
            this.colCutOffYds.Name = "colCutOffYds";
            this.colCutOffYds.Visible = true;
            this.colCutOffYds.VisibleIndex = 8;
            // 
            // colCutOffDefectCode
            // 
            this.colCutOffDefectCode.FieldName = "CutOffDefectCode";
            this.colCutOffDefectCode.Name = "colCutOffDefectCode";
            this.colCutOffDefectCode.Visible = true;
            this.colCutOffDefectCode.VisibleIndex = 9;
            // 
            // colFinWidth
            // 
            this.colFinWidth.FieldName = "FinWidth";
            this.colFinWidth.Name = "colFinWidth";
            this.colFinWidth.Visible = true;
            this.colFinWidth.VisibleIndex = 10;
            // 
            // colGrade
            // 
            this.colGrade.FieldName = "Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.Visible = true;
            this.colGrade.VisibleIndex = 11;
            // 
            // colQualCode
            // 
            this.colQualCode.FieldName = "QualCode";
            this.colQualCode.Name = "colQualCode";
            this.colQualCode.Visible = true;
            this.colQualCode.VisibleIndex = 12;
            // 
            // colGrossYds
            // 
            this.colGrossYds.FieldName = "GrossYds";
            this.colGrossYds.Name = "colGrossYds";
            this.colGrossYds.Visible = true;
            this.colGrossYds.VisibleIndex = 13;
            // 
            // colNetYds
            // 
            this.colNetYds.FieldName = "NetYds";
            this.colNetYds.Name = "colNetYds";
            this.colNetYds.Visible = true;
            this.colNetYds.VisibleIndex = 14;
            // 
            // colInspBegTime
            // 
            this.colInspBegTime.FieldName = "InspBegTime";
            this.colInspBegTime.Name = "colInspBegTime";
            this.colInspBegTime.Visible = true;
            this.colInspBegTime.VisibleIndex = 15;
            // 
            // colInspEndTime
            // 
            this.colInspEndTime.FieldName = "InspEndTime";
            this.colInspEndTime.Name = "colInspEndTime";
            this.colInspEndTime.Visible = true;
            this.colInspEndTime.VisibleIndex = 16;
            // 
            // colNetLbs
            // 
            this.colNetLbs.FieldName = "NetLbs";
            this.colNetLbs.Name = "colNetLbs";
            this.colNetLbs.Visible = true;
            this.colNetLbs.VisibleIndex = 17;
            // 
            // colTareLbs
            // 
            this.colTareLbs.FieldName = "TareLbs";
            this.colTareLbs.Name = "colTareLbs";
            this.colTareLbs.Visible = true;
            this.colTareLbs.VisibleIndex = 18;
            // 
            // colReInspReqd
            // 
            this.colReInspReqd.FieldName = "ReInspReqd";
            this.colReInspReqd.Name = "colReInspReqd";
            this.colReInspReqd.Visible = true;
            this.colReInspReqd.VisibleIndex = 19;
            // 
            // colReInspBegTime
            // 
            this.colReInspBegTime.FieldName = "ReInspBegTime";
            this.colReInspBegTime.Name = "colReInspBegTime";
            this.colReInspBegTime.Visible = true;
            this.colReInspBegTime.VisibleIndex = 20;
            // 
            // colReInspEndTime
            // 
            this.colReInspEndTime.FieldName = "ReInspEndTime";
            this.colReInspEndTime.Name = "colReInspEndTime";
            this.colReInspEndTime.Visible = true;
            this.colReInspEndTime.VisibleIndex = 21;
            // 
            // colHoldPiece
            // 
            this.colHoldPiece.FieldName = "HoldPiece";
            this.colHoldPiece.Name = "colHoldPiece";
            this.colHoldPiece.Visible = true;
            this.colHoldPiece.VisibleIndex = 22;
            // 
            // colHoldFor
            // 
            this.colHoldFor.FieldName = "HoldFor";
            this.colHoldFor.Name = "colHoldFor";
            this.colHoldFor.Visible = true;
            this.colHoldFor.VisibleIndex = 23;
            // 
            // colReworked
            // 
            this.colReworked.FieldName = "Reworked";
            this.colReworked.Name = "colReworked";
            this.colReworked.Visible = true;
            this.colReworked.VisibleIndex = 24;
            // 
            // colRejected
            // 
            this.colRejected.FieldName = "Rejected";
            this.colRejected.Name = "colRejected";
            this.colRejected.Visible = true;
            this.colRejected.VisibleIndex = 25;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 26;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 27;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 28;
            // 
            // colChangedDate
            // 
            this.colChangedDate.FieldName = "ChangedDate";
            this.colChangedDate.Name = "colChangedDate";
            this.colChangedDate.Visible = true;
            this.colChangedDate.VisibleIndex = 29;
            // 
            // colChangedBy
            // 
            this.colChangedBy.FieldName = "ChangedBy";
            this.colChangedBy.Name = "colChangedBy";
            this.colChangedBy.Visible = true;
            this.colChangedBy.VisibleIndex = 30;
            // 
            // colBinNo
            // 
            this.colBinNo.FieldName = "BinNo";
            this.colBinNo.Name = "colBinNo";
            this.colBinNo.Visible = true;
            this.colBinNo.VisibleIndex = 31;
            // 
            // colPackFlag
            // 
            this.colPackFlag.FieldName = "PackFlag";
            this.colPackFlag.Name = "colPackFlag";
            this.colPackFlag.Visible = true;
            this.colPackFlag.VisibleIndex = 32;
            // 
            // colLstShopOrder
            // 
            this.colLstShopOrder.FieldName = "LstShopOrder";
            this.colLstShopOrder.Name = "colLstShopOrder";
            this.colLstShopOrder.Visible = true;
            this.colLstShopOrder.VisibleIndex = 33;
            // 
            // colFRFG
            // 
            this.colFRFG.FieldName = "FRFG";
            this.colFRFG.Name = "colFRFG";
            this.colFRFG.Visible = true;
            this.colFRFG.VisibleIndex = 34;
            // 
            // colDelschedID
            // 
            this.colDelschedID.FieldName = "DelschedID";
            this.colDelschedID.Name = "colDelschedID";
            this.colDelschedID.Visible = true;
            this.colDelschedID.VisibleIndex = 35;
            // 
            // colShadeGroup
            // 
            this.colShadeGroup.FieldName = "ShadeGroup";
            this.colShadeGroup.Name = "colShadeGroup";
            this.colShadeGroup.Visible = true;
            this.colShadeGroup.VisibleIndex = 36;
            // 
            // colMilLotRep
            // 
            this.colMilLotRep.FieldName = "MilLotRep";
            this.colMilLotRep.Name = "colMilLotRep";
            this.colMilLotRep.Visible = true;
            this.colMilLotRep.VisibleIndex = 37;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // DEG_Example_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2653, 340);
            this.Controls.Add(this.gridControl1);
            this.Name = "DEG_Example_001";
            this.Text = "DEG_Example_001";
            this.Load += new System.EventHandler(this.DEG_Example_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testMesDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TestMesDbDataSet testMesDbDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TestMesDbDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShopOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMasterItem;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colLstOp;
        private DevExpress.XtraGrid.Columns.GridColumn colLstMach;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowYds;
        private DevExpress.XtraGrid.Columns.GridColumn colCutOffYds;
        private DevExpress.XtraGrid.Columns.GridColumn colCutOffDefectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFinWidth;
        private DevExpress.XtraGrid.Columns.GridColumn colGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colQualCode;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossYds;
        private DevExpress.XtraGrid.Columns.GridColumn colNetYds;
        private DevExpress.XtraGrid.Columns.GridColumn colInspBegTime;
        private DevExpress.XtraGrid.Columns.GridColumn colInspEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colNetLbs;
        private DevExpress.XtraGrid.Columns.GridColumn colTareLbs;
        private DevExpress.XtraGrid.Columns.GridColumn colReInspReqd;
        private DevExpress.XtraGrid.Columns.GridColumn colReInspBegTime;
        private DevExpress.XtraGrid.Columns.GridColumn colReInspEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colHoldPiece;
        private DevExpress.XtraGrid.Columns.GridColumn colHoldFor;
        private DevExpress.XtraGrid.Columns.GridColumn colReworked;
        private DevExpress.XtraGrid.Columns.GridColumn colRejected;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colBinNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPackFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colLstShopOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colFRFG;
        private DevExpress.XtraGrid.Columns.GridColumn colDelschedID;
        private DevExpress.XtraGrid.Columns.GridColumn colShadeGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colMilLotRep;
    }
}