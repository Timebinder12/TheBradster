using Microsoft.EntityFrameworkCore;
using TheBradster.Models;

namespace TheBradster.Models
{
    public class AccountsContext : DbContext
    {
        public AccountsContext(DbContextOptions<AccountsContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
            .HasOne<Account>(a => a.Account) //Navigation property in Address class
            .WithMany(d => d.Address) //Navigation property in Account Class
            .HasForeignKey(a => a.Id);

            modelBuilder.Entity<Music>()
                .HasOne<Account>(a => a.Account)
                .WithMany(d => d.Music)
                .HasForeignKey(e => e.AccountId);


            modelBuilder.Entity<Address>().HasData(
             new Address
             {
                 Id = 1,
                 AddressLine = "123 Main St",
                 City = "Main City",
                 State = "Main State",
                 Zip = "10000"
             },
                new Address
                {
                    Id = 2,
                    AddressLine = "456 Main St",
                    City = "Main City",
                    State = "Main State",
                    Zip = "20000"
                }); ;

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = 1,
                    FirstName = "Shane",
                    LastName = "Reed",
                    Email = "shanereed28@gmail.com",

                },
                new Account
                {
                    Id = 2,
                    FirstName = "Brad",
                    LastName = "Reed",
                    Email = "brad@informationpathways.com",


                });



 

                
        }

        public DbSet<TheBradster.Models.Music>? Music { get; set; }
    }
}
