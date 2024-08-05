void visor(){
Console.WriteLine("Seja bem vindo a tabuada SuperNumber!");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Escolha um número.");
Console.WriteLine("1  2  3  4  5  6  7  8  9  10");
}

void looping(){
    string multiplicador = Console.ReadLine();
    int multiplicadorNumbe = int.Parse(multiplicador);
    for(int contador = 1; contador <= 10; contador++){
        Console.WriteLine(multiplicadorNumbe + "x" + contador + "=" + (multiplicadorNumbe * contador));
    }
}

visor();
looping();










