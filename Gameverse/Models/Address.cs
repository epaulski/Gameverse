using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class Address
    {
        public Address()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zipcode { get; set; }
        public String Type { get; set; }
        public Nullable<int> UserId { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
 
    }
}