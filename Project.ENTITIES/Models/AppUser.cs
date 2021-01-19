using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }
        public string EMail { get; set; }
        public UserRole Role { get; set; }


        public AppUser()
        {
            ActivationCode = new Guid();
            Role = UserRole.Member;
        }

        //Relational properties
        public virtual UserProfile UserProfile  { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
