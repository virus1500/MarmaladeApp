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
using System.Xml.Linq;

namespace MarmaladeApp.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MarmaladeInfoWindow.xaml
    /// </summary>
    public partial class MarmaladeInfoWindow : Window
    {
        public MainViewModel ViewModel { get; set; }

        public MarmaladeInfoWindow()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            //if (mainWindow != null)
            //{
            //    var datacontext = this.DataContext as Marmalade;

            //    string name = MarmaladeNameTB.Text;
            //    decimal cost = datacontext.Cost;

            //    mainWindow.AddToCart(name, cost);
            //    MessageBox.Show(name, cost.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Главное окно не найдено или имеет неправильный тип.");
            //}
            // В обработчике "BuyBtn_Click" или аналогичном

            
            //    ((MainWindow)Application.Current.MainWindow).AddToCart(name, cost);
        }
    }
}
