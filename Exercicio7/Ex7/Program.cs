/*Soma de Números Pares de um Array
Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas
dos números pares*/


using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int somaPares = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }

        Console.WriteLine($"A soma dos números pares é: {somaPares}");
    }
}
