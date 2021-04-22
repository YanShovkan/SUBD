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
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NSNKSRN;Initial Catalog=LaborExchangeDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Applicant> Applicants { set; get; }
        public virtual DbSet<Deal> Deals { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Firm> Firms { set; get; }
        public virtual DbSet<Vacancy> Vacancyes { set; get; }
    }
}
