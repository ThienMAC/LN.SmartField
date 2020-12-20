using LN.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LN.DashBoard.View.Employee
{
    public partial class frmAddNewEmployee : Form
    {
        public frmAddNewEmployee()
        {
            InitializeComponent();
        }
        #region Self-Define Function
        public void Process()
        {
            this.ShowDialog();

        }
        private void Validation()
        {
            if(txtEmployeeCode.Text==""||txtEmployeeCode.Text==null)
            {
                ServicesTool.Instance.WarningMessage("Mã nhân viên không được rỗng!");
                return;
            }
            if(txtEmployeeName.Text == "" || txtEmployeeName.Text == null)
            {
                ServicesTool.Instance.WarningMessage("Tên nhân viên không được rỗng!");
                return;
            }
            if(txtPhone.Text==""||txtPhone.Text==null)
            {
                ServicesTool.Instance.WarningMessage("Số điện thoại nhân viên không được rỗng!");
                return;
            }
            if(txtAddress.Text==""||txtAddress.Text==null)
            {
                ServicesTool.Instance.WarningMessage("Địa chỉ nhân viên không được rỗng!");
                return;
            }
        }
        #endregion
        #region System Function
        private void btnSave_Click(object sender, EventArgs e)
        {
            Validation();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
