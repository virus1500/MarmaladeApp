using MarmaladeApp.Model;
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

namespace MarmaladeApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
       List<Marmalade> marmalades = App.context.Marmalade.ToList();
        public TestPage()
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;
        }

        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
