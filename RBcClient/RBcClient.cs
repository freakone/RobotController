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

        public override void GetADCData()
        {
            throw new NotImplementedException();
        }
        public override void SetMOTOR(int id, int value)
        {
            throw new NotImplementedException();
        }


        public override string[] GetScanCommand()
        {
            List<string> c = new List<string>();
            for(int i = 0x11; i < 0xFE; i++)
            {
                c.Add(String.Format("{0:X}{0:X}{0:X}\n", 0xFF, i, 0x70));
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


    }
}
