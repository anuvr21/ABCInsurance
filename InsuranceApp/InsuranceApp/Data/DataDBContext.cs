using InsuranceApp.Model;
using Microsoft.EntityFrameworkCore;



namespace InsuranceApp.Data
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> option) : base(option)
        {



        }



        public DbSet<Member> Member { get; set; }
        public DbSet<Provider> Provider { get; set; }



        public DbSet<Pharmacy> Pharmacy { get; set; }
    }
}