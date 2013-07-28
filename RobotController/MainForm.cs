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
using System.Reflection;
using System.Threading;

namespace RobotController
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Globals.statusEvent += new Globals.SetStatusEvent(SetStatus);
            Globals.strConfigFiles = Application.StartupPath + Path.DirectorySeparatorChar + "config_files" + Path.DirectorySeparatorChar;
            Globals.strPluginFiles = Application.StartupPath + Path.DirectorySeparatorChar + "plugin_files" + Path.DirectorySeparatorChar;

            if (!Directory.Exists(Globals.strConfigFiles))
                Directory.CreateDirectory(Globals.strConfigFiles);            

            Globals.LoadDlls();
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

                if (scanThread != null && scanThread.IsAlive)
                    scanThread.Abort();

                scanThread = new Thread(() => DeviceScan(m.COM.ToArray()));
                scanThread.Start();             
            }

            
        }

        private Thread scanThread;
        void DeviceScan(string[] COM)
        {

            foreach(string s in COM)
            {
                SerialNode node = new SerialNode(s);

                foreach(DeviceClass dc in Globals.known_modules)
                {
                    string[] resp = node.SendData(dc.GetScanCommand(), true);
                    uint[] ids = dc.ParseScanCommand(resp);

                    foreach(uint u in ids)
                    {
                        DeviceClass dcnew = (DeviceClass)Activator.CreateInstance(dc.GetType());
                        dcnew.uID = u;
                        dcnew.strCOMName = s;                            
                        Globals.loaded_modules.Add(dcnew);
                    }
                }

                Globals.serial_ports.Add(node);
            }

            ReloadDeviceList();
        }

        private void ReloadDeviceList()
        {
            if (this.InvokeRequired)
            this.Invoke(new MethodInvoker(delegate(){

                 treeViewDevices.Nodes.Clear();

                foreach (DeviceClass d in Globals.loaded_modules)
                {
                    TreeNode tn = new TreeNode(d.settings.Name + " (ID: " + d.uID + ")");
                    treeViewDevices.Nodes.Add(tn);

                }
            }));
            else
            {
                treeViewDevices.Nodes.Clear();

                foreach (DeviceClass d in Globals.loaded_modules)
                {
                    TreeNode tn = new TreeNode(d.settings.Name + " (ID: " + d.uID + ")");
                    treeViewDevices.Nodes.Add(tn);

                }
            }
        }
    }
}
