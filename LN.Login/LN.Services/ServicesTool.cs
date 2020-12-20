using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LN.Services
{
    public class ServicesTool
    {
        private static ServicesTool instance;
        public static ServicesTool Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServicesTool();
                return instance;
            }
        }
        public void WarningMessage(string nofitication)
        {
            MessageBox.Show(nofitication, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
