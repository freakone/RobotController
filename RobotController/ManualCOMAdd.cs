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
        public List<string> COM = new List<string>();
        public ManualCOMAdd()
        {
            InitializeComponent();
            RefreshCOM();
        }

        private void RefreshCOM()
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(SerialPort.GetPortNames());
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCOM();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                this.COM.Add(checkedListBox1.CheckedItems[i].ToString());
                this.Close();
        }
    }
}
