using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}