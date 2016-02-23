using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public String CardNumber { get; set; }
        public String SecutiryCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Nullable<int> BillingAddressId { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public virtual Address BillingAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}