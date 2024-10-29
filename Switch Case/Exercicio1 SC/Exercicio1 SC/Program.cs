int numero;
Console.Write("Digite um número para o dia da semana (entre 1 e 7): ");
numero = Convert.ToInt32(Console.ReadLine());

switch (numero) 
{
    case 1: Console.WriteLine("O dia é Domingo!");
    break;
    case 2:
        Console.WriteLine("O dia é Segunda-Feira!");
        break;
    case 3:
        Console.WriteLine("O dia é Terça-Feira!");
        break;
    case 4:
        Console.WriteLine("O dia é Quarta-Feira!");
        break;
    case 5:
        Console.WriteLine("O dia é Quinta-Feira!");
        break;
    case 6:
        Console.WriteLine("O dia é Sexta-Feira!");
        break;
    case 7:
        Console.WriteLine("O dia é Sábado!");
        break;
    default: Console.WriteLine("O número que você digitou é invalido");
        break;
         }