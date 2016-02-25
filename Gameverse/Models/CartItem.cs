using Gameverse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public int Quantity { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}