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
                    toolStripStatusLabel.Invalidate();

                }));
            else
            {
                toolStripStatusLabel.Text = e.strText;
                toolStripStatusLabel.ForeColor = e.cColor;
                toolStripStatusLabel.Invalidate();
            }
        }

        private void dodajRęcznieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(ManualCOMAdd m = new ManualCOMAdd())
            {
                m.ShowDialog();

                if (scanThread != null && scanThread.IsAlive)
                {
                    scanThread.Abort();
                    scanThread = null;
                }
                scanThread = new Thread(() => DeviceScan(m.COM.ToArray()));
                scanThread.Start();             
            }

            
        }

        private readonly int[] bauds = new int[] { 115200 };
        private Thread scanThread;
        void DeviceScan(string[] COM)
        {

            foreach (string s in COM)
            {
                Globals.StatusCall("Skanowanie portu " + s, Globals.status_info);
                SerialNode node;
                int det = Globals.ContainsPort(s);
                if(det > -1)
                    node = Globals.serial_ports[det];
                else
                {
                    node = new SerialNode(s);
                    Globals.serial_ports.Add(node);
                }

                foreach (DeviceClass dc in Globals.known_modules)
                {
                    string[] cmds = dc.GetScanCommand();

                    ProgressBarZero(cmds.Length * bauds.Length);

                    string[][] resps = new string[bauds.Length][];

                    DeviceSettings ds = dc.settings;


                    for (int b = 0; b < bauds.Length; b++)
                    {
                        node.SetParameters(ds);
                        ds.BaudRate = bauds[b];
                        resps[b] = new string[cmds.Length];
                        for (int c = 0; c < cmds.Length; c++)
                        {
                            resps[b][c] = node.SendData(cmds[c], true);
                            ProgressBarStep();
                        }
                    }


                    for (int b = 0; b < bauds.Length; b++)
                    {
                        uint[] ids = dc.ParseScanCommand(resps[b]);

                        foreach (uint u in ids)
                        {
                            DeviceClass dcnew = dc.Create();
                            dcnew.settings.BaudRate = bauds[b];
                            dcnew.uID = u;
                            dcnew.strCOMName = s;
                            dcnew.LoadSettings();
                            Globals.loaded_modules.Add(dcnew);
                        }
                    }
                }               
            }

            ReloadDeviceList();

            Globals.StatusCall("Skanowanie zakończone", Globals.status_info);
        }

        private void ProgressBarStep()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {

                    toolStripProgressBar1.PerformStep();
                }));
            else
            {
                toolStripProgressBar1.PerformStep();
            }

        }

        private void ProgressBarZero(int max)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {

                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Maximum = max;
                }));
            else
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = max;
            }
        }

        void ReloadDeviceList()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => this.ReloadDeviceList()));
            else
            {
                treeViewDevices.Nodes.Clear();
                comboBoxChannelX.Items.Clear();
                comboBoxChannelY.Items.Clear();
                comboBoxDeviceX.Items.Clear();
                comboBoxDeviceY.Items.Clear();

                foreach (DeviceClass d in Globals.loaded_modules)
                {
                    TreeNode tn = new TreeNode(d.ToString());
                    treeViewDevices.Nodes.Add(tn);

                    if (d.settings.ADC_channels > 0)
                    {
                        comboBoxDeviceX.Items.Add(d.ToString());
                        comboBoxDeviceY.Items.Add(d.ToString());

                    }

                }

                if (comboBoxDeviceX.Items.Count > 0)
                {
                    comboBoxDeviceX.SelectedIndex = 0;
                    comboBoxDeviceY.SelectedIndex = 0;
                }
            }
   
        }

        private void comboBoxDeviceX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeviceX.SelectedIndex < 0)
                return;

            comboBoxChannelX.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxDeviceX.SelectedIndex].settings;
            
            for(int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxChannelX.Items.Add(sett.ADC_Names[i]);                
            }

            comboBoxChannelX.SelectedIndex = 0;

        }

        private void comboBoxDeviceY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeviceY.SelectedIndex < 0)
                return;

            comboBoxChannelY.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxDeviceY.SelectedIndex].settings;

            for (int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxChannelY.Items.Add(sett.ADC_Names[i]);
            }

            comboBoxChannelY.SelectedIndex = 0;
        }

        private void treeViewDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
