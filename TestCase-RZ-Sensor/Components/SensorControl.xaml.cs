using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestCase_RZ_Sensor.ViewModel;

namespace TestCase_RZ_Sensor.Components
{
    /// <summary>
    /// Логика взаимодействия для SensorControl.xaml
    /// </summary>
    public partial class SensorControl : UserControl
    {
        public SensorControl()
        {
            InitializeComponent();
            Loaded += SensorControl_Loaded;
        }

        private void SensorControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new SensorViewModel();
        }
    }

}
