using System;
using System.Collections.Generic;
class Program
{
    public static class Global
    {
        public static string tarefa = ""; // Inicialização do campo tarefa
        public static List<string> tarefas = new List<string>();
    }
    public static void Main()
    {
        string resposta;
        do
        {
            // Chama o método WelcomeMessage e armazena o retorno na variável resposta
            resposta = WelcomeMessage();
            switch (resposta)
            {
                case "1":
                    AddTask();
                    break;
            case "2":
                removeTask();
                break;
            case "3":
                MostrarTarefas();
                break;
            case "4":
                // Exit the program
                Console.WriteLine("Saindo do programa...");
                return; // Termina a execução do programa
                default:
                    Console.WriteLine("Valor inválido. Por favor, digite um valor entre 1 e 4.");
                    break;
            }
        }while(resposta != "4");
    }
    public static string WelcomeMessage() 
    {
        Console.WriteLine("----------WELCOME TO TASK LIST---------");
        Console.WriteLine("Enter 1 to add a new task");
        Console.WriteLine("Enter 2 to remove a task");
        Console.WriteLine("Enter 3 to view the list");
        Console.WriteLine("Enter 4 to exit the program");
        string resposta = Console.ReadLine();
        return resposta;
    }
    static void AddTask()
    {
        limparConsol();
        Console.WriteLine("Digite sua nova tarefa, por favor.");
        Global.tarefa = Console.ReadLine();
        Global.tarefas.Add(Global.tarefa);
    }
    static void removeTask(){
        int contador = 0;
        string numeroIndex;
        Console.WriteLine("Qual tarefa você deseja apagar?");
        foreach (string item in Global.tarefas)
        {
            Console.WriteLine(contador + " " + item);
            contador++;
        }
        numeroIndex = Console.ReadLine();
        int numeroIndexinteira = int.Parse(numeroIndex);
        Global.tarefas.RemoveAt(numeroIndexinteira);
    }
    static void MostrarTarefas()
    {
        limparConsol();
        Console.WriteLine("---- Lista de Tarefas ----");
        foreach (string item in Global.tarefas)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------");
    }
    static void limparConsol()
    {
        Console.Clear();
    }
}
