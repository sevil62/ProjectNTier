using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity 
    {
        public string  ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal  Unitprice { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }

        //Relation Property

        public virtual  Category Category  { get; set; }
        public virtual  List<OrderDetail>OrderDetails { get; set; }
       
        public virtual Supplier Supplier { get; set; }

    }
}
