using System.Transactions;
using KidsAtmApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

//namespace KidsAtmApp.Entities;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

   public ApplicationDbContext(){}

   public DbSet<UserAccount> Users { get; set; }
   public DbSet<Transaction> Transactions{ get; set; }
//setting up for connection with database. 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsetting.json")
                                    .Build();

            var connectionString = config.GetConnectionString("DefaulConnection");
            optionsBuilder.UseSqlServer(connectionString);                       

        }
    }

  /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>()
                        .HasMany(u => u.Transactions)
                        .HasOne((t => t.UserAccount)
                        .HasForeingK(u => u.)
                        

    }*/

}
