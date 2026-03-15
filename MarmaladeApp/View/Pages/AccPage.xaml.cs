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
    /// Логика взаимодействия для AccPage.xaml
    /// </summary>
    public partial class AccPage : Page
    {
        //private User thisuser;
        public AccPage()
        {
            InitializeComponent();
            //thisuser = user;

            //LoginTB.Text = user.Login;
            //EmailTB.Text = user.Email;
            //PhoneTB.Text = user.Phone;
            //NameTB.Text = user.Name;
            //SurenameTB.Text = user.Surename;
            //PatronymicTB.Text = user.Patronymic;

            //LoginTBx.Text = user.Login;
            //EmailTBx.Text = user.Email;
            //PhoneTBx.Text = user.Phone;
            //NameTBx.Text = user.Name;
            //SurenameTBx.Text = user.Surename;
            //PatronymicTBx.Text = user.Patronymic;

            //PassPB.Password = user.Password;
            //RepPassPB.Password = user.Password;
            
            PassTBl.Text = new string('*', PassPB.Password.Length);

            PassPB.Visibility = Visibility.Collapsed;
            RepPassPB.Visibility = Visibility.Collapsed;

            LoginTBx.Visibility = Visibility.Collapsed;
           EmailTBx.Visibility = Visibility.Collapsed;
           PhoneTBx.Visibility = Visibility.Collapsed;
           NameTBx.Visibility = Visibility.Collapsed;
           SurenameTBx.Visibility = Visibility.Collapsed;
           PatronymicTBx.Visibility = Visibility.Collapsed;

            SaveBtn.Visibility = Visibility.Collapsed;
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {


            LoginTB.Visibility = Visibility.Collapsed;
            EmailTB.Visibility = Visibility.Collapsed;
            PhoneTB.Visibility = Visibility.Collapsed;
            NameTB.Visibility = Visibility.Collapsed;
            SurenameTB.Visibility = Visibility.Collapsed;
            PatronymicTB.Visibility = Visibility.Collapsed;

            LoginTBx.Visibility = Visibility.Visible;
            EmailTBx.Visibility = Visibility.Visible;
            PhoneTBx.Visibility = Visibility.Visible;
            NameTBx.Visibility = Visibility.Visible;
            SurenameTBx.Visibility = Visibility.Visible;
            PatronymicTBx.Visibility = Visibility.Visible;

            PassPB.Visibility = Visibility.Visible;
            RepPassPB.Visibility = Visibility.Visible;
            PassTBl.Visibility = Visibility.Collapsed;

            SaveBtn.Visibility = Visibility.Visible;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (string.IsNullOrEmpty(LoginTBx.Text)|| string.IsNullOrEmpty(EmailTBx.Text)|| string.IsNullOrEmpty(PhoneTBx.Text)|| string.IsNullOrEmpty(NameTBx.Text)|| string.IsNullOrEmpty(SurenameTBx.Text)|| string.IsNullOrEmpty(PatronymicTBx.Text)|| string.IsNullOrEmpty(PassPB.Password) || string.IsNullOrEmpty(RepPassPB.Password))
            //{
            //    MessageBox.Show("Введите данные");
            //}
            //else
            //{
            //    if (PassPB.Password!=RepPassPB.Password)
            //    {
            //        MessageBox.Show("Пароли не совпадают");
            //    }
            //    else
            //    {
            //        string login = thisuser.Login;
            //        bool loginChange = login == LoginTBx.Text;
            //        if (loginChange == false)
            //        {
            //            if (App.context.User.Any(u => u.Login == LoginTBx.Text) == true)
            //            {
            //                MessageBox.Show("Логин или телефон или почта уже зарегестрированны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //            }
            //            else
            //            {
            //                string email = thisuser.Email;
            //                bool emailChange = email == LoginTBx.Text;
            //                if (emailChange==false)
            //                {
            //                    if (App.context.User.Any(u => u.Email == EmailTBx.Text) == true)
            //                    {
            //                        MessageBox.Show("Почта уже зарегестрированн", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //                    }
            //                    else
            //                    {
            //                        string phone = thisuser.Phone;
            //                        bool phoneChange = phone == LoginTBx.Text;
            //                        if (phoneChange==false)
            //                        {
            //                            if (App.context.User.Any(u => u.Phone == PhoneTBx.Text) == true)
            //                            {
            //                                MessageBox.Show("Телефон уже зарегестрированн", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //                            }
            //                        }
            //                    }
            //                }
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show(thisuser.Login);
            //        }

                }
                
            }
        }
    

//LoginTBx.Visibility = Visibility.Collapsed;
//EmailTBx.Visibility = Visibility.Collapsed;
//PhoneTBx.Visibility = Visibility.Collapsed;
//NameTBx.Visibility = Visibility.Collapsed;
//SurenameTBx.Visibility = Visibility.Collapsed;
//PatronymicTBx.Visibility = Visibility.Collapsed;

//PassPB.Visibility = Visibility.Collapsed;
//RepPassPB.Visibility = Visibility.Collapsed;
//PassTBl.Visibility = Visibility.Collapsed;

//SaveBtn.Visibility = Visibility.Collapsed;

//LoginTB.Visibility = Visibility.Visible;
//EmailTB.Visibility = Visibility.Visible;
//PhoneTB.Visibility = Visibility.Visible;
//NameTB.Visibility = Visibility.Visible;
//SurenameTB.Visibility = Visibility.Visible;
//PatronymicTB.Visibility = Visibility.Visible;