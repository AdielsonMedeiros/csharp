using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Adapters.Driven;

public class EstoqueDbContext : DbContext
{
    public DbSet<Produto> Produtos => Set<Produto>();

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=estoque.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(p => p.Id);
        modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired();
    }
}

