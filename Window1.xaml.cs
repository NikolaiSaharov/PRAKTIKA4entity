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
using System.Windows.Shapes;

namespace PRAKTIKA4entity
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private AVIACASSA2Entities context = new AVIACASSA2Entities();
        public Window1()
        {
            InitializeComponent();
            TicketGrid.ItemsSource = context.Tickets.ToList();
            FiltrClass.ItemsSource = context.Tickets.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();

            // Закройте текущее окно
            this.Close();
        }

        private void SearchClick_Click(object sender, RoutedEventArgs e)
        {
            TicketGrid.ItemsSource = context.Tickets.ToList().Where(item => item.Class.Contains(SearchClass.Text));
        }

        private void ClearClick_Click(object sender, RoutedEventArgs e)
        {
            TicketGrid.ItemsSource = context.Tickets.ToList();
        }

        private void FiltrName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiltrClass.SelectedItem != null)
            {
                var selected = FiltrClass.SelectedItem as Tickets;
                TicketGrid.ItemsSource = context.Tickets.ToList().Where(item => item.Class == selected.Class).ToList();
            }
        }
    }
}
