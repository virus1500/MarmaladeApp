using MarmaladeApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MarmaladeApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Gogolev_marmaladeEntities context = new Gogolev_marmaladeEntities();
        public static Marmalade marmalade = new Marmalade();
        public static User user = new User();
        public static BoxMarmalade boxMarmalade = new BoxMarmalade();
        public static Supplier supplier = new Supplier();
    }
}
