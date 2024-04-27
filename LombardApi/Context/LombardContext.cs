using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LombardApi.Context
{
    public class LombardContext: DbContext
    {
        public LombardContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
    optionsBuilder.UseSqlServer("Server=POPC;initial catalog=Lombard;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;");

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
