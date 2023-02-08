using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    class Sensor : ISensor
    {
        public byte state = 0;
        public bool fireAlarm;
        public bool relayIsOn;
        public bool test;
        public ulong serialNumber;

        public Sensor(byte state, bool fireAlarm, bool relayIsOn, bool relayIsOff, bool test, ulong serialNumber)
        {
            this.state = state;
            this.fireAlarm = fireAlarm;
            this.relayIsOn = relayIsOn;
            this.test = test;
            this.serialNumber = serialNumber;
        }

        //Получить описание прибора
        private string GetSensorInfo()
        {
            return
                $"[{serialNumber}] " +
                $"{state} " +
                $"({fireAlarm}," +
                $"{relayIsOn})";
        }

        //Парсинг ответа от прибора по его параметрам с формированием свойств по данным из пакета. Формат пакета (byte[])
        private void ParseResponse()
        {

        }

        //Формирование пакета команды в прибор
        private void CreateCommandPacket(byte command)
        {

        }

        //Отключает прибор
        private void DisableSensor()
        {
            state = 0;
            fireAlarm = false;
            relayIsOn = false;
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
        }

        //Отключить реле
        private void DisableRelay()
        {
            relayIsOn = false;
        }

    }
}
