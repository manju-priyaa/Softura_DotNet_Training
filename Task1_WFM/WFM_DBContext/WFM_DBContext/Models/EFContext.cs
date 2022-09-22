using Microsoft.EntityFrameworkCore;
using WFM_Models.Models;

namespace WFM_DBContext.Models
{
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Skillmap> skillmap { get; set; }

        public DbSet<Skills> skills { get; set; }

        public DbSet<Softlock> softlock { get; set; }
        public DbSet<Users> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Skillmap>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });

            modelBuilder
               .Entity<Users>(
                   eb =>
                   {
                       eb.HasNoKey();
                   });
        }


    }
}
