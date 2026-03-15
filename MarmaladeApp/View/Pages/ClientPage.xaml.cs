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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        List<User> Users = App.context.User.ToList();
        public ClientPage()
        {
            InitializeComponent();
            InfoDG.ItemsSource = Users.Where(u=>u.RoleID != 1);
        }

        private void SerachTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            InfoDG.ItemsSource = Users.Where(u => u.Name.ToLower().Contains(SerachTB.Text.ToLower()) || u.Surename.ToLower().Contains(SerachTB.Text.ToLower()) || u.Patronymic.ToLower().Contains(SerachTB.Text.ToLower()) || u.Email.ToLower().Contains(SerachTB.Text.ToLower()) || u.Phone.ToLower().Contains(SerachTB.Text.ToLower()));
        }
    }
}
