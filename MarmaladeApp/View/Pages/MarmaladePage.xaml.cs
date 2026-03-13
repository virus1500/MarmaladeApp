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
    /// Логика взаимодействия для MarmaladePage.xaml
    /// </summary>
    public partial class MarmaladePage : Page
    {
        List<Marmalade> marmalades = App.context.Marmalade.ToList();
        public MarmaladePage(User user)
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;

            FiltrCMB.Items.Insert(0,"Нет");
            FiltrCMB.Items.Insert(1,"Халяль");
            FiltrCMB.Items.Insert(2,"Не халяль");
            FiltrCMB.SelectedIndex = 0;
            if (user.Role.id==1) { AddBtn.Visibility = Visibility.Visible; }
        }

        private void InfoClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var marmaladeInfo = sender as Border;
            if (marmaladeInfo != null)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    var datacontext = marmaladeInfo.DataContext;
                    MarmaladeInfoWindow marmaladeInfoWindow = new MarmaladeInfoWindow();
                    Window mainWindow = Application.Current.MainWindow;
                    marmaladeInfoWindow.Owner = mainWindow;
                    marmaladeInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    marmaladeInfoWindow.DataContext = datacontext;
                    marmaladeInfoWindow.ShowDialog();
                }
            }
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            InfoIC.ItemsSource = marmalades.Where(u => u.Name.ToLower().Contains(SearchTB.Text.ToLower()));
        }

        private void FiltrCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiltrCMB.SelectedIndex == 0)
            {
                InfoIC.ItemsSource = marmalades;
                //SearchTB.Text = SearchTB.Text;
            }
            if (FiltrCMB.SelectedIndex == 1)
            {
                InfoIC.ItemsSource = App.context.Marmalade.Where(u=>u.Halal == true).ToList();
                //SearchTB.Text = SearchTB.Text;
            }
            if (FiltrCMB.SelectedIndex == 2)
            {
                InfoIC.ItemsSource = App.context.Marmalade.Where(u => u.Halal == false).ToList();
                //SearchTB.Text = SearchTB.Text;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddMarmaladeWindow addMarmaladeWindow = new AddMarmaladeWindow();
            Window mainWindow = Application.Current.MainWindow;
            addMarmaladeWindow.Owner = mainWindow;
            addMarmaladeWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addMarmaladeWindow.ShowDialog();
        }
    }
}
