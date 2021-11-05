using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Ürünler");
            Property(x => x.ProductName).HasColumnName("Ürün Adı").IsRequired();
            Property(x => x.Unitprice).HasColumnName("Ürün Fiyatı").IsRequired();
            Property(x => x.UnitsInStock).HasColumnName("Ürün stok bilgisi");
        }
    }
}
