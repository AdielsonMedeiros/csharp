namespace Viagem.Domain.Entities;


public class SolicitacaoReembolso
{
    public string? ClienteNome { get; set; }
    public decimal ValorTotal { get; set; }
    public string? Descricao { get; set; }
    
    public int Id { get; set; }

    
    public SolicitacaoReembolso() { }

    
    public SolicitacaoReembolso(string nome, decimal valorTotal, string descricao)
    {
        ClienteNome = nome;
        ValorTotal = valorTotal;
        Descricao = descricao;
    }
}