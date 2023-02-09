using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestCase_RZ_Sensor.Model;

namespace TestCase_RZ_Sensor.ViewModel
{
    public class SensorViewModel
    {

        SensorModel Sensor = new SensorModel() { State = 0, FireAlarm = false, RelayIsOn = false, Test = false, SerialNumber = 222345 };
    }
}
