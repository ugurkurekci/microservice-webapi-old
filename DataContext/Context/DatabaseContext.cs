using Category.API.Entities.Concretes;
using Company.API.Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Users.API.Entities;

namespace DataContext.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MicroService;Trusted_Connection=true");
        }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Deparment> Deparment { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserLog> UserLog { get; set; }






    }
}
