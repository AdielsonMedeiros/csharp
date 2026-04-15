using Microsoft.EntityFrameworkCore;
using Viagem.Domain.Entities;

namespace Viagem.Infrastructure.db;





public class ViagemDbContext : DbContext
{
    
    
    
    
    public DbSet<SolicitacaoReembolso>? Solicitacoes { get; set; }

    
    
    
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=viagem.db");
    }
}