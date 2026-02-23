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
        public MarmaladePage()
        {
            InitializeComponent();
            InfoIC.ItemsSource = marmalades;
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
    }
}
