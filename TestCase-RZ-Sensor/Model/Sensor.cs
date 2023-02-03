using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    class Sensor
    {
        private byte state = 0;
        private bool fireAlarm;
        private bool relayIsOn;
        private bool relayIsOff;
        private bool test;
        private ulong serialNumber;

        public Sensor(byte state, bool fireAlarm, bool relayIsOn, bool relayIsOff, bool test, ulong serialNumber)
        {
            this.state = state;
            this.fireAlarm = fireAlarm;
            this.relayIsOn = relayIsOn;
            this.relayIsOff = relayIsOff;
            this.test = test;
            this.serialNumber = serialNumber;
        }

        //Отключает прибор
        private void DisableSensor()
        {
            state = 0;
            fireAlarm = false;
            relayIsOn = false;
            relayIsOff = true;
            test = false;
        }

        //Изменить состояние прибора на "Автоматика"
        private void ChangeStateToAuto()
        {
            state = 2;
        }

        //Снимает тест???
        private void DisableTest()
        {
            test = false;
        }

        //Сбросить состояние
        private void ResetState()
        {
            state = 0;
        }

        //Включить реле
        private void EnableRelay()
        {
            relayIsOn = true;
            relayIsOff = false;
        }

        //Отключить реле
        private void DisableRelay()
        {
            relayIsOn = false;
            relayIsOff = true;
        }

    }
}
