using BankingInternationalSystemsApp.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Database
{
    public class BisContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<WithdrawAccount> WithdrawAccounts {  get; set; }   
        public DbSet<LodgeAccount> LodgeAccounts {  get; set; }
        public DbSet<BankService> BankServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(a => new { a.AccountNumber, a.Email }).IsUnique();
            modelBuilder.Entity<BankService>().HasIndex(bs => bs.Name).IsUnique();
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
