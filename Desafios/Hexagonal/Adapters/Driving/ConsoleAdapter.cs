using Core.Ports.Incoming;
using Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapters.Driving;

public class ConsoleAdapter(IEstoqueService service) : IEstoqueService
{
    public async Task ExecutarMovimentacao(int produtoId, int quantidade)
    {
        await service.ExecutarMovimentacao(produtoId, quantidade);
    }

    public async Task<IEnumerable<Produto>> ListarEstoque() => await service.ListarEstoque();
}