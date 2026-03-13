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
    /// Логика взаимодействия для AddMarmaladeWindow.xaml
    /// </summary>
    public partial class AddMarmaladeWindow : Window
    {
        public AddMarmaladeWindow()
        {
            InitializeComponent();
            SupplierNameCMB.ItemsSource = App.context.Supplier.ToList();
            SupplierNameCMB.SelectedValuePath = "id";
            SupplierNameCMB.DisplayMemberPath = "Name";


        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SupplierNameCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = SupplierNameCMB.SelectedItem;
            if (select!=null)
            {
                Supplier selectCountry = (Supplier)select;
                CountrySupplierTBL.Text = selectCountry.Country;
            }

        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTB.Text)|| string.IsNullOrEmpty(CostTB.Text)|| string.IsNullOrEmpty(GrammTB.Text)|| string.IsNullOrEmpty(EnergyTB.Text)|| string.IsNullOrEmpty(CompoundTB.Text)||SupplierNameCMB.SelectedItem == null)
            {
                MessageBox.Show("Введите данные и/или выберите произвоидтеля","Информация",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                if (App.context.Marmalade.Any(u=>u.Name == NameTB.Text) == true)
                {
                    MessageBox.Show("Название уже существует");
                }
                else
                {

                bool halal = HalalCB.IsChecked.Value;
                var select = SupplierNameCMB.SelectedItem;
                Supplier supplier = (Supplier)select;

                Marmalade marmaladeN = new Marmalade()
                {
                    Name = NameTB.Text,
                    SupplierID = supplier.id,
                    Cost = Convert.ToDecimal(CostTB.Text),
                    Gramm = Convert.ToDecimal(GrammTB.Text),
                    Halal = halal,
                    Compound = CompoundTB.Text,
                    EnergyValue100gKilojoleOrCalories = Convert.ToInt32(EnergyTB.Text)
                };

                App.context.Marmalade.Add(marmaladeN);
                App.context.SaveChanges();
                MessageBox.Show("Мармелад создан успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                }
            }
        }
    }
}
