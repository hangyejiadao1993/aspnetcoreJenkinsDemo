using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace frontend.Model
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer()
            {

                Id = 1,
                Name = "Microsoft",
                VAT = "IE8256789U",
                Enabled = true
            }, new Customer()
            {
                Id = 2,
                Name = "Google",
                VAT = "IE6388047V",
                Enabled = false
            });
        }
    }
}