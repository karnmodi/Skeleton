using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCart
    {
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Active { get; set; }
        public int TotalPrice { get; set; }
        public string CartDiscription { get; set; }
        public int CartID { get; set; }
    }
}
