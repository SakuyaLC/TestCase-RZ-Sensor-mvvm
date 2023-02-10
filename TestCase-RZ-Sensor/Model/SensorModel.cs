using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    public class SensorModel : INotifyPropertyChanged
    {
        public byte State { get; set; }
        public bool FireAlarm { get; set; }
        public bool RelayIsOn { get; set; }
        public bool Test { get; set; }
        public ulong SerialNumber { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
