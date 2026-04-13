using System;
using System.Globalization;

namespace rota;
public class Rota
{
    public void planejarDia()
    {
        Console.Write("Digite o numero de rotas: ");
        int numRotas = int.Parse(Console.ReadLine()!); 

        double totalKm = 0;

        for(int i = 0; i < numRotas; i++)
        {
            Console.Write("Digite a quilometrage da rota " + (i + 1) + ": ");
            double km = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            totalKm += km;
        }    

        double consumo = totalKm / 2.5;

        Console.Write("Digite o valor do Litro do Diesel: ");
        double valorCombustivel = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double custoTotal = consumo * valorCombustivel; 

        Console.WriteLine($"Total de Km: {totalKm}");
        Console.WriteLine($"Consumo: {consumo}");
        Console.WriteLine($"Custo Total: {custoTotal}");
    }
}