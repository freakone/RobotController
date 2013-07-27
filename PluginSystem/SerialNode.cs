using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace PluginSystem
{
    public class SerialNode
    {
        private SerialPort port;  

        public SerialNode(string com, int baud, int databits, Parity par, StopBits stop)
        {
            port = new SerialPort();
            port.BaudRate = baud;
            port.PortName = com;
            port.DataBits = databits;
            port.Parity = par;
            port.StopBits = stop;
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
