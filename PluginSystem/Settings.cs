using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace PluginSystem
{
    public class Settings
    {

        public static int iPortTimeout = 300;
        public static int iADCInterval = 20;
        public static int iChartSamples = 100;
      
        public static void LoadSettings()
        {
            if(!File.Exists(Globals.strSettingsFiles))
                SaveSettings();

            FileStream fs = new FileStream(Globals.strSettingsFiles, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            iPortTimeout = br.ReadInt32();
            iADCInterval = br.ReadInt32();
            iChartSamples = br.ReadInt32();
            br.Close();
            fs.Close();
        }

        public static void SaveSettings()
        {
            FileStream fs = new FileStream(Globals.strSettingsFiles, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
            bw.Write(iPortTimeout);
            bw.Write(iADCInterval);
            bw.Write(iChartSamples);
            bw.Close();
            fs.Close();

        }
    }
}
