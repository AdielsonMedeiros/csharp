using Core.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Core.Ports.Outgoing;

public interface IProdutoRepository
{
    Task<Produto?> ObterPorId(int id);
    Task Atualizar(int id, int quantidade);
    Task<IEnumerable<Produto>> ObterTodos();
}


