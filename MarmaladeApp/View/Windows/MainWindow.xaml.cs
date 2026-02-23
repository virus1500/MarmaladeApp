using MarmaladeApp.Model;
using MarmaladeApp.View.Pages;
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

namespace MarmaladeApp.View.Windows
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

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new TestPage());
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {

            MainFrm.Navigate(new TicketPage());
        }

        private void ClientsBtn_Click(object sender, RoutedEventArgs e)
        {

            MainFrm.Navigate(new ClientPage());
        }

        private void SupplierBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new SupplierPage());
        }

        private void BoxMarmaladeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new MarmaladeBoxPage());
        }

        private void MarmaladeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new MarmaladePage());
        }
    }
}
