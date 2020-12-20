using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN.DbContext.DAO;
using LN.Services;
using LN.DbContext;
using LN.DashBoard.View.Employee;

namespace LN.DashBoard
{
    public partial class ucEmployeesList : UserControl
    {

        #region Sefl-Define Function
        private static ucEmployeesList instance;
        public static ucEmployeesList Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucEmployeesList();
                return instance;
            }
        }
        private void EmployeeList()
        {
            gcEmployeeList.DataSource = EmployeeDAO.Instance.listEmployees();
        }
        #endregion
        public ucEmployeesList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using(var frm =new frmAddNewEmployee())
            {
                frm.Process();
            }
        }
    }
}
