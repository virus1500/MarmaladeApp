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
            Marmalade marmalade = this.DataContext as Marmalade;
            if (marmalade != null)
            {
                CartService.Items.Add(new CartItem
                {
                    MarmaladeID = marmalade.id,
                    Name = marmalade.Name,
                    Cost = marmalade.Cost
                });
                MessageBox.Show($"{marmalade.Name} добавлен в корзину");
            }
        }
    }
}
