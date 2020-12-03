using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public  class Food
    {
       public int Id { set; get; } 
       public string ProductName { set; get; }
        public string ProductDescription { set; get; }
        public string ProductQuantity { set; get; }
        public decimal ProductPrice { set; get; }
        public bool ProductDiscount { set; get; }
        public int InStock { set; get; }
    }
}
