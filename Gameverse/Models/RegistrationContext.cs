using System.Data.Entity;

namespace Gameverse.Models
{
    public partial class RegistrationContext : DbContext
    {
        public RegistrationContext()
            : base("name=RegistrationContext")
        {

        }
        public virtual DbSet<Registration> Registrations { get; set; }
    }
}