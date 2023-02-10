using System;
using System.Collections.Generic;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    public interface ISensor
    { 
        //Получить серийный номер прибора
        private ulong GetSerialNumber()
        {
            return 123;
        }

        //Получить описание прибора
        private string GetSensorInfo() { return "Sensor Info"; }

        //Отключает прибор
        private void DisableSensor() { }

        //Изменить состояние прибора на "Автоматика"
        private void ChangeStateToAuto() { }

        //Снимает тест???
        private void DisableTest() { }

        //Сбросить состояние
        private void ResetState() { }

        //Включить реле
        private void EnableRelay() { }

        //Отключить реле
        private void DisableRelay() { }

    }
}
