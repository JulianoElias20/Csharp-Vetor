using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas pessoas você deseja calcular a média da altura: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];// Neste momentos instanciamos as caixinhas do vetor, que será onde ficará guardado os dados

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite as alturas ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;
            Console.WriteLine("A média é " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
