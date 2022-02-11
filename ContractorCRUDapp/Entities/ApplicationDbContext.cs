using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorCRUDapp.Entities
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorType> ContractorTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contractor>()
                .Property(p => p.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Contractor>()
               .Property(p => p.NipNumber).IsRequired().HasMaxLength(10);

            modelBuilder.Entity<Contractor>()
               .Property(p => p.ContractorTypeId).IsRequired();

            modelBuilder.Entity<Contractor>()
               .Property(p => p.Details).HasMaxLength(500);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ContracentsDb;Trusted_Connection=True;");
            
        }
    }
}
