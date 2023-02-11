using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestCase_RZ_Sensor.Model
{
    public class SensorModel : INotifyPropertyChanged, ISensor
    {
        private byte _state { get; set; }
        private bool _fireAlarm { get; set; }
        private bool _RelayIsOn { get; set; }
        private bool _test { get; set; }
        private ulong _serialNumber { get; set; }
        private string _commands { get; set; }

        //Парсинг ответа от прибора по его параметрам с формированием свойств по данным из пакета. Формат пакета (byte[])
        private void ParseResponse()
        {

        }

        //Формирование пакета команды в прибор – на выходе массив байт 
        public byte[] FormCommandPacket(int command)
        {
            byte[] t1 = BitConverter.GetBytes(this.SerialNumber);
            byte[] t2 = BitConverter.GetBytes(command);

            byte[] commandPacket = commandPacket = t1.Concat(t2).ToArray();

            return commandPacket;
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
