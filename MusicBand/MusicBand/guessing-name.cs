Random random= new Random();

int numeroAleatorio = random.Next(1, 101);

Console.WriteLine(numeroAleatorio);

do
{
    Console.WriteLine("Diga um número de 1 a 100");
    string resposta = Console.ReadLine();
    int respostaInt = int.Parse(resposta);
    if(respostaInt != numeroAleatorio){
        Console.WriteLine("PEEN, wrong number fella");
    }else{
        Console.WriteLine("Right number my man");
    }
    // Code block to be executed
} while ();
 




























