using Dashboard.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;


namespace Dashboard.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }   
        public DbSet<Brand> Brands { get; set; }  
        //public DbSet<Login> Logins { get; set; }    
        public DbSet<Addsupplier> Suppliers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Gst> gsts { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Sale> Sales{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
		public string WebRootPath { get; internal set; }
	}
}
