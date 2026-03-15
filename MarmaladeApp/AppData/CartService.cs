using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmaladeApp.AppData
{
    internal class CartService
    {
        public static ObservableCollection<CartItem> Items { get; } = new ObservableCollection<CartItem>();
        public static decimal TotalCost => Items.Sum(x => x.Cost);
    }
}
