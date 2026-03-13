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
    /// Логика взаимодействия для AddBoxMarmaladeWindow.xaml
    /// </summary>
    public partial class AddBoxMarmaladeWindow : Window
    {
        public decimal costs = 0;
        public decimal gramms = 0;
        public decimal energys = 0;
        private void UpdateCosts()
        {
            decimal totalCosts = 0;
            decimal totalGrams = 0;
            decimal totalEnergy = 0;

            if (NameFstCMB.SelectedItem != null)
            {
                Marmalade marmalade = (Marmalade)NameFstCMB.SelectedItem;
                totalCosts += marmalade.Cost;
                totalGrams += marmalade.Gramm;
                totalEnergy += marmalade.EnergyValue100gKilojoleOrCalories;
            }

            if (NameSecCMB.SelectedItem != null)
            {
                Marmalade marmalade = (Marmalade)NameSecCMB.SelectedItem;
                totalCosts += marmalade.Cost;
                totalGrams += marmalade.Gramm;
                totalEnergy += marmalade.EnergyValue100gKilojoleOrCalories;
            }

            if (NameThirdCMB.SelectedItem != null)
            {
                Marmalade marmalade = (Marmalade)NameThirdCMB.SelectedItem;
                totalCosts += marmalade.Cost;
                totalGrams += marmalade.Gramm;
                totalEnergy += marmalade.EnergyValue100gKilojoleOrCalories;
            }

            if (NameFourthCMB.SelectedItem != null)
            {
                Marmalade marmalade = (Marmalade)NameFourthCMB.SelectedItem;
                totalCosts += marmalade.Cost;
                totalGrams += marmalade.Gramm;
                totalEnergy += marmalade.EnergyValue100gKilojoleOrCalories;
            }

            
            costs = totalCosts;
            gramms = totalGrams;
            energys = totalEnergy;

            
            CostTBl.Text = costs.ToString();
            GrammTBl.Text = gramms.ToString();
            EnergyTBl.Text = energys.ToString();

        }
        public AddBoxMarmaladeWindow()
        {
            InitializeComponent();
            NameFstCMB.ItemsSource = App.context.Marmalade.ToList();
            NameSecCMB.ItemsSource = App.context.Marmalade.ToList();
            NameThirdCMB.ItemsSource = App.context.Marmalade.ToList();
            NameFourthCMB.ItemsSource = App.context.Marmalade.ToList();

            NameFstCMB.SelectedValuePath = "id";
            NameSecCMB.SelectedValuePath = "id";
            NameThirdCMB.SelectedValuePath = "id";
            NameFourthCMB.SelectedValuePath = "id";

            NameFstCMB.DisplayMemberPath = "Name";
            NameSecCMB.DisplayMemberPath = "Name";
            NameThirdCMB.DisplayMemberPath = "Name";
            NameFourthCMB.DisplayMemberPath = "Name";

            CostTBl.Text = costs.ToString();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTB.Text) || NameFstCMB.SelectedItem == null || NameSecCMB.SelectedItem == null || NameThirdCMB.SelectedItem == null || NameFourthCMB.SelectedItem == null)
            {
                MessageBox.Show("Введите Название и/или выберите Мармелад", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (App.context.BoxMarmalade.Any(u => u.Name == NameTB.Text) == true)
                {
                    MessageBox.Show("Название уже существует");
                }
                else
                {

                    var select1 = NameFstCMB.SelectedItem;
                    Marmalade select1box = (Marmalade)select1;

                    var select2 = NameSecCMB.SelectedItem;
                    Marmalade select2box = (Marmalade)select2;

                    var select3 = NameThirdCMB.SelectedItem;
                    Marmalade select3box = (Marmalade)select3;

                    var select4 = NameFourthCMB.SelectedItem;
                    Marmalade select4box = (Marmalade)select4;

                    BoxMarmalade boxmarmaladeN = new BoxMarmalade()
                    {
                        Name = NameTB.Text,
                        MarmaladeID1 = select1box.id,
                        MarmaladeID2 = select2box.id,
                        MarmaladeID3 = select3box.id,
                        MarmaladeID4 = select4box.id,
                    };

                    App.context.BoxMarmalade.Add(boxmarmaladeN);
                    App.context.SaveChanges();
                    MessageBox.Show("Бокс создан успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    this.Close();


                }
            }
        }

        private void NameFstCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCosts();
        }

        private void NameSecCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCosts();
        }
        private void NameThirdCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCosts();
        }

        private void NameFourthCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCosts();
        }

    }
}