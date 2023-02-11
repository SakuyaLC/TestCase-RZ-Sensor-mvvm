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
            return 123456789;
        }

        //Получить описание прибора
        private string GetSensorInfo() 
        {
            return "Sensor Info"; 
        }


    }
}
