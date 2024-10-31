//Utilizando array:
//Problema "numeros_pares"
//Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na
//tela todos os números pares, e também a quantidade de números pares. 

namespace NumerosParesArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, contPares;

            contPares = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES: ");

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    contPares++;
                    Console.Write(vet[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"QUANTIDADE DE PARES = {contPares}");
        }
    }
}
