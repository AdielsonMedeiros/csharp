using System;

namespace Domain.Models
{
    public class RendaFixa : AtivoBase
    {

        public decimal TaxaAnual { get; set; }

        public RendaFixa(string nome, decimal valor, DateTime data, decimal taxaAnual) 
            : base(nome, valor, data)
        {
            TaxaAnual = taxaAnual;
        }

        


        public override decimal CalcularRendimento()
        {
            return ValorInvestido * TaxaAnual;
        }
        
    }
}