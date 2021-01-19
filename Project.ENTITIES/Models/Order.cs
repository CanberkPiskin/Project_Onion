using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public int? AppUserID { get; set; }


        public string EMail { get; set; }
        public string UserName { get; set; }

        //Relational properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails  { get; set; }


    }
}
