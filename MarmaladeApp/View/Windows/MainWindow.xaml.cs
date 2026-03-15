using MarmaladeApp.AppData;
using MarmaladeApp.Model;
using MarmaladeApp.View.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        

        //private User thisuser;
        public MainWindow()
        {
            InitializeComponent();
            //thisuser = user;
            //AccBtn.DataContext = user;
            //AccBtn.Content = user.Login +" "+ user.Role.Name;

            //if (user.Role.id != 1)
            //{
            //    ClientsBtn.Visibility = Visibility.Collapsed;
            //    SupplierBtn.Visibility = Visibility.Collapsed;
            //    OrderBtn.Visibility = Visibility.Collapsed;
            //}
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

        private void AccBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AccPage());
        }

        private void TicketBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OrderPage());
        }
    }
}
