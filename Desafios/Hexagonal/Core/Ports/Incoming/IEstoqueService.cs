using System;
using System.Threading.Tasks;

namespace Core.Ports.Incoming;

public interface IEstoqueService
{
    Task ExecutarMovimentacao(int produtoId, int quantidade);
}