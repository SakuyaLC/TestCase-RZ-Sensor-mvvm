using System;
using System.Collections.Generic;
using System.Text;
using TestCase_RZ_Sensor.Model;

namespace TestCase_RZ_Sensor.ViewModel
{
    public class SensorViewModel
    {

        public SensorViewModel()
        {
            List<SensorModel> sensorsList = new List<SensorModel>() {
                new SensorModel() { State = 0, FireAlarm = false, RelayIsOn = true, Test = true, SerialNumber = 222345 } };
            Sensors = new List<SensorModel>(sensorsList);
        }

        private List<SensorModel> _Sensors;
        public List<SensorModel> Sensors
        {
            get { return _Sensors; }
            set { _Sensors = value; }
        }
    }
}
