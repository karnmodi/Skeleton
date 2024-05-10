using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsProduct
    {
        public bool Active { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public double Price { get; set; }
        public string Condition { get; set; }
        public bool Avaibility { get; set; }
        public string ImageURL { get; set; }
        public DateTime DateListed { get; set; }
    }
}
