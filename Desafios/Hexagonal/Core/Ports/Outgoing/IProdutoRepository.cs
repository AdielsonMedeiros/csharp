using Core.Domain;
using System.Threading.Tasks;

namespace Core.Ports.Outgoing;


public interface IProdutoRepository
{
    Task<Produto?> ObterPorId(int id);
    Task AtualizarEstoque(int id, int quantidade);
}


