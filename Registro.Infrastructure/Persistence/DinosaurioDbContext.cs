using Microsoft.EntityFrameworkCore;
using Registro.Domain.Entities;

namespace Registro.Infrastructure.Persistence;

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
        var connectionString = "";

        options.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );
    }
}
