using Core.Domain;
using Core.Ports.Outgoing;
using Microsoft.EntityFrameworkCore;


public class SqliteAdapter : IProdutoRepository
{
    public async Task<Produto?> ObterPorId(int id) => await _context.Produtos.FindAsync(id);


    public async Task Atualizar(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();    
    }
    

}
