using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace exame
{
    class Glicemia : Exame
    {

    public override void cadastrarExame()
        {
            base.cadastrarExame();
            Console.Write("Digite a quantidade de glicose mg/dl: ");
            quantidadeMgPorL = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        }

    public override void mostrarResultado()
        {
            Console.Write($"Nome: {nomePaciente} | Tipo Sanguineo: {tipoSanguineo} | Ano de Nascimento: {anoNascimento} | Quantidade de Glicose: {quantidadeMgPorL} mg/dl | Classificação: {classificarResultado()}\n");
        
        }

    public override string classificarResultado()
        {
            if(quantidadeMgPorL < 100)
            {
                return "Normal";
            }
            else if(quantidadeMgPorL >= 100 && quantidadeMgPorL < 126)
            {
                return "Alterado";
            }
            else
            {
                return "Diabetes";
            }
        }
        
    }
}