namespace LN.DashBoard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accorFieldManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorSchedule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorSetupField = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorAddNewField = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorTournament = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorCustomerManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorCustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorRentPlayer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorPannedList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorEmployeeManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorEmployeeList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorShiftWork = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorAccountList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorUserPermission = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accorSelfDefinePermission = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 39);
            this.container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1035, 749);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accorFieldManagement,
            this.accorCustomerManagement,
            this.accorEmployeeManagement,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 749);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accorFieldManagement
            // 
            this.accorFieldManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accorSchedule,
            this.accorSetupField,
            this.accorAddNewField,
            this.accorTournament});
            this.accorFieldManagement.Name = "accorFieldManagement";
            this.accorFieldManagement.Text = "Quản lý sân bóng";
            // 
            // accorSchedule
            // 
            this.accorSchedule.Name = "accorSchedule";
            this.accorSchedule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorSchedule.Text = "Lịch đặt sân";
            // 
            // accorSetupField
            // 
            this.accorSetupField.Name = "accorSetupField";
            this.accorSetupField.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorSetupField.Text = "Cài đặt sân";
            // 
            // accorAddNewField
            // 
            this.accorAddNewField.Name = "accorAddNewField";
            this.accorAddNewField.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorAddNewField.Text = "Thêm sân mới";
            // 
            // accorTournament
            // 
            this.accorTournament.Name = "accorTournament";
            this.accorTournament.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorTournament.Text = "Tạo giải đấu";
            // 
            // accorCustomerManagement
            // 
            this.accorCustomerManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accorCustomerList,
            this.accorRentPlayer,
            this.accorPannedList});
            this.accorCustomerManagement.Name = "accorCustomerManagement";
            this.accorCustomerManagement.Text = "Quản lý khách hàng";
            // 
            // accorCustomerList
            // 
            this.accorCustomerList.Name = "accorCustomerList";
            this.accorCustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorCustomerList.Text = "Danh sách khách hàng";
            // 
            // accorRentPlayer
            // 
            this.accorRentPlayer.Name = "accorRentPlayer";
            this.accorRentPlayer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorRentPlayer.Text = "Danh sách cầu thủ";
            // 
            // accorPannedList
            // 
            this.accorPannedList.Name = "accorPannedList";
            this.accorPannedList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorPannedList.Text = "Danh sách cấm";
            // 
            // accorEmployeeManagement
            // 
            this.accorEmployeeManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accorEmployeeList,
            this.accorShiftWork});
            this.accorEmployeeManagement.Expanded = true;
            this.accorEmployeeManagement.Name = "accorEmployeeManagement";
            this.accorEmployeeManagement.Text = "Quản lý nhân viên";
            // 
            // accorEmployeeList
            // 
            this.accorEmployeeList.Name = "accorEmployeeList";
            this.accorEmployeeList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorEmployeeList.Text = "Danh sách nhân viên";
            this.accorEmployeeList.Click += new System.EventHandler(this.accorEmployeeList_Click);
            // 
            // accorShiftWork
            // 
            this.accorShiftWork.Name = "accorShiftWork";
            this.accorShiftWork.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorShiftWork.Text = "Ca làm việc";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accorAccountList,
            this.accorUserPermission,
            this.accorSelfDefinePermission});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Phân quyền người dùng";
            // 
            // accorAccountList
            // 
            this.accorAccountList.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accorAccountList.Name = "accorAccountList";
            this.accorAccountList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorAccountList.Text = "Danh sách tài khoản";
            // 
            // accorUserPermission
            // 
            this.accorUserPermission.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accorUserPermission.Name = "accorUserPermission";
            this.accorUserPermission.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorUserPermission.Text = "Phân quyền";
            // 
            // accorSelfDefinePermission
            // 
            this.accorSelfDefinePermission.Name = "accorSelfDefinePermission";
            this.accorSelfDefinePermission.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accorSelfDefinePermission.Text = "Quyền tự định nghĩa";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1295, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 788);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Field Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorFieldManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorCustomerManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorEmployeeManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorSchedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorSetupField;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorAddNewField;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorTournament;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorCustomerList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorRentPlayer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorPannedList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorEmployeeList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorShiftWork;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorAccountList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorUserPermission;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accorSelfDefinePermission;
        private System.ComponentModel.IContainer components;
    }
}

