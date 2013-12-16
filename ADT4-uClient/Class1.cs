using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using PluginSystem;

namespace ADT4_uClient
{
    public class ADT4_uClient : DeviceClass
    {
        public  ADT4_uClient()
        {
            base.type = "ADT4";
            base.settings.BaudRate = 57600;
        }

        public override DeviceClass Create()
        {
            return new ADT4_uClient();
        }

        public override string GetADCCommand()
        {
            string str = String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", (char)0x24, (char)0x79, (char)0x34, (char)0x00, (char)0x00, (char)0x00, (char)0x00, (char)0x34);
            str += String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", (char)0x24, (char)0x79, (char)0x35, (char)0x00, (char)0x00, (char)0x00, (char)0x00, (char)0x35);
            str += String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", (char)0x24, (char)0x79, (char)0x36, (char)0x00, (char)0x00, (char)0x00, (char)0x00, (char)0x36);
            str += String.Format("{0}{1}{2}{3}{4}{5}{6}{7}", (char)0x24, (char)0x79, (char)0x37, (char)0x00, (char)0x00, (char)0x00, (char)0x00, (char)0x37);

            return str;
        }

    }
}
