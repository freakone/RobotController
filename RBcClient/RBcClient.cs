using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginSystem;

namespace PluginSystem
{
    public class RBcClient : DeviceClass
    {
          

        public RBcClient()
        {
          
        }

        public override string GetADCCommand()
        {
            return String.Format("{0}{1}{2}", (char)0xff, (char)this.uID, (char)0x61);
        }

        public override int[] ParseADCCommand(string resp)
        {
            if (resp.Length < this.settings.ADC_channels*3 + 2)
                return null;

            int[] vals = new int[this.settings.ADC_channels];
            
            for (int i = 0; i < this.settings.ADC_channels; i++ )
            {
                vals[i] = Globals.hascii2dec(resp.Substring(3 + (i * 3), 3));
            }


            return vals;

        }
        public override void SetMOTOR(int id, int value)
        {
            throw new NotImplementedException();
        }


        public override string[] GetScanCommand()
        {
            List<string> c = new List<string>();
          //  for(int i = 0x11; i < 0xFE; i++)
            {
                int i = 0x11;
                c.Add(String.Format("{0}{1}{2}", (char)0xFF, (char)i, (char)0x70));
            }

            return c.ToArray();
        }

        public override uint[] ParseScanCommand(string[] resp)
        {
            List<uint> b = new List<uint>();

            for (int i = 0; i < resp.Length; i++ )
            {
                if (resp[i].Length > 0)
                    b.Add((uint)(0x11 + i));
            }

                return b.ToArray();
        }

        public override DeviceClass Create()
        {
            return new RBcClient(); 
        }


    }
}
