using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Order:BaseEntity 
    {
        public string ShipAddress { get; set; }
        public string  FirstName { get; set; }
        public int ShipperID { get; set; }
        public int AppUserID { get; set; }




        //Relation Property

        public virtual List<OrderDetail>OrderDetails { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual  Shipper Shipper { get; set; }

    }
}
