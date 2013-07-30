using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PluginSystem
{
    public class SerialNode
    {
        private SerialPort port;
        private Mutex m;
        public bool bError = false;
        public SerialNode(string com)
        {
            port = new SerialPort();
            port.PortName = com;
            port.ReadTimeout = Settings.iPortTimeout;
           // port.DataReceived += port_DataReceived;

            OpenPort();
        }

        private void OpenPort()
        {
            try
            {
                port.Open();
                bError = false;
                Globals.StatusCall(port.PortName + " otwarty!", Globals.status_success);
            }
            catch (Exception ex)
            {
                bError = true;
                Globals.StatusCall(ex.Message, Globals.status_error);
            }
        }

        public void SetParameters(DeviceSettings s)
        {
            port.BaudRate = s.BaudRate;
            port.DataBits = s.DataBits;
            port.Parity = s.DataParity;
            port.StopBits = s.DataStopBits;
            port.NewLine = s.strEndLine;

            port.Close();
            port.Open();
        }

 
        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public string SendData(string data, bool response)
        {
            if (!port.IsOpen)
                OpenPort();

            if (bError)
                return "";

            try
            {
                port.DiscardInBuffer();
                port.DiscardOutBuffer();         
            
                foreach(char c in data)
                    port.Write(new byte[]{(byte)c}, 0, 1);

                port.WriteLine("");
                port.BaseStream.Flush();

                if(response)
                {
                    return port.ReadLine();
                }

            }
            catch (Exception ex)
            {
                if (ex is TimeoutException)
                    return "";

                bError = true;
                Globals.StatusCall(ex.ToString(), Globals.status_error);
                port.Close();
            }

            return "";
        }

        public string[] SendData(string[] data, bool response)
        {

            List<string> str = new List<string>();

            foreach(string s in data)
            {
                port.WriteLine(s);
                if (response)
                    str.Add(port.ReadLine());
            }

            return str.ToArray();
        }

        public override string ToString()
        {
            return port.PortName;
        }

    }
}
