using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace PluginSystem
{
    public class SerialNode
    {
        private SerialPort port;
        private Mutex m;
        public SerialNode(string com)
        {
            port = new SerialPort();
            port.PortName = com;          
            port.DataReceived += port_DataReceived;

            try
            {
                port.Open();
                Globals.StatusCall(com + " otwarty!", Globals.status_success);
            }
            catch(Exception ex)
            {
                Globals.StatusCall(ex.ToString(), Globals.status_error);
            }

        }

        public void SetParameters(DeviceSettings s)
        {
            port.BaudRate = s.BaudRate;
            port.DataBits = s.DataBits;
            port.Parity = s.DataParity;
            port.StopBits = s.DataStopBits;
        }

 
        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public string SendData(string data, bool response)
        {

            return null;
        }

        public string[] SendData(string[] data, bool response)
        {

            return null;
        }


        public void GetBuffer()
        {


        }

        public void PullBuffer()
        {


        }


    }
}
