using System.Data.Entity;

namespace AdvancoTask
{
    public class AdvancoContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
    }
}
