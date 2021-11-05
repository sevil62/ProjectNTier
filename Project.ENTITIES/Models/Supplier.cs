using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public  class Supplier:BaseEntity
    {
        public string ConpanyName { get; set; }
        public string  Phone { get; set; }

        //Relation Property

        public  virtual List<Product> Products { get; set; }
    }
}
