

namespace TrabajoP.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TrabajoP.Models.Employce> Employces { get; set; }
    }
}