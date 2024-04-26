global using Microsoft.EntityFrameworkCore;
using GameStore.Entity;
namespace GameStore.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
           base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=GameStore;Trusted_Connection=true;TrustServerCertificate=true");
        }
        
        public DbSet<Gaming> Gaming{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Genre>().HasData(
            new{Id = 1, Name ="Fighting"},
            new{Id = 2, Name ="Roleplaying"},
            new{Id = 3, Name="Sport"}
           );
        }
    }
    
}