using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.IO.Ports;
using System.Xml.Serialization;

namespace PluginSystem
{
    public abstract class DeviceClass
    {
        public string type = "RBc";
        public uint uID = 10;
        public int iCOMindex = -1;
        public DeviceSettings settings = new DeviceSettings();
        private string config
        {
            get { return Globals.strConfigFiles + uID + type + ".xml"; }
        }

        protected DeviceClass()
        {            
          
        }

        public abstract void GetADCData();
        public abstract void SetMOTOR(int id, int value);
        public abstract string GetScanCommand();
        public abstract void ParseCommand();


        public void LoadSettings()
        {
            if (!File.Exists(config))
            {
                using (ModuleSettings m = new ModuleSettings())
                {
                    m.SetValues(this.settings);
                    m.ShowDialog();                   
                    SaveSettings();
                }                
            }

            XmlSerializer reader = new XmlSerializer(this.settings.GetType());
            StreamReader file = new StreamReader(config);            
            settings = (DeviceSettings)reader.Deserialize(file);


        }

        public void SaveSettings()
        {

            XmlSerializer writer = new XmlSerializer(this.settings.GetType());
            StreamWriter file = new StreamWriter(config);
            writer.Serialize(file, settings);
            file.Close();
        }
       

    }

}
