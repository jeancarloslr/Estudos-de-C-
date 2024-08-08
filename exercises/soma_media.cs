int media;
int valorAcumulado = 0;
int cont = 1;
Console.WriteLine("Seja bem vindo a somatória de valores, comece inserindo quantos números deseja somar.");
string QuantidadeN = Console.ReadLine();
int QuantidadeConvertida = Convert.ToInt32(QuantidadeN);

while(cont <= QuantidadeConvertida){
    
    Console.WriteLine($"Digite o {cont} valor: ");
    string valorSomado = Console.ReadLine();
    int valorSomadoConvert = Convert.ToInt32(valorSomado);
    valorAcumulado += valorSomadoConvert;
    if(cont == QuantidadeConvertida){
        break;
    }
    cont++;

}; 

Console.WriteLine($"o valor total é {valorAcumulado}");
media = valorAcumulado/cont;
Console.WriteLine($"A média de {valorAcumulado} é {media}");
