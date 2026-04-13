using System;
using Domain.Interfaces;


namespace Domain.Models
{
    public abstract class AtivoBase : IInvestimento
    {
        public string Nome { get; set; }
        public decimal ValorInvestido { get; set; }
        public DateTime DataCompra { get; set; }


        protected AtivoBase(string nome, decimal valorInvestido, DateTime dataCompra)
        {
            
            Nome = nome;
            ValorInvestido = valorInvestido;
            DataCompra = dataCompra;

        }

        public abstract decimal CalcularRendimento();
        
    }
}