using Core.Domain;
using Core.Ports.Outgoing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapters.Driven;

public class SqliteAdapter(EstoqueDbContext context) : IProdutoRepository
{
    private readonly EstoqueDbContext _context = context;

    public async Task<Produto?> ObterPorId(int id) => await _context.Produtos.FindAsync(id);
    
    public async Task Atualizar(int id, int quantidade)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if(produto != null)
        {
            produto.AjustarEstoque(quantidade);
            await _context.SaveChangesAsync();    
        }  
    }

    public async Task<IEnumerable<Produto>> ObterTodos() => await _context.Produtos.ToListAsync();
}
