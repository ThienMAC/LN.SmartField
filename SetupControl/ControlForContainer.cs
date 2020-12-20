using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SetupControl
{
    public class ControlForContainer
    {
        private static ControlForContainer instance;
        public static ControlForContainer Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControlForContainer();
                return instance;
            }
        }

        //Add control to container
        public void AddControl_ToContainer(DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container, UserControl uc)
        {
            if (!container.Controls.Contains(uc))
            {
                container.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            uc.BringToFront();
        }

    }
}
