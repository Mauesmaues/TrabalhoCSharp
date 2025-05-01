/*Cálculo de Fatorial com while
Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
while.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("O número deve ser positivo.");
            return;
        }

        int fatorial = 1;
        int i = numero;

        while (i > 1)
        {
            fatorial *= i;
            i--;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }
}
