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
    /// Логика взаимодействия для MarmaladeBoxInfoWindow.xaml
    /// </summary>
    public partial class MarmaladeBoxInfoWindow : Window
    {
        
        //int _marmaladeID;
        //private List<Marmalade> marmalades = App.context.Marmalade.ToList();
        //private List<BoxMarmalade> boxMarmalades = App.context.BoxMarmalade.ToList();
        public MarmaladeBoxInfoWindow(/*int marmaladeID*/)
        {
            InitializeComponent();
            //InfoGrid.DataContext = marmalades.FirstOrDefault(m => m.id == marmaladeID);
            //MarmaladeName1TB.Text = InfoGrid.DataContext.ToString();

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
