using Microsoft.EntityFrameworkCore;
using OurTravel.Shared.Entities;

namespace OurTravel.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCategory> CompanyCategories { get; set; }
        public DbSet<InterestedPlace> interestedPlaces { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();

            modelBuilder.Entity<State>().HasIndex("CountryId","Name").IsUnique();

            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
        }
    }
}
