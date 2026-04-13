using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;
using Domain.Models;

namespace Domain
{
    public class Carteira
    {
        private List<IInvestimento> _ativos = new List<IInvestimento>();
        public List<IInvestimento> Ativos => _ativos;


        public void AdicionarAtivo(IInvestimento ativo)
        {
            _ativos.Add(ativo);
        }

        public decimal CalcularSaldoTotal()
        {
            return _ativos.Sum(a => (a as AtivoBase)?.ValorInvestido ?? 0);
        }

        public decimal CalcularLucroTotal()
        {
           return _ativos.Sum(a => a.CalcularRendimento());
        }
        
    }
}