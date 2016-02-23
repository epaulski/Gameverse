using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class User
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String EmailOffer { get; set; }
        public Nullable<int> AddressId { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        
    }
}