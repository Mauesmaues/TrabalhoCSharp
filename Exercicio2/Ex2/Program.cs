/*Tabuada Completa com Laço
Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
utilizando um for.*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro para saber a tabuada:");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {numero} = {i * numero}");
        }
    }
}

