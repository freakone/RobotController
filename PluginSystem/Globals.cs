using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace PluginSystem
{

    public class ChartSeries
    {
        public int x_channel;
        public int y_channel;
        public int x_device;
        public int y_device;
        public List<float> x_samples = new List<float>();
        public List<float> y_samples = new List<float>();
        public string strName;
    }
    public static class Globals
    {
        public static string strConfigFiles = "";
        public static string strPluginFiles = "";
        public static string strSettingsFiles = "";
        public static readonly Color status_error = Color.Red;
        public static readonly Color status_info = Color.Black;
        public static readonly Color status_success = Color.Green;
        public static List<SerialNode> serial_ports = new List<SerialNode>();
        public static List<DeviceClass> loaded_modules = new List<DeviceClass>();
        public delegate void SetStatusEvent(object sender, SetStatusEventArgs e);
        public static SetStatusEvent statusEvent;
        public static List<DeviceClass> known_modules = new List<DeviceClass>();

        public static void LoadDlls()
        {

            foreach (string str in Directory.GetFiles(strPluginFiles, "*Client.dll"))
            {

                Assembly asm = Assembly.LoadFile(str);
                Type[] types = asm.GetTypes();

                for (int j = 0; j < types.Length; j++)
                {
                    if (typeof(DeviceClass).IsAssignableFrom(types[j]))
                    {
                        Globals.known_modules.Add((DeviceClass)Activator.CreateInstance(types[j]));                                
                    }
                }

            }
        }

        public static void StatusCall(string strText, Color c)
        {
            if (statusEvent != null)
            {
                statusEvent(null, new SetStatusEventArgs(strText, c));
            }
        }

        public static int ContainsPort(string str)
        {
            for(int i = 0; i < Globals.serial_ports.Count; i++)
            {
                if (Globals.serial_ports[i].ToString() == str)
                    return i;
            }

            return -1;

        }

        public static string dec2hascii(int liczba, int length)
        {
            return String.Format("{0:X" + length.ToString() +"}", liczba);
        }

        public static int hascii2dec(string str)
        {
            return  Convert.ToInt32(str, 16);
        }
    }

    public class SetStatusEventArgs : EventArgs
    {
        public string strText;
        public Color cColor;

        public SetStatusEventArgs(string strText, Color c)
        {
            this.strText = strText;
            this.cColor = c;           
        }
    }

}
