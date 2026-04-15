using Viagem.Domain.Entities;
using Viagem.Domain.Interfaces;
using Viagem.Infrastructure.db;
using Microsoft.EntityFrameworkCore;

namespace Viagem.Infrastructure.Repositories;





public class ReembolsoRepository(ViagemDbContext context) : IReembolsoRepository
{
    
    
    
    
    private readonly ViagemDbContext _context = context;

    
    
    
    
    public async Task SalvarSolicitacao(SolicitacaoReembolso reembolso)
    {
        
        _context.Solicitacoes!.Add(reembolso);
        
        await _context.SaveChangesAsync();
    }

    
    
    
    
    
    public async Task<IEnumerable<SolicitacaoReembolso>> ObterTodos()
    {
        return await _context.Solicitacoes!.ToListAsync();
    }
}