using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class InsuranceContext: DbContext
    {
        string connectionString;
        
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        { }

        public InsuranceContext(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public InsuranceContext()
        {
            connectionString = "Host=localhost;Port=5432;Database=Insurance;Username=postgres;Password=0660838337";
        }

        public DbSet<models.Branch> Branches { get; set; }
        public DbSet<models.City> Cities { get; set; }
        public DbSet<models.Client> Clients { get; set; }
        public DbSet<models.InsuranseVariant> InsuranseVariants { get; set; }
        public DbSet<models.License> Licenses { get; set; }
        public DbSet<models.Office> Offices { get; set; }
        public DbSet<models.TypeProperty> TypeProperties { get; set; }
        public DbSet<models.Worker> Workers { get; set; }
        public DbSet<models.Contract> Contracts { get; set; }
        public DbSet<models.Social> Socials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
