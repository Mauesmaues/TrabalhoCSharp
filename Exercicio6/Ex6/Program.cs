/*Cadastro Simples de Produtos
Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
Quantidade).*/

using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nCadastro do produto {i + 1}:");

            produtos[i] = new Produto();

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nLista de Produtos Cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}, Valor Total em Estoque: {produto.ValorTotalEmEstoque():F2}");
        }
    }
}