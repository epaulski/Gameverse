using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public double Total { get; set; }
        public String Status { get; set; }
        public DateTime Date { get; set; }
        public Nullable<int> ShippingAddressId { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public virtual User User { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        
    }
}