using System;
using System.Globalization;

class Principal
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o seu peso: ");
        double peso = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Digite a sua altura: ");
        double altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double imc = peso / (altura * altura);

        Console.WriteLine($"\n Olá {nome}, seu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}");

    
        if (imc < 18.5)
        {
            Console.WriteLine(" Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine(" Peso normal");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc >= 30)
        {
            Console.WriteLine(" Obesidade");
        }
    }
}