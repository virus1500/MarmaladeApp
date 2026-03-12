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
using System.Windows.Shapes;

namespace MarmaladeApp.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для InfoMarmaladeForBoxMarmaladeWindow.xaml
    /// </summary>
    public partial class InfoMarmaladeForBoxMarmaladeWindow : Window
    {
        public InfoMarmaladeForBoxMarmaladeWindow()
        {
            InitializeComponent();

            var datacontext = this.DataContext as Marmalade;

            //MarmaladeNameTB.Text = datacontext.Name;
            //MarmaladeCostTB.Text = datacontext.Cost.ToString();
            //MarmaladeCompoundTB.Text = datacontext.Compound;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            //MarmaladeBoxInfoWindow marmaladeBoxInfoWindow = (MarmaladeBoxInfoWindow)Application.Current.MainWindow;
            //marmaladeBoxInfoWindow.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
