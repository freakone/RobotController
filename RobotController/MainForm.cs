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
using System.Windows.Forms.DataVisualization.Charting;
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


            threadADC = new Thread(new ThreadStart(ADCScan));
            threadADC.Start();
        }


        #region forma glowna

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

        #endregion

        #region skanowanie

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
                        ds.BaudRate = bauds[b];
                        node.SetParameters(ds);
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
                comboBoxADCValuesChannel.Items.Clear();
                comboBoxADCValuesDevice.Items.Clear();
                comboBoxAnalog1Channel.Items.Clear();
                comboBoxAnalog2Channel.Items.Clear();
                comboBoxAnalog2Device.Items.Clear();
                comboBoxAnalog1Device.Items.Clear();
                comboBoxMotorDevice.Items.Clear();
                comboBoxMotorChannel.Items.Clear();
                comboBoxGPIOChannel.Items.Clear();
                comboBoxGPIODevice.Items.Clear();

                foreach (DeviceClass d in Globals.loaded_modules)
                {
                    TreeNode tn = new TreeNode(d.ToString());
                    treeViewDevices.Nodes.Add(tn);

                    if (d.settings.ADC_channels > 0)
                    {
                        comboBoxDeviceX.Items.Add(d.ToString());
                        comboBoxDeviceY.Items.Add(d.ToString());
                        comboBoxADCValuesDevice.Items.Add(d.ToString());
                        comboBoxAnalog2Device.Items.Add(d.ToString());
                        comboBoxAnalog1Device.Items.Add(d.ToString());

                    }

                    if (d.settings.MOTOR_channels > 0)
                    {
                        comboBoxMotorDevice.Items.Add(d.ToString());            

                    }

                    
                }


                comboBoxDeviceX.Items.Add("Czas");
                comboBoxDeviceY.Items.Add("Czas");
                comboBoxDeviceX.SelectedIndex = 0;
                comboBoxDeviceY.SelectedIndex = 0;

                if (comboBoxMotorDevice.Items.Count > 0)
                    comboBoxMotorDevice.SelectedIndex = 0;

                if (comboBoxADCValuesDevice.Items.Count > 0)
                {                
                    comboBoxADCValuesDevice.SelectedIndex = 0;
                    comboBoxAnalog2Device.SelectedIndex = 0;
                    comboBoxAnalog1Device.SelectedIndex = 0;
                }

            }
   
        }

        #endregion

        #region ADC

        public void SetAnalogVal(int i, AnalogMeter a)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {
                    a.Value = i;

                }));
            else
            {
                a.Value = i;
            }
        }

        public void AddToSeries(int ser, int x, int y)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {
                    chart1.Series[ser].Points.AddXY(x, y);

                }));
            else
            {
                chart1.Series[ser].Points.AddXY(x, y);
            }
        }

        delegate bool GetCheckBoxSelectedDelegate(CheckBox c);
        public bool GetCheckBoxSelected(CheckBox c)
        {
            if (this.InvokeRequired)
                return (bool)this.Invoke(new GetCheckBoxSelectedDelegate(GetCheckBoxSelected), new object[] { c });
            else
            {
                return c.Checked;
            }
        }

        delegate int ComboDelegate(ComboBox c);
        public int GetComboIndex(ComboBox c)
        {
            if (this.InvokeRequired)
               return (int)this.Invoke(new ComboDelegate(GetComboIndex), new object[] {c});               
            else
            {
                return c.SelectedIndex;
            }
        }

        Thread threadADC;
        int chartTime = 0;
        private void ADCScan()
        {
            while (true)
            {
                if (GetCheckBoxSelected(checkBoxAnalog1))
                {
                    int device = GetComboIndex(comboBoxAnalog1Device);
                    int channel = GetComboIndex(comboBoxAnalog1Channel);
                    int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

                    string resp = Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetADCCommand(), true);
                    int[] vals = Globals.loaded_modules[device].ParseADCCommand(resp);

                    SetAnalogVal(vals[channel], analogMeter1);
                }

                if (GetCheckBoxSelected(checkBoxAnalog2))
                {
                    int device = GetComboIndex(comboBoxAnalog2Device);
                    int channel = GetComboIndex(comboBoxAnalog2Channel);
                    int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

                    string resp = Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetADCCommand(), true);
                    int[] vals = Globals.loaded_modules[device].ParseADCCommand(resp);

                    SetAnalogVal(vals[channel], analogMeter2);

                }

                if(GetCheckBoxSelected(checkBoxChart))
                {
                    int device = GetComboIndex(comboBoxDeviceY);
                    int channel = GetComboIndex(comboBoxChannelY);
                    int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

                    string resp = Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetADCCommand(), true);
                    int[] vals = Globals.loaded_modules[device].ParseADCCommand(resp);

                    AddToSeries(channel, chartTime, vals[channel]);

                    chartTime += Settings.iADCInterval;
                }

                if(GetCheckBoxSelected(checkBoxADCTable))
                {
                    for(int i = 0; i < table_values.Count; i++)
                    {
                        int device = table_values[i][0];
                        int channel = table_values[i][1];
                        int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

                        string resp = Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetADCCommand(), true);
                        int[] vals = Globals.loaded_modules[device].ParseADCCommand(resp);




                    }

                }

                Thread.Sleep(Settings.iADCInterval);
            }

        }

        List<int[]> chart_series = new List<int[]>();
        private void btnChartAddSeries_Click(object sender, EventArgs e)
        {
            if (textBoxSeriesName.Text.Length == 0)
                return;

            chart_series.Add(new int[4] { comboBoxDeviceX.SelectedIndex == comboBoxDeviceX.Items.Count - 1 ? -1 : comboBoxDeviceX.SelectedIndex, comboBoxChannelX.SelectedIndex, comboBoxDeviceY.SelectedIndex == comboBoxDeviceY.Items.Count - 1 ? -1 : comboBoxDeviceY.SelectedIndex, comboBoxChannelY.SelectedIndex });
            chart1.Series.Clear();

            Series s = new Series(textBoxSeriesName.Text);
            s.ChartType = SeriesChartType.Spline;
            s.Points.Clear();
            chart1.Series.Add(s);
            
            RefreshSeriesList();
        }

        void RefreshSeriesList()
        {
            listBoxChartSeries.Items.Clear();

            foreach(Series s in chart1.Series)
            {              
                listBoxChartSeries.Items.Add(s.Name);                
            }

        }
 
        private void comboBoxDeviceX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeviceX.SelectedIndex < 0)
                return;

            if (comboBoxDeviceX.SelectedIndex == comboBoxDeviceX.Items.Count - 1)
            {
                comboBoxChannelX.Visible = false;
                return;
            }
            comboBoxChannelX.Visible = true;

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

            if(comboBoxDeviceY.SelectedIndex == comboBoxDeviceY.Items.Count - 1)
            {
                comboBoxChannelY.Visible = false;
                return;
            }
            comboBoxChannelY.Visible = true;
            comboBoxChannelY.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxDeviceY.SelectedIndex].settings;

            for (int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxChannelY.Items.Add(sett.ADC_Names[i]);
            }

            comboBoxChannelY.SelectedIndex = 0;
        }


        private void comboBoxAnalog1Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnalog1Device.SelectedIndex < 0)
                return;

            comboBoxAnalog1Channel.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxAnalog1Device.SelectedIndex].settings;

            for (int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxAnalog1Channel.Items.Add(sett.ADC_Names[i]);
            }

            comboBoxAnalog1Channel.SelectedIndex = 0;
        }

        private void comboBoxAnalog1Channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnalog1Channel.SelectedIndex < 0)
                return;

            analogMeter1.MaxValue = Globals.loaded_modules[comboBoxAnalog1Device.SelectedIndex].settings.ADC_max;
            analogMeter1.TickLargeFrequency = (int)(analogMeter1.MaxValue / 4);
            analogMeter1.TickSmallFrequency = (int)(analogMeter1.TickLargeFrequency / 2);
            analogMeter1.TickTinyFrequency =  (int)(analogMeter1.TickSmallFrequency / 5);
            analogMeter1.Text = comboBoxAnalog1Channel.Text;
        }

        private void comboBoxAnalog2Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnalog2Device.SelectedIndex < 0)
                return;

            comboBoxAnalog2Channel.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxAnalog2Device.SelectedIndex].settings;

            for (int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxAnalog2Channel.Items.Add(sett.ADC_Names[i]);
            }

            comboBoxAnalog2Channel.SelectedIndex = 0;
        }

        private void comboBoxAnalog2Channel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnalog2Channel.SelectedIndex < 0)
                return;

            analogMeter2.MaxValue = Globals.loaded_modules[comboBoxAnalog2Device.SelectedIndex].settings.ADC_max;
            analogMeter2.TickLargeFrequency = (int)(analogMeter2.MaxValue / 4);
            analogMeter2.TickSmallFrequency = (int)(analogMeter2.TickLargeFrequency / 2);
            analogMeter2.TickTinyFrequency = (int)(analogMeter2.TickSmallFrequency / 5);
            analogMeter2.Text = comboBoxAnalog2Channel.Text;
        }

        private void comboBoxADCValuesDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxADCValuesDevice.SelectedIndex < 0)
                return;

            comboBoxADCValuesChannel.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxADCValuesDevice.SelectedIndex].settings;

            for (int i = 0; i < sett.ADC_channels; i++)
            {
                comboBoxADCValuesChannel.Items.Add(sett.ADC_Names[i]);
            }

            comboBoxADCValuesChannel.SelectedIndex = 0;
        }

        private void comboBoxADCValuesChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<int[]> table_values = new List<int[]>();

        void RefreshCurrValuesList()
        {
            listViewCurrentValues.Items.Clear();

            foreach(int[] i in table_values)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(Globals.loaded_modules[i[0]].settings.ADC_Names[i[1]]);
                lvi.SubItems.Add("-");
                lvi.SubItems.Add("-");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxADCValuesDevice.SelectedIndex == -1 || comboBoxADCValuesChannel.SelectedIndex == -1)
                return;

            table_values.Add(new int[] { comboBoxADCValuesDevice.SelectedIndex, comboBoxADCValuesChannel.SelectedIndex });

            RefreshCurrValuesList();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listViewCurrentValues.SelectedItems.Count > 0)
            {
                table_values.RemoveAt(listViewCurrentValues.SelectedItems[0].Index);
            }
            RefreshCurrValuesList();
        }

        #endregion

        #region MOTOR

        private void comboBoxMotorDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMotorDevice.SelectedIndex < 0)
                return;

            comboBoxMotorChannel.Items.Clear();

            DeviceSettings sett = Globals.loaded_modules[comboBoxMotorDevice.SelectedIndex].settings;

            for (int i = 0; i < sett.MOTOR_channels; i++)
            {
                comboBoxMotorChannel.Items.Add(sett.MOTOR_Names[i]);
            }

            comboBoxMotorChannel.SelectedIndex = 0;
        }

        private void comboBoxMotorChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMotorChannel.SelectedIndex == -1)
                return;

            DeviceSettings sett = Globals.loaded_modules[comboBoxMotorDevice.SelectedIndex].settings;

            trackBarMotorSpeed.Value = 0;
            trackBarMotorSpeed.Maximum = (int)sett.MOTOR_max;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBoxMotorDevice.SelectedIndex < 0 || comboBoxMotorChannel.SelectedIndex < 0)
                return;

            int device = comboBoxMotorDevice.SelectedIndex;
            int channel = comboBoxMotorChannel.SelectedIndex;
            int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

            Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetMOTORIncCommand(), false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBoxMotorDevice.SelectedIndex < 0 || comboBoxMotorChannel.SelectedIndex < 0)
                return;

            int device = comboBoxMotorDevice.SelectedIndex;
            int channel = comboBoxMotorChannel.SelectedIndex;
            int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

            Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetMOTORDecCommand(), false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxMotorDevice.SelectedIndex < 0 || comboBoxMotorChannel.SelectedIndex < 0)
                return;

            int device = comboBoxMotorDevice.SelectedIndex;
            int channel = comboBoxMotorChannel.SelectedIndex;
            int com = Globals.ContainsPort(Globals.loaded_modules[device].strCOMName);

            Globals.serial_ports[com].SendData(Globals.loaded_modules[device].GetMOTORSetCommand(channel, trackBarMotorSpeed.Value), false);
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadADC != null && threadADC.IsAlive)
                threadADC.Abort();
        }

        

         

    }
}
