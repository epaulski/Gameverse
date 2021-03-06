﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class Product
    {
        public Product()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
            this.CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Platform { get; set; }
        public double Value { get; set; }
        public String ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> GenreId { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}