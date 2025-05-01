/* Lista de Tarefas (To-Do List)
Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas
inseridas. Use List<string> e ofereça uma opção para marcar tarefas como
concluídas.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluida = new List<bool>();
        int opcao;
        do
        {
            Console.WriteLine("\nLista de Tarefas");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a nova tarefa: ");
                    tarefas.Add(Console.ReadLine());
                    concluida.Add(false);
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2:
                    Console.WriteLine("\nTarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluida[i] ? "[✔]" : "[ ]";
                        Console.WriteLine($"{status} {i + 1}. {tarefas[i]}");
                    }
                    break;

                case 3:
                    Console.Write("Digite o número da tarefa concluída: ");
                    int indice = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (indice >= 0 && indice < concluida.Count)
                    {
                        concluida[indice] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido!");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 4);

        Console.WriteLine("Programa encerrado.");
    }
}
