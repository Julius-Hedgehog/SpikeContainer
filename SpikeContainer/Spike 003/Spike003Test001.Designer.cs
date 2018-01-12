namespace SpikeContainer.Spike_003
{
    partial class Spike003Test001
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBadgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordHash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangePass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTtmAccess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSantexAccess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKenyonAccess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShopOrders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = null;
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-1, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1237, 265);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(SpikeContainer.DataEntitiy.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserGuid,
            this.colUserId,
            this.colBadgeNo,
            this.colFirstName,
            this.colLastName,
            this.colMiddle,
            this.colPasswordHash,
            this.colActive,
            this.colTimeOut,
            this.colChangePass,
            this.colEmail,
            this.colAdmin,
            this.colWorkStation,
            this.colChangedDate,
            this.colChangedBy,
            this.colTtmAccess,
            this.colSantexAccess,
            this.colKenyonAccess,
            this.colPackages,
            this.colPermissions,
            this.colShopOrders});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colUserGuid
            // 
            this.colUserGuid.FieldName = "UserGuid";
            this.colUserGuid.Name = "colUserGuid";
            this.colUserGuid.Visible = true;
            this.colUserGuid.VisibleIndex = 0;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 1;
            // 
            // colBadgeNo
            // 
            this.colBadgeNo.FieldName = "BadgeNo";
            this.colBadgeNo.Name = "colBadgeNo";
            this.colBadgeNo.Visible = true;
            this.colBadgeNo.VisibleIndex = 2;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 3;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 4;
            // 
            // colMiddle
            // 
            this.colMiddle.FieldName = "Middle";
            this.colMiddle.Name = "colMiddle";
            this.colMiddle.Visible = true;
            this.colMiddle.VisibleIndex = 5;
            // 
            // colPasswordHash
            // 
            this.colPasswordHash.FieldName = "PasswordHash";
            this.colPasswordHash.Name = "colPasswordHash";
            this.colPasswordHash.Visible = true;
            this.colPasswordHash.VisibleIndex = 6;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 7;
            // 
            // colTimeOut
            // 
            this.colTimeOut.FieldName = "TimeOut";
            this.colTimeOut.Name = "colTimeOut";
            this.colTimeOut.Visible = true;
            this.colTimeOut.VisibleIndex = 8;
            // 
            // colChangePass
            // 
            this.colChangePass.FieldName = "ChangePass";
            this.colChangePass.Name = "colChangePass";
            this.colChangePass.Visible = true;
            this.colChangePass.VisibleIndex = 9;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 10;
            // 
            // colAdmin
            // 
            this.colAdmin.FieldName = "Admin";
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.Visible = true;
            this.colAdmin.VisibleIndex = 11;
            // 
            // colWorkStation
            // 
            this.colWorkStation.FieldName = "WorkStation";
            this.colWorkStation.Name = "colWorkStation";
            this.colWorkStation.Visible = true;
            this.colWorkStation.VisibleIndex = 12;
            // 
            // colChangedDate
            // 
            this.colChangedDate.FieldName = "ChangedDate";
            this.colChangedDate.Name = "colChangedDate";
            this.colChangedDate.Visible = true;
            this.colChangedDate.VisibleIndex = 13;
            // 
            // colChangedBy
            // 
            this.colChangedBy.FieldName = "ChangedBy";
            this.colChangedBy.Name = "colChangedBy";
            this.colChangedBy.Visible = true;
            this.colChangedBy.VisibleIndex = 14;
            // 
            // colTtmAccess
            // 
            this.colTtmAccess.FieldName = "TtmAccess";
            this.colTtmAccess.Name = "colTtmAccess";
            this.colTtmAccess.Visible = true;
            this.colTtmAccess.VisibleIndex = 15;
            // 
            // colSantexAccess
            // 
            this.colSantexAccess.FieldName = "SantexAccess";
            this.colSantexAccess.Name = "colSantexAccess";
            this.colSantexAccess.Visible = true;
            this.colSantexAccess.VisibleIndex = 16;
            // 
            // colKenyonAccess
            // 
            this.colKenyonAccess.FieldName = "KenyonAccess";
            this.colKenyonAccess.Name = "colKenyonAccess";
            this.colKenyonAccess.Visible = true;
            this.colKenyonAccess.VisibleIndex = 17;
            // 
            // colPackages
            // 
            this.colPackages.FieldName = "Packages";
            this.colPackages.Name = "colPackages";
            this.colPackages.Visible = true;
            this.colPackages.VisibleIndex = 18;
            // 
            // colPermissions
            // 
            this.colPermissions.FieldName = "Permissions";
            this.colPermissions.Name = "colPermissions";
            this.colPermissions.Visible = true;
            this.colPermissions.VisibleIndex = 19;
            // 
            // colShopOrders
            // 
            this.colShopOrders.FieldName = "ShopOrders";
            this.colShopOrders.Name = "colShopOrders";
            this.colShopOrders.Visible = true;
            this.colShopOrders.VisibleIndex = 20;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(27, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(284, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Load Data From Users";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dropDownButton1.Location = new System.Drawing.Point(1242, 30);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 1;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Location = new System.Drawing.Point(1401, 28);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(120, 95);
            this.listBoxControl1.TabIndex = 2;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(1527, 27);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "None",
            "Standard",
            "Supervisor",
            "Management",
            "Administrator",
            "InformationTech"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(240, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Location = new System.Drawing.Point(1242, 240);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsMenu.EnableContextMenu = true;
            this.vGridControl1.RecordWidth = 300;
            this.vGridControl1.Size = new System.Drawing.Size(697, 494);
            this.vGridControl1.TabIndex = 7;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(328, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(284, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Load Data From Users";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // treeList1
            // 
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;
            this.treeList1.Location = new System.Drawing.Point(-1, 329);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.treeList1.OptionsView.BestFitNodes = DevExpress.XtraTreeList.TreeListBestFitNodes.All;
            this.treeList1.OptionsView.ShowCaption = true;
            this.treeList1.Size = new System.Drawing.Size(1237, 212);
            this.treeList1.TabIndex = 9;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(-1, 544);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1237, 200);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            // 
            // Spike003Test001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1941, 746);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Spike003Test001";
            this.Text = "Spike003Test001";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colBadgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddle;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordHash;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeOut;
        private DevExpress.XtraGrid.Columns.GridColumn colChangePass;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkStation;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colTtmAccess;
        private DevExpress.XtraGrid.Columns.GridColumn colSantexAccess;
        private DevExpress.XtraGrid.Columns.GridColumn colKenyonAccess;
        private DevExpress.XtraGrid.Columns.GridColumn colPackages;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colShopOrders;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}