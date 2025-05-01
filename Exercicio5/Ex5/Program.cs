/*Verificador de Palíndromos
Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
(lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower().Replace(" ", "").Replace("-", "");

        int tamanho = entrada.Length;
        bool ehPalindromo = true;

        for (int i = 0; i < tamanho / 2; i++)
        {
            if (entrada[i] != entrada[tamanho - 1 - i])
            {
                ehPalindromo = false;
                break;
            }
        }

        Console.WriteLine(ehPalindromo ? "É um palíndromo!" : "Não é um palíndromo.");
    }
}
