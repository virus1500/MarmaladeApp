using MarmaladeApp.AppData;
using MarmaladeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        public MarmaladeBoxInfoWindow()
        {
            InitializeComponent();
            this.Loaded += MarmaladeBoxInfoWindow_Loaded;
            

        }

        private void MarmaladeBoxInfoWindow_Loaded(object sender, RoutedEventArgs e)
        {

            //var contextforInfo1 = App.context.Marmalade.FirstOrDefault(m => m.id == datacontext.MarmaladeID1);
            //var contextforInfo2 = App.context.Marmalade.FirstOrDefault(m => m.id == datacontext.MarmaladeID2);
            //var contextforInfo3 = App.context.Marmalade.FirstOrDefault(m => m.id == datacontext.MarmaladeID3);
            //var contextforInfo4 = App.context.Marmalade.FirstOrDefault(m => m.id == datacontext.MarmaladeID4);


            //MarmaladeName1TB.Text = contextforInfo1.Name;
            //MarmaladeName2TB.Text = contextforInfo2.Name;
            //if (contextforInfo3 == null)
            //{
            //    MarmaladeName4TB.Visibility = Visibility.Collapsed;

            //}
            //else 
            //{
            //MarmaladeName3TB.Text = contextforInfo3.Name;
            //}

            //if (contextforInfo4 == null)
            //{
            //    MarmaladeName4TB.Visibility = Visibility.Collapsed;
            //}
            //else
            //{ 
            //    MarmaladeName4TB.Text = contextforInfo4.Name;
            //}
            //MarmaladeBoxCostTB.Text = (contextforInfo1.Cost + contextforInfo2.Cost + contextforInfo3.Cost + contextforInfo4.Cost).ToString();

            var datacontext = this.DataContext as BoxMarmalade;
            var marmaladeIds = new[]
            {
                new BoxMarmaladeClass {id = datacontext.MarmaladeID1, textBlock = MarmaladeName1TB},
                new BoxMarmaladeClass {id = datacontext.MarmaladeID2, textBlock = MarmaladeName2TB},
                new BoxMarmaladeClass {id = datacontext.MarmaladeID3, textBlock = MarmaladeName3TB},
                new BoxMarmaladeClass {id = datacontext.MarmaladeID4, textBlock = MarmaladeName4TB},
            };

            double totalCost = 0;
            decimal totalGarmm = 0;
            int totalEnergy = 0;
            List<string> collectedCompounds = new List<string>();
            bool anyHalal = false;

            foreach (var item in marmaladeIds)
            {
                if (item.id.HasValue)
                {

                    var contextforInfo = App.context.Marmalade.FirstOrDefault(m => m.id == item.id.Value);
                    if (contextforInfo != null)
                    {
                        item.textBlock.Text = contextforInfo.Name;
                        item.textBlock.Visibility = Visibility.Visible;


                        totalCost += (double)contextforInfo.Cost;
                        totalGarmm += contextforInfo.Gramm;
                        totalEnergy += contextforInfo.EnergyValue100gKilojoleOrCalories;

                        if (!string.IsNullOrEmpty(contextforInfo.Compound))
                        {
                            collectedCompounds.Add(contextforInfo.Compound);
                        }
                        if (contextforInfo.Halal)
                        {
                            anyHalal = true;
                        }
                    }
                    else
                    {

                        item.textBlock.Visibility = Visibility.Collapsed;
                    }
                }
                else
                {
                    item.textBlock.Visibility = Visibility.Collapsed;
                }
            }


            string compoundsStr = string.Join(", ", collectedCompounds);


            MarmaladeBoxCostTB.Text = totalCost.ToString("F2");
            MarmaladeGrammTB.Text = totalGarmm.ToString();
            MarmaladeEnergyTB.Text = totalEnergy.ToString();
            MarmaladeHalalTB.Text = anyHalal ? "да" : "нет";
            MarmaladeCompoundTB.Text = compoundsStr;

        }
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void MarmaladeName1TB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var datacontext = this.DataContext as BoxMarmalade;
            var contextforInfo1 = App.context.Marmalade.FirstOrDefault(m => m.id == datacontext.MarmaladeID1);
            InfoMarmaladeForBoxMarmaladeWindow infoMarmaladeForBoxMarmaladeWindow = new InfoMarmaladeForBoxMarmaladeWindow();
            infoMarmaladeForBoxMarmaladeWindow.DataContext = contextforInfo1;
            infoMarmaladeForBoxMarmaladeWindow.Show();
            //this.Hide();
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBoxTB.Text;
            decimal cost = decimal.Parse(MarmaladeBoxCostTB.Text);

            // Добавляем в корзину
            ((MainWindow)Application.Current.MainWindow).AddToCart(name, cost);
        }
    }
}
