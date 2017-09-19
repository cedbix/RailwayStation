using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace RailwayStation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Park_ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Park 1");
            data.Add("Park 2");
            data.Add("Park 3");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void Park_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            this.Title = "Railway Station: " + value;
            GraphControl gc = (GraphControl)this.FindName("GraphControl");
            gc.ChangePark(value);
        }

        private void Color_ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Green");
            data.Add("Blue");
            data.Add("Orange");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void Color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            GraphControl gc = (GraphControl)this.FindName("GraphControl");
            gc.ChangeColor(value);
        }
    }
}
