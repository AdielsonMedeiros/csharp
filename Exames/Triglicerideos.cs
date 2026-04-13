using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exame
{
    class Triglicerideos : Exame
    {
        public override void cadastrarExame()
        {
            base.cadastrarExame();
            Console.Write("Digite a quantidade de triglicerideos mg/dl: ");
            qntDeTriglicerideos = double.Parse(Console.ReadLine()!);
        }

        public override void mostrarResultado()
        {
            base.mostrarResultado();
            Console.Write($"Quantidade de Triglicerideos: {qntDeTriglicerideos} mg/dl | Classificação: {classificarResultado()} \n");
            
        }

        public override string classificarResultado()
        {
            if ( getIdade() <= 9 && qntDeTriglicerideos < 75)
            {
                return "BOM";
            } else if (getIdade() >= 10 && qntDeTriglicerideos <= 19 && qntDeTriglicerideos < 90)
            {
                return "BOM";
            } else if (getIdade() > 19 && getqntDeTriglicerideos() < 150)
            {
                return "BOM";
            } else
            {
                return "RUIM";
            }


            
            return resultado();


            
           
        }
    }
}