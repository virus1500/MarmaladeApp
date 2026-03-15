using MarmaladeApp.AppData;
using MarmaladeApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        private User thisuser;
        public OrderPage(User user)
        {
            InitializeComponent();
            thisuser = user;
            InfoDG.ItemsSource = CartService.Items;
            UpdateSum();
            CartService.Items.CollectionChanged += (s, e) => UpdateSum();
        }
        private void UpdateSum()
        {
            SumTBl.Text = $"Сумма: {CartService.TotalCost} ₽";
        }

        private void CreateTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Gogolev_marmaladeEntities())
            {
                // 1. Создаем тикет
                var ticket = new Ticket
                {
                    UserID = thisuser.id, // текущий пользователь
                    DateOrder = DateTime.Now,
                    OrderCompleted = false
                };
                db.Ticket.Add(ticket);
                db.SaveChanges(); // чтобы получить ticket.id

                // 2. Добавляем позиции
                foreach (var item in CartService.Items)
                {
                    if (item.MarmaladeID.HasValue)
                    {
                        db.TM.Add(new TM
                        {
                            TIcketID = ticket.id,
                            MarmaladeID = item.MarmaladeID.Value,
                            Amount = 1 // по умолчанию 1, можно расширить
                        });
                    }
                    else if (item.BoxMarmaladeID.HasValue)
                    {
                        db.TBM.Add(new TBM
                        {
                            TicketID = ticket.id,
                            BoxMarlaladeID = item.BoxMarmaladeID.Value,
                            Amount = 1
                        });
                    }
                }

                db.SaveChanges();

                MessageBox.Show("Заказ создан успешно!");
                CartService.Items.Clear();
            }
        }

        private void ClearTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            CartService.Items.Clear();
        }

        private void DelItemBtn_Click(object sender, RoutedEventArgs e)
        {
            if (InfoDG.SelectedItem is CartItem selected)
                CartService.Items.Remove(selected);
        }
    }
}
