using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RobotController
{
    public partial class ManualCOMAdd : Form
    {
        public string COM = "";
        public ManualCOMAdd()
        {
            InitializeComponent();
            RefreshCOM();
        }

        private void RefreshCOM()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCOM();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            COM = comboBox1.Text;
            this.Close();
        }
    }
}
