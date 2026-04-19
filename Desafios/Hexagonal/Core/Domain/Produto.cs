


using System;

namespace Core.Domain;

public class Produto(string nome, int quantidadeInicial)
{
    public int Id { get; set; }
    public string Nome { get; set; } = nome;
    public int Quantidade { get; set; } = quantidadeInicial;



    public void AdicionarEstoque(int qtd) => Quantidade += qtd;


    public void AjustarEstoque(int quantidade)
    {
        if (Quantidade + quantidade < 0){
            throw new InvalidOperationException("Estoque insuficiente");
        }
        Quantidade += quantidade;
    }
}