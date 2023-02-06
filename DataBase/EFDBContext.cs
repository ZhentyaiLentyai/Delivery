using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class EFDBContext : DbContext
    {
        public DbSet<Base> Base { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }

        public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
        {
            public EFDBContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBForDelivery=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataBase"));

                return new EFDBContext(optionsBuilder.Options);
            }
        }
    }
}
