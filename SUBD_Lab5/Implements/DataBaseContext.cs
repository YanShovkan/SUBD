using Implements.Models;
using Microsoft.EntityFrameworkCore;

namespace Implements
{
   public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NSNKSRN;Initial Catalog=LaborExchangeDatabaseWithIndexes;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>().HasIndex(u => u.Specialty);
            modelBuilder.Entity<Employee>().HasIndex(u => u.Name);
            modelBuilder.Entity<Deal>().HasIndex(u => u.ApplicantId);
            modelBuilder.Entity<Firm>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Vacancy>().HasIndex(u => u.FirmId);
        }
        public virtual DbSet<Applicant> Applicants { set; get; }
        public virtual DbSet<Deal> Deals { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Firm> Firms { set; get; }
        public virtual DbSet<Vacancy> Vacancyes { set; get; }
    }
}
