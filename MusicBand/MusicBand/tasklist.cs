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
            // Chama o método WelcomeMessage e armazena o retorno na variável resposta
            string resposta = WelcomeMessage();
            switch (resposta)
            {
                case "1":
                    addTask();
                    break;
                    /*
                case "2":
                    removeTask();
                    break;
                case "3":
                    viewTasks();
                    break;
                case "4":
                    // Exit the program
                    Console.WriteLine("Saindo do programa...");
                    return; // Termina a execução do programa
                    */
                default:
                    Console.WriteLine("Valor inválido. Por favor, digite um valor entre 1 e 4.");
                    break;
            } 
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
    static void addTask()
    {
        Console.WriteLine("Digite sua nova tarefa, por favor.");
        Global.tarefa = Console.ReadLine();
        Global.tarefas.Add(Global.tarefa);
        MostrarTarefas();
    }
/*
    static void removeTask(){
        Console.WriteLine("nothing to do");
    }

    static void viewTasks(){
        Console.WriteLine("nothing to do...")
    }
*/
    static void MostrarTarefas()
    {
        Console.WriteLine("---- Lista de Tarefas ----");
        foreach (string item in Global.tarefas)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------");
    }
}
