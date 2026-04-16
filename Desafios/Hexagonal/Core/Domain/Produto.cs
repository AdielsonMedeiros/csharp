


using System;

namespace Core.Domain;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        Quantidade = quantidadeInicial;
    }


    public void AdicionarEstoque(int qtd) => Quantidade += qtd;


    public void AjustarEstoque(int quantidade)
    {
        if (Quantidade + quantidade < 0){
            throw new InvalidOperationException("Estoque insuficiente");
        }
        Quantidade += quantidade;
    }
}