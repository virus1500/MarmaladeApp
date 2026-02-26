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
        public MarmaladeBoxPage()
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;
        }

        private void InfoClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //int marmaladeID = App.context.Marmalade.;
            var marmaladeInfo = sender as Border;
            if (marmaladeInfo != null)
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    var datacontext = marmaladeInfo.DataContext;
                    MarmaladeBoxInfoWindow marmaladeBoxInfoWindow = new MarmaladeBoxInfoWindow();
                    Window mainWindow = Application.Current.MainWindow;
                    marmaladeBoxInfoWindow.Owner = mainWindow;
                    marmaladeBoxInfoWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    marmaladeBoxInfoWindow.DataContext = datacontext;
                    marmaladeBoxInfoWindow.ShowDialog();
                }
            }
        }
    }
}
