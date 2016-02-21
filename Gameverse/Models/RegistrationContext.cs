using System.Data.Entity;

namespace Gameverse.Models
{
    //ep
    public class RegistrationContext : DbContext
    {
        public virtual DbSet<Registration> Registrations { get; set; }
    }
}