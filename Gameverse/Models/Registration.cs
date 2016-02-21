using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gameverse.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zipcode { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String EmailOffer { get; set; }
    }
}