using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exame
{
    class Colesterol : Exame
    {
        private double ldl;
        private double hdl;
        public char risco;



        public override void cadastrarExame()
        {
            base.cadastrarExame();
            Console.Write("Digite o valor do LDL: ");
            ldl = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o valor do HDL: ");
            hdl = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o risco (B, M, A): ");
            risco = Console.ReadLine()![0];

            
        }

        public override void mostrarResultado()
        {
            Console.Write($"Nome: {nomePaciente} | Tipo Sanguineo: {tipoSanguineo} | Ano de Nascimento: {anoNascimento} | LDL: {ldl} | HDL: {hdl} | Risco: {risco} | Classificação: {classificarResultado()}\n");
        }

        
        public override string classificarResultado()
        {
            if(getIdade() <= 19 && hdl > 45)
            {
                return "HDL = 0";
            }
            else if(getIdade() <= 19 && hdl > 40)
            {
                return "HDL = 1";
            } else
            {
                return "HDL = RUIM";
            }
            if(risco == 'B' && ldl < 100)
            {
                return "LDL = 0";
            }
            else if(risco == 'B' && ldl >= 100 && ldl < 70)
            {
                return "LDL BOM";
            }
            else if(risco == 'A' && ldl >= 150 && ldl < 50)
            {
                return "LDL BOM";
            }else
            {
                return "LDL RUIM";
            }
            



        
        }
    }
}