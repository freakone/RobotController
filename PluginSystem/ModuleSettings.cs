using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PluginSystem
{
    public partial class ModuleSettings : Form
    {
        public ModuleSettings()
        {
            InitializeComponent();
        }

        public void SetValues(DeviceSettings ds)
        {
            this.propertyGrid1.SelectedObject =  ds;
            this.propertyGrid1.Refresh();
        }
    }
}
