/*Jogo da Adivinhação
Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
tentativa, informe se o número é maior ou menor. Conte o número de tentativas.*/

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa;
        int tentativas = 0;

        Console.WriteLine("Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior!");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor!");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
            }

        } while (tentativa != numeroSecreto);
    }
}
