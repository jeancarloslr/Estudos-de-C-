using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
         //creating the list(tasks)
         // Chama o método WelcomeMessage e armazena o retorno na variável resposta
        string resposta = WelcomeMessage();

        switch (resposta){
            case "1":
             addTask();
            break;
            case "2":
             //function removeTask
            break;
            case "3":
             //function view the list
             break;
            case "4":
             //function exit the program
             break;
            default:
            //type a true value.
            break;
        }
        
        // Exibe a resposta (opcional, dependendo do que você deseja fazer com a resposta)
        Console.WriteLine("Você escolheu: " + resposta);
    }

    // Método que exibe uma mensagem de boas-vindas e retorna a resposta do usuário
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

    static void addTask(){
        Console.WriteLine("Digite sua nova tarefa, por favor.");
        string taks = Console.ReadLine();  
    }
}
