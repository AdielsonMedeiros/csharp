using System.Collections.Generic;
using Core.Ports.Incoming;
using Core.Ports.Outgoing;
using System.Threading.Tasks;


namespace Core.Services;


public class EstoqueManager(IProdutoRepository repository) : IEstoqueService
{

    public async Task ExecutarMovimentacao(int produtoId, int quantidade)
    {
        var produto = await repository.ObterPorId(produtoId) 
            ?? throw new KeyNotFoundException("Produto não encontrado");


        produto.AjustarEstoque(quantidade);
        await repository.Atualizar(produtoId, quantidade);

        
    }
    


}
