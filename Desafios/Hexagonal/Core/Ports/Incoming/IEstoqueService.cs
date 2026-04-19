using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Domain;

namespace Core.Ports.Incoming;

public interface IEstoqueService
{
    Task ExecutarMovimentacao(int produtoId, int quantidade);
    Task<IEnumerable<Produto>> ListarEstoque();
}