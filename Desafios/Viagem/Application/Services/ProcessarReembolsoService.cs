using Viagem.Domain.Interfaces;
using Viagem.Domain.Entities;

namespace Viagem.Application.Services;





public class ProcessarReembolsoService
{
    private readonly IReembolsoRepository _repository;

    
    
    
    
    
    public ProcessarReembolsoService(IReembolsoRepository repository)
    {
        _repository = repository;
    }

    
    
    
    
    
    
    
    
    public async Task Executar(decimal valorTotal, string clienteNome, string descricao)
    {
        
        if (valorTotal > 1000)
            throw new Exception("Reembolso de alto valor necessita aprovação manual do diretor");

        
        var viagem = new SolicitacaoReembolso
        {
            ValorTotal = valorTotal,
            ClienteNome = clienteNome,
            Descricao = descricao
        };

        
        await _repository.SalvarSolicitacao(viagem);
        Console.WriteLine($"Reembolso de {valorTotal} para {viagem.ClienteNome} aprovado e salvo para {viagem.Descricao}");
    }

    
    
    
    
    public async Task<IEnumerable<SolicitacaoReembolso>> ListarTodos()
    {
        return await _repository.ObterTodos();
    }
}