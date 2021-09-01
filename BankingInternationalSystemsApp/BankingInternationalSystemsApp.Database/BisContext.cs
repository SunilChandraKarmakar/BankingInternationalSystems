using BankingInternationalSystemsApp.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingInternationalSystemsApp.Database
{
    public class BisContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<WithdrawAccount> WithdrawAccounts {  get; set; }   
        public DbSet<LodgeAccount> LodgeAccounts {  get; set; }
        public DbSet<BankService> BankServices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(a => new { a.AccountNumber, a.Email }).IsUnique();
            modelBuilder.Entity<BankService>().HasIndex(bs => bs.Name).IsUnique();
            modelBuilder.Entity<Role>().HasIndex(r => r.Name).IsUnique();

            //modelBuilder.Entity<Role>().HasData(
            //    new Role { Id = 1, Name = "Admin" },
            //    new Role { Id = 2, Name = "User" }
            //);

            //modelBuilder.Entity<Account>().HasData(
            //    new Account { Id = 1, FirstName = "Mr Mark", SecondName = "Job", AccountNumber = 111111111, 
            //                  Email = "mark@gmail.com", Address = "USA", InitialBalance = 200 }
            //);

            //modelBuilder.Entity<AccountRole>().HasData(
            //    new AccountRole { Id = 1, AccountId = 1, RoleId = 1 }    
            //);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; 
                                        Initial Catalog = BankingInternationalSystemsDb; 
                                        Integrated Security = True;";            

            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
