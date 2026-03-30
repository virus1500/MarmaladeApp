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
        public bool IsAdmin { get; set; }
        List<BoxMarmalade> marmalades = App.context.BoxMarmalade.ToList();
        public MarmaladeBoxPage(User user)
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;

            IsAdmin = user.Role.id == 1;
            DataContext = this;

            FiltrCMB.Items.Insert(0, "Нет");
            FiltrCMB.Items.Insert(1, "Халяль");
            FiltrCMB.Items.Insert(2, "Не халяль");
            FiltrCMB.SelectedIndex = 0;



            if (user.Role.id==1){ AddBtn.Visibility = Visibility.Visible;}
        }

        private void InfoClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var marmaladeInfo = sender as Border;
            if (marmaladeInfo != null)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    var datacontext = marmaladeInfo.DataContext as BoxMarmalade;

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
            //if (FiltrCMB.SelectedIndex == 0)
            //{
            //    InfoIC.ItemsSource = marmalades;
            //    //SearchTB.Text = SearchTB.Text;
            //}
            //if (FiltrCMB.SelectedIndex == 1)
            //{
            //    InfoIC.ItemsSource = App.context.Marmalade.Where(u => u.Halal == true).ToList();
            //    //SearchTB.Text = SearchTB.Text;
            //}
            //if (FiltrCMB.SelectedIndex == 2)
            //{
            //    InfoIC.ItemsSource = App.context.Marmalade.Where(u => u.Halal == false).ToList();
            //    //SearchTB.Text = SearchTB.Text;
            //}
            //if (FiltrCMB.SelectedItem == null) return;

            //var filteredList = allMarmalades; // твой исходный список мармелада

            //switch (FiltrCMB.SelectedIndex)
            //{
            //    case 1: // Халяль
            //        filteredList = allMarmalades.Where(m => m.Halal).ToList();
            //        break;
            //    case 2: // Не халяль
            //        filteredList = allMarmalades.Where(m => !m.Halal).ToList();
            //        break;
            //        // case 0 — Нет фильтра, показываем всё
            //}

            //InfoIC.ItemsSource = filteredList;
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            InfoIC.ItemsSource = marmalades.Where(u => u.Name.ToLower().Contains(SearchTB.Text.ToLower()));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            BoxMarmalade item = btn.CommandParameter as BoxMarmalade;

            if (item == null) return;

            // удаляем из БД
            App.context.BoxMarmalade.Remove(item);
            App.context.SaveChanges();

            // удаляем из списка
            marmalades.Remove(item);

            // обновляем UI
            InfoIC.ItemsSource = null;
            InfoIC.ItemsSource = marmalades;
        }
    }
}
