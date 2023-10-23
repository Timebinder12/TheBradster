using Microsoft.EntityFrameworkCore;

namespace TheBradster.Models
{
    public class AccountsContext : DbContext
    {
        public AccountsContext(DbContextOptions<AccountsContext> options) : base(options) { }

        public DbSet<Accounts> Accounts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Shane", Password = "password1"},
                new User { UserId = 2, UserName = "Bradster", Password = "password2"}        
                );


            modelBuilder.Entity<Accounts>().HasData(
                new Accounts
                {
                    Id = 1,
                    FirstName = "Shane",
                    LastName = "Reed",
                    Email = "shanereed28@gmail.com",
                    UserId = 1
                },
                new Accounts
                {
                    Id = 2,
                    FirstName = "Brad",
                    LastName = "Reed",
                    Email = "brad@informationpathways.com",
                    UserId = 2
                }

                );
        }
    }
}
