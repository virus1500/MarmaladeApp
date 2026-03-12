using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MarmaladeApp.AppData
{
    internal class BoxMarmaladeClass
    {
        internal int? id { get; set; }
        public TextBlock textBlock { get; set; }
        public int gramm { get; set; }
        public bool halal { get; set; }
        public string compound { get; set; }
        public int energyValue100gKilojoleOrCalories { get; set; }
    }
     

}
