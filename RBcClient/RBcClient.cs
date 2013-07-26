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
          

        public RBcClient(uint uID)
        {
            this.uID = uID;
            LoadSettings();
        }

        public override void GetADCData()
        {
            throw new NotImplementedException();
        }
        public override void SetMOTOR(int id, int value)
        {
            throw new NotImplementedException();
        }

        public override void ParseCommand()
        {
            throw new NotImplementedException();
        }

        public override string GetScanCommand()
        {
            throw new NotImplementedException();
        }


    }
}
