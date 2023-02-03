using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    class Sensor
    {
        private byte state;
        private bool fireAlarm;
        private bool relayIsOn;
        private bool relayIsOff;
        private bool test;
        private ulong serialNumber;

        private Sensor(byte state, bool fireAlarm, bool relayIsOn, bool relayIsOff, bool test, ulong serialNumber)
        {
            this.state = state;
            this.fireAlarm = fireAlarm;
            this.relayIsOn = relayIsOn;
            this.relayIsOff = relayIsOff;
            this.test = test;
            this.serialNumber = serialNumber;
        }

    }
}
