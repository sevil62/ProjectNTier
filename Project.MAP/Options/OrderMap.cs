using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Sipariş");
            Property(x => x.FirstName).HasColumnName("Sipariş Adı").IsRequired();
            Property(x => x.ShipAddress).HasColumnName("Sipariş Adresi").IsRequired();

        }
    }
}
