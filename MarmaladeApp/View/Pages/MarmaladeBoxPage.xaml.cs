using MarmaladeApp.Model;
using MarmaladeApp.View.Windows;
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
    /// Логика взаимодействия для MarmaladeBoxPage.xaml
    /// </summary>
    public partial class MarmaladeBoxPage : Page
    {
        List<BoxMarmalade> marmalades = App.context.BoxMarmalade.ToList();
        public MarmaladeBoxPage(User user)
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;
            if (user.Role.id==1)
            {
                AddBtn.Visibility = Visibility.Visible;
            }
        }

        private void InfoClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var marmaladeInfo = sender as Border;
            if (marmaladeInfo != null)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    var datacontext = marmaladeInfo.DataContext;

                    var marmaladeBoxInfoWindow = new MarmaladeBoxInfoWindow();
                    marmaladeBoxInfoWindow.DataContext = datacontext;
                    Window mainWindow = Application.Current.MainWindow;
                    marmaladeBoxInfoWindow.Owner = mainWindow;
                    marmaladeBoxInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    marmaladeBoxInfoWindow.ShowDialog();
                }
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddBoxMarmaladeWindow addBoxMarmaladeWindow = new AddBoxMarmaladeWindow();
            Window mainWindow = Application.Current.MainWindow;
            addBoxMarmaladeWindow.Owner = mainWindow;
            addBoxMarmaladeWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addBoxMarmaladeWindow.ShowDialog();
        }

        private void FiltrCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            InfoIC.ItemsSource = marmalades.Where(u => u.Name.ToLower().Contains(SearchTB.Text.ToLower()));
        }
    }
}
