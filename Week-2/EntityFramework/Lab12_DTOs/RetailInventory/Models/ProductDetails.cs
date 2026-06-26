using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailInventory.Models
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public string WarrantyInfo { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
