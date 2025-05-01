/*Conversor de Temperaturas com Menu
Crie um menu com as opções:
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Use switch e while para manter o menu ativo até o usuário sair.*/

using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\nConversor de Temperaturas");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Resultado: {celsius}°C = {fahrenheit}°F");
                    break;
                    
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Resultado: {fahrenheit}°F = {celsius}°C");
                    break;
                    
                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 3);

        Console.WriteLine("Programa encerrado.");
    }
}
