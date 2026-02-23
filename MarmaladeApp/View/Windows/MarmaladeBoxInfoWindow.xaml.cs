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
        private int MrldID;
        private List<Marmalade> marmalades = new List<Marmalade>();
        public MarmaladeBoxInfoWindow()
        {
            InitializeComponent();
            var MrldInf = marmalades.FirstOrDefault(m => m.id == MrldID);
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
