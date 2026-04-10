using Microsoft.EntityFrameworkCore; 
using Registro.Domain.Entities; 

namespace Registro.Domain.Interfaces;

public class DinosaurioDbContext : DbContext
{
    public DbSet<Dinosaurio> Dinosaurios { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dinosaurio>()
            .HasIndex(d => d.Username)
            .IsUnique();

        modelBuilder.Entity<Dinosaurio>()
            .HasIndex(d => d.Email)
            .IsUnique();
		
		modelBuilder.Entity<Dinosaurio>()
            .Property(a => a.Especie)
            .HasConversion<string>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = "server=204.168.212.239;database=andromeda;user=root;password=KJUdGn89Nyj3pwGWhs1vRghsshnDQL";

        options.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );
    }
}
