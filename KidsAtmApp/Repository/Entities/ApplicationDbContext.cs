
using KidsAtmApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace KidsAtmApp.Entities;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

   public ApplicationDbContext(){}

   public DbSet<UserAccount> UserAccount { get; set; }
   public DbSet<Transaction> Transaction { get; set; }
//setting up entity framework to connect with database for connection with database. 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json")
                                    .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);                       

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>()
                        .HasMany(u => u.Transaction)
                        .WithOne(t => t.UserAccount)
                        .HasForeignKey(u => u.TransactionId);
                        

   }

}
