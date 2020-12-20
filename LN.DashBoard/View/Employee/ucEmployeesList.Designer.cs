namespace LN.DashBoard
{
    partial class ucEmployeesList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcEmployeeList = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gColEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 111);
            this.panel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnAddNew);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(569, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(567, 111);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Chức năng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(335, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 44);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Chỉnh sửa";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(39, 53);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(198, 44);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(568, 111);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(445, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(5, 31);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(558, 28);
            this.txtSearch.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcEmployeeList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 566);
            this.panel2.TabIndex = 1;
            // 
            // gcEmployeeList
            // 
            this.gcEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.gcEmployeeList.MainView = this.gvEmployeeList;
            this.gcEmployeeList.Name = "gcEmployeeList";
            this.gcEmployeeList.Size = new System.Drawing.Size(1136, 566);
            this.gcEmployeeList.TabIndex = 0;
            this.gcEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeList});
            // 
            // gvEmployeeList
            // 
            this.gvEmployeeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColEmployeeCode,
            this.gColEmployeeName,
            this.gColBirthDay,
            this.gColGender,
            this.gColPhone,
            this.gColAddress,
            this.gColPosition,
            this.gColPositionID});
            this.gvEmployeeList.GridControl = this.gcEmployeeList;
            this.gvEmployeeList.Name = "gvEmployeeList";
            this.gvEmployeeList.OptionsView.ShowGroupPanel = false;
            // 
            // gColEmployeeCode
            // 
            this.gColEmployeeCode.Caption = "Mã nhân viên";
            this.gColEmployeeCode.FieldName = "EmployeeCode";
            this.gColEmployeeCode.MinWidth = 25;
            this.gColEmployeeCode.Name = "gColEmployeeCode";
            this.gColEmployeeCode.Visible = true;
            this.gColEmployeeCode.VisibleIndex = 0;
            this.gColEmployeeCode.Width = 94;
            // 
            // gColEmployeeName
            // 
            this.gColEmployeeName.Caption = "Tên nhân viên";
            this.gColEmployeeName.FieldName = "Name";
            this.gColEmployeeName.MinWidth = 25;
            this.gColEmployeeName.Name = "gColEmployeeName";
            this.gColEmployeeName.Visible = true;
            this.gColEmployeeName.VisibleIndex = 1;
            this.gColEmployeeName.Width = 94;
            // 
            // gColBirthDay
            // 
            this.gColBirthDay.Caption = "Ngày sinh";
            this.gColBirthDay.FieldName = "Birth";
            this.gColBirthDay.MinWidth = 25;
            this.gColBirthDay.Name = "gColBirthDay";
            this.gColBirthDay.Visible = true;
            this.gColBirthDay.VisibleIndex = 2;
            this.gColBirthDay.Width = 94;
            // 
            // gColGender
            // 
            this.gColGender.Caption = "Giới tính";
            this.gColGender.FieldName = "Gender";
            this.gColGender.MinWidth = 25;
            this.gColGender.Name = "gColGender";
            this.gColGender.Visible = true;
            this.gColGender.VisibleIndex = 3;
            this.gColGender.Width = 94;
            // 
            // gColPhone
            // 
            this.gColPhone.Caption = "Số điện thoại";
            this.gColPhone.FieldName = "Phone";
            this.gColPhone.MinWidth = 25;
            this.gColPhone.Name = "gColPhone";
            this.gColPhone.Visible = true;
            this.gColPhone.VisibleIndex = 4;
            this.gColPhone.Width = 94;
            // 
            // gColAddress
            // 
            this.gColAddress.Caption = "Địa chỉ";
            this.gColAddress.FieldName = "Address";
            this.gColAddress.MinWidth = 25;
            this.gColAddress.Name = "gColAddress";
            this.gColAddress.Visible = true;
            this.gColAddress.VisibleIndex = 5;
            this.gColAddress.Width = 94;
            // 
            // gColPosition
            // 
            this.gColPosition.Caption = "Chức vụ";
            this.gColPosition.FieldName = "PositionName";
            this.gColPosition.MinWidth = 25;
            this.gColPosition.Name = "gColPosition";
            this.gColPosition.Visible = true;
            this.gColPosition.VisibleIndex = 6;
            this.gColPosition.Width = 94;
            // 
            // gColPositionID
            // 
            this.gColPositionID.Caption = "gridColumn1";
            this.gColPositionID.FieldName = "PositionID";
            this.gColPositionID.MinWidth = 25;
            this.gColPositionID.Name = "gColPositionID";
            this.gColPositionID.Width = 94;
            // 
            // ucEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucEmployeesList";
            this.Size = new System.Drawing.Size(1136, 677);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeList;
        private DevExpress.XtraGrid.Columns.GridColumn gColEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn gColEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn gColBirthDay;
        private DevExpress.XtraGrid.Columns.GridColumn gColGender;
        private DevExpress.XtraGrid.Columns.GridColumn gColPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gColAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gColPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gColPositionID;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}
