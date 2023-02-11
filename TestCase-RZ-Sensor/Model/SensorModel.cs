using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_RZ_Sensor.Model
{
    public class SensorModel : INotifyPropertyChanged, ISensor
    {
        private byte _state { get; set; }
        private bool _fireAlarm { get; set; }
        private bool _RelayIsOn { get; set; }
        private bool _RelayIsOff { get; set; }
        private bool _test { get; set; }
        private ulong _serialNumber { get; set; }
        private string _commands { get; set; }

        //Парсинг ответа от прибора по его параметрам с формированием свойств по данным из пакета. Формат пакета (byte[])
        public void ParseResponse(byte[] commandPacket)
        {

        }

        //Формирование пакета команды в прибор – на выходе массив байт 
        public async Task<bool> FormCommandPacket(int command)
        {
            bool formed = false;

            await Task.Run(
            () =>
            {
                byte[] t1 = BitConverter.GetBytes(this.SerialNumber);
                byte[] t2 = BitConverter.GetBytes(command);

                if (!t1.Equals(null) && !t2.Equals(null))
                {
                    byte[] commandPacket = t1.Concat(t2).ToArray();
                    ParseResponse(commandPacket);
                    formed = true;
                }

            });

            return formed;

        }

        //Получить серийный номер прибора
        public async Task<ulong> GetSerialNumber()
        {
            await Task.Run(
            () =>
            {
                //Запрос серийного номера у прибора
            });

            return SerialNumber;
        }

        //Получить описание прибора – возвращает строку формата: [<серийный номер>] <состояние> (<перечень текстовых состояний в true>). 
        public async Task<string> GetSensorInfo()
        {
            string sensorInfo = "";

            await Task.Run(
            () =>
            {
                string state = "Отключен";
                if (State == 0) state = "Отключен";
                if (State == 1) state = "Ручное";
                if (State == 2) state = "Автоматика";

                sensorInfo = $"[{SerialNumber.ToString()}] {state} (";
                if (FireAlarm) sensorInfo += "Пожар, ";
                if (RelayIsOn) sensorInfo += "Реле включено, ";
                if (RelayIsOff) sensorInfo += " Реле выключено, ";
                if (Test) sensorInfo += " Тест включен, ";

                sensorInfo = sensorInfo.Remove(sensorInfo.Length - 2);

                sensorInfo += ")";

            });

            return sensorInfo;
        }

        public byte State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        public bool FireAlarm
        {
            get { return _fireAlarm; }
            set
            {
                _fireAlarm = value;
                OnPropertyChanged("FireAlarm");
            }
        }

        public bool RelayIsOn
        {
            get { return _RelayIsOn; }
            set
            {
                _RelayIsOn = value;
                OnPropertyChanged("RelayIsOn");
            }
        }

        public bool RelayIsOff
        {
            get { return _RelayIsOff; }
            set
            {
                _RelayIsOff = value;
                OnPropertyChanged("RelayIsOff");
            }
        }

        public bool Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("Test");
            }
        }

        public ulong SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                _serialNumber = value;
                OnPropertyChanged("SerialNumber");
            }
        }

        public string Commands
        {
            get { return _commands; }
            set
            {
                _commands = value;
                OnPropertyChanged("Commands");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
