using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmaladeApp.AppData
{
    public class CartItem
    {
        public int? MarmaladeID { get; set; }
        public int? BoxMarmaladeID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

    }
}
