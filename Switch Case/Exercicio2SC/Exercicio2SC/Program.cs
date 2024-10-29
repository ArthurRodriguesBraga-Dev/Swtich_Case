char letra;
Console.Write("Digite uma letra: ");
letra = Convert.ToChar(Console.ReadLine());
switch (letra)
{
    case 'a':
    case 'A':
    case 'e':
    case 'E':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'u':
    case 'U':
        Console.WriteLine($"A letra {letra} é uma Vogal");
        break;
    default: Console.WriteLine($"A letra {letra} é uma Consoante");
        break;
}
Console.ReadKey();