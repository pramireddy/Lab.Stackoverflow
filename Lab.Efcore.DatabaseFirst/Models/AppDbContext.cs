using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Efcore.DatabaseFirst.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>().ToTable("Sales.Customers");
        //    modelBuilder.Entity<Candidate>().ToTable("Candidates");

        //}
    }
}
