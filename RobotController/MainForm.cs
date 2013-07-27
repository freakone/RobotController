using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Instruments;
using System.IO;
using PluginSystem;

namespace RobotController
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Globals.statusEvent += new Globals.SetStatusEvent(SetStatus);
            Globals.strConfigFiles = Application.StartupPath + Path.DirectorySeparatorChar + "config_files" + Path.DirectorySeparatorChar;

            if (!Directory.Exists(Globals.strConfigFiles))
                Directory.CreateDirectory(Globals.strConfigFiles);

            Globals.loaded_modules.Add(new RBcClient());
        }

 
        private void skanujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void SetStatus(object sender, SetStatusEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {
                    toolStripStatusLabel.Text = e.strText;
                    toolStripStatusLabel.ForeColor = e.cColor;

                }));
            else
            {
                toolStripStatusLabel.Text = e.strText;
                toolStripStatusLabel.ForeColor = e.cColor;
            }
        }

        private void dodajRęcznieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(ManualCOMAdd m = new ManualCOMAdd())
            {
                m.ShowDialog();
                RBcClient c = new RBcClient();
               string[] s = Globals.serial_ports[0].SendData(c.GetScanCommand(), true);
               uint[] b = c.ParseScanCommand(s); ;

               foreach (uint u in b)
               {
                   RBcClient rbc = new RBcClient();
                   rbc.uID = u;
               }
            }

            ReloadDeviceList();
        }

        private void ReloadDeviceList()
        {
            treeViewDevices.Nodes.Clear();

            foreach(DeviceClass d in Globals.loaded_modules)
            {
                TreeNode tn = new TreeNode(d.settings.Name + "(ID: " + d.uID + ")");
                treeViewDevices.Nodes.Add(tn);

            }
        }
    }
}
