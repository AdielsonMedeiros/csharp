using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exame
{
    abstract class Exame
    {

        public string? nomePaciente;
        public string? tipoSanguineo;
        public int anoNascimento;
        public double quantidadeMgPorL;
        public double qntDeTriglicerideos;


        public virtual void cadastrarExame()
        {
            Console.Write("Digite o nome do paciente: ");
            nomePaciente = Console.ReadLine()!;

            Console.Write("Digite o tipo sanguineo: ");
            tipoSanguineo = Console.ReadLine()!;

            Console.Write("Digite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine()!);

            
        }

        public virtual void mostrarResultado()
        {
            Console.WriteLine($"Nome: {nomePaciente} | Tipo Sanguineo: {tipoSanguineo} | Ano de Nascimento: {anoNascimento} \n");
            
        }

        public abstract string classificarResultado();

        public string resultado()
        {
            return classificarResultado();
        }
        

        public int getIdade()
        {
            return 2026 - anoNascimento;
        }


        public double getqntDeTriglicerideos()
        {
            return qntDeTriglicerideos;
        }

        public double getquantidadeMgPorL()
        {
            return quantidadeMgPorL;
        }
        
        




        
    }
}