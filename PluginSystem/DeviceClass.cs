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
        private uint _uID = 0x10;
        public uint uID
        {
            get { return _uID; }
            set
            {
                _uID = value;
                LoadSettings();
            }
        }
        public string strCOMName = "";
        public char packetEnd = '\n';
        public DeviceSettings settings = new DeviceSettings();
        private string config
        {
            get { return Globals.strConfigFiles + _uID + type + ".xml"; }
        }

        protected DeviceClass()
        {
            for (int i = 0; i < settings.ADC_channels; i++)
                settings.ADC_Names.Add("Kanał " + i.ToString());

            for (int i = 0; i < settings.MOTOR_channels; i++)
                settings.ADC_Names.Add("Silnik " + i.ToString());

        }

        public abstract string GetADCCommand();
        public abstract int[] ParseADCCommand(string resp);
        public abstract void SetMOTOR(int id, int value);
        public abstract string[] GetScanCommand();
        public abstract uint[] ParseScanCommand(string[] resp);

        public abstract DeviceClass Create();
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

            XmlSerializer reader = new XmlSerializer(this.settings.GetType(), _uID.ToString());
            StreamReader file = new StreamReader(config);            
            this.settings = (DeviceSettings)reader.Deserialize(file);
                      
        }

        public void SaveSettings()
        {

            XmlSerializer writer = new XmlSerializer(this.settings.GetType(), _uID.ToString());
            StreamWriter file = new StreamWriter(config);
            writer.Serialize(file, settings);
            file.Close();
        }


        public override string ToString()
        {

            return this.settings.Name + " (" + this.uID + ")";
        }
       

    }

}
