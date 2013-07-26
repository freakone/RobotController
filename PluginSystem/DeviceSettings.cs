using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;

namespace PluginSystem
{

    public class DeviceSettings
    {
        private string _name = "RBc";
        [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Nazwa modułu")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private uint _MOTOR_channels = 4;
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Ilość kanałów obsługujących silniki")]
        public uint MOTOR_channels
        {
            get { return _MOTOR_channels; }
            set { _MOTOR_channels = value; }     
         }



        private List<string> _MOTOR_Names = new List<string>(new string[] { "Motor 1", "Motor 2", "Motor 3", "Motor 4" });
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Nazwy kanałów do obsługi silników")]

        public List<string> MOTOR_Names
        {
            get { return _MOTOR_Names; }
            set { _MOTOR_Names = value; }
        }


        private uint _ADC_channels = 4;
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Ilość kanałów obsługujących pomiar wartości analogowych")]
        public uint ADC_channels
        {
            get { return _ADC_channels; }
            set { _ADC_channels = value; }
        }

         private List<string> _ADC_Names = new List<string>(new string[] { "Kanał 1", "Kanał 2", "Kanał 3", "Kanał 4" });
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Nazwy kanałów ADC")]

        public List<string> ADC_Names
        {
            get { return _ADC_Names; }
            set { _ADC_Names = value; }
        }

        private uint _ADC_max = 4096;
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Maksymalna wartość odczytana z przetwornika ADC")]
        public uint ADC_max
        {
            get { return _ADC_max; }
            set { _ADC_max = value; }
        }
        private uint _MOTOR_max = 4096;
         [CategoryAttribute("Ustawienia peryferiów"), DescriptionAttribute("Maksymalna wartość nastawy silnika")]
        public uint MOTOR_max
        {
            get { return _MOTOR_max; }
            set { _MOTOR_max = value; }
        }


        private int baud = 9600;
        [CategoryAttribute("Ustawienia portu"), DescriptionAttribute("Prędkość")]
        public int BaudRate
        {
            get { return baud; }
            set { baud = value; }
        }
        private int data = 8;
         [CategoryAttribute("Ustawienia portu"), DescriptionAttribute("Długość ramki danych")]
        public int DataBits
        {
            get { return data; }
            set { data = value; }
        }
        public Parity par = Parity.None;
        [CategoryAttribute("Ustawienia portu"), DescriptionAttribute("Parzystość")]
        public Parity DataParity
        {
            get { return par; }
            set { par = value; }
        }
        private StopBits stop = StopBits.One;
        [CategoryAttribute("Ustawienia portu"), DescriptionAttribute("Ilość bitów stopu")]
        public StopBits DataStopBits
        {
            get { return stop; }
            set { stop = value; }
        }
    }
}
