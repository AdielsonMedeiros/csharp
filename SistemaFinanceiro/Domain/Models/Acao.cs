using System;

namespace Domain.Models
{
    public class Acao : AtivoBase
    {
        public string Ticker{get;set;}
        public decimal CotacaoAtual{get;set;}

        public Acao(string nome, decimal valorInvestido, DateTime dataCompra, string ticker, decimal cotacaoAtual):base(nome,valorInvestido,dataCompra)
        {
            Ticker = ticker;
            CotacaoAtual = cotacaoAtual;
        }
        public override decimal CalcularRendimento() => CotacaoAtual - ValorInvestido;
       
        

        
    }
}