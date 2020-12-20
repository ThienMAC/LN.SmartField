using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SetupControl;

namespace LN.DashBoard
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void Process()
        {
            MainForm frm = new MainForm();
            frm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn tắt chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            return;
        }

        private void accorEmployeeList_Click(object sender, EventArgs e)
        {
            ControlForContainer.Instance.AddControl_ToContainer(container, ucEmployeesList.Instance);
        }
    }
}
