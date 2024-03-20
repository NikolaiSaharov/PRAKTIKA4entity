using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRAKTIKA4entity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AVIACASSA2Entities context = new AVIACASSA2Entities();
        public MainWindow()
        {
            InitializeComponent();
            PassengerGrid.ItemsSource = context.Passengers.ToList();
            FiltrName.ItemsSource = context.Passengers.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();

            // Закройте текущее окно
            this.Close();
        }

        private void SearchClick_Click(object sender, RoutedEventArgs e)
        {
            PassengerGrid.ItemsSource = context.Passengers.ToList().Where(item => item.FirstName.Contains(SearchName.Text));
        }

        private void ClearClick_Click(object sender, RoutedEventArgs e)
        {
            PassengerGrid.ItemsSource = context.Passengers.ToList();
        }

        private void FiltrName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiltrName.SelectedItem != null)
            {
                var selected = FiltrName.SelectedItem as Passengers;
                PassengerGrid.ItemsSource = context.Passengers.ToList().Where(item => item.FirstName == selected.FirstName).ToList();
            }
        }
    }
}
