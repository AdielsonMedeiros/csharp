using Viagem.Domain.Entities;

namespace Viagem.Domain.Interfaces;


public interface IReembolsoRepository
{
    Task SalvarSolicitacao(SolicitacaoReembolso reembolso);
    Task<IEnumerable<SolicitacaoReembolso>> ObterTodos();
}