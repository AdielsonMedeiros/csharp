using Domain;
using Domain.Models;


var carteira = new Carteira();

var petrobras = new Acao("Petrobras", 5000, DateTime.Now, "PETR4", 5500);
var tesouro = new RendaFixa("Tesouro Direto", 5000, DateTime.Now, 0.0241m);

carteira.AdicionarAtivo(petrobras);
carteira.AdicionarAtivo(tesouro);

foreach (var ativo in carteira.Ativos)
{
    string identificacao = (ativo is Acao acao) ? acao.Ticker : (ativo as AtivoBase)?.Nome ?? "Desconhecido";
    Console.WriteLine($"Ativo: {identificacao} | Lucro: {ativo.CalcularRendimento():C2}");
}

Console.WriteLine("---------------------------------------");
Console.WriteLine($"Saldo Total: {carteira.CalcularSaldoTotal() + carteira.CalcularLucroTotal():C2}");
Console.WriteLine($"Lucro Total: {carteira.CalcularLucroTotal():C2}");