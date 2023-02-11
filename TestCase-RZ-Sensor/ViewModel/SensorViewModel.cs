
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestCase_RZ_Sensor.Model;

namespace TestCase_RZ_Sensor.ViewModel
{
    public class SensorViewModel
    {
        public ObservableCollection<SensorModel> Sensors { get; private set; }

        public int command;

        public DelegateCommand CmEnter1 { get; private set; }
        public DelegateCommand CmEnter2 { get; private set; }
        public DelegateCommand CmEnter3 { get; private set; }
        public DelegateCommand CmEnter4 { get; private set; }
        public DelegateCommand CmEnter5 { get; private set; }
        public DelegateCommand CmEnter6 { get; private set; }
        public DelegateCommand CmSend { get; private set; }
        public DelegateCommand CmClear { get; private set; }

        public SensorViewModel()
        {
            Sensors = new ObservableCollection<SensorModel>()
            {
                new SensorModel() {State = 0, FireAlarm = true, RelayIsOn = true, RelayIsOff = false, Test = true, SerialNumber = 222345, Commands = ""},
            };

            CmEnter1 = new DelegateCommand(CommandEnter1, CanEnterCommand);
            CmEnter2 = new DelegateCommand(CommandEnter2, CanEnterCommand);
            CmEnter3 = new DelegateCommand(CommandEnter3, CanEnterCommand);
            CmEnter4 = new DelegateCommand(CommandEnter4, CanEnterCommand);
            CmEnter5 = new DelegateCommand(CommandEnter5, CanEnterCommand);
            CmEnter6 = new DelegateCommand(CommandEnter6, CanEnterCommand);
            CmSend = new DelegateCommand(CommandSend, CanEnterCommand);
            CmClear = new DelegateCommand(CommandClear, CanEnterCommand);
        }

        public void CommandEnter1(object message)
        {
            Sensors[0].Commands = "1";
        }

        public void CommandEnter2(object message)
        {
            Sensors[0].Commands = "2";
        }

        public void CommandEnter3(object message)
        {
            Sensors[0].Commands = "3";
        }

        public void CommandEnter4(object message)
        {
            Sensors[0].Commands = "4";
        }

        public void CommandEnter5(object message)
        {
            Sensors[0].Commands = "5";
        }

        public void CommandEnter6(object message)
        {
            Sensors[0].Commands = "6";
        }

        async public void CommandSend(object message)
        {
            await Task.Run(
                () =>
                {
                    command = Int32.Parse(Sensors[0].Commands);

                    switch (command)
                    {
                        case 1:
                            Sensors[0].State = 0;
                            break;
                        case 2:
                            Sensors[0].State = 2;
                            break;
                        case 3:
                            Sensors[0].Test = !Sensors[0].Test;
                            break;
                        case 4:
                            Sensors[0].State = 1;
                            break;
                        case 5:
                            Sensors[0].RelayIsOn = true;
                            Sensors[0].RelayIsOff = false;
                            break;
                        case 6:
                            Sensors[0].RelayIsOn = false;
                            Sensors[0].RelayIsOff = true;
                            break;
                    }

                    Sensors[0].Commands = "";
                }
            );

        }

        public void CommandClear(object message)
        {
            Sensors[0].Commands = "";
        }

        public bool CanEnterCommand(object message)
        {
            return true;
        }
    }
}
