int dias;
string mes;
int ano;
Console.Write("Neste programa iremos saber quantos dias há no mês.\nDigite o ano: ");
ano = Convert.ToInt32(Console.ReadLine());
if (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
{
    Console.Write("Digite o nome do mês: ");
    mes = Convert.ToString(Console.ReadLine());
    switch (mes)
    {
        case "Janeiro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "janeiro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Fevereiro":
            Console.WriteLine($"O mês de {mes} tem 29 dias!");
            break;
        case "fevereiro":
            Console.WriteLine($"O mês de {mes} tem 29 dias!");
            break;
        case "Março":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "março":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Abril":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "abril":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Maio":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "maio":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Junho":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "junho":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Julho":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "julho":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Agosto":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "agosto":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Setembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "setembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Outubro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "outubro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Novembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "novembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Dezembro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "dezembro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
    }
}
else
{
    Console.Write("Digite o nome do mês: ");
    mes = Convert.ToString(Console.ReadLine());
    switch (mes)
    {
        case "Janeiro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "janeiro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Fevereiro":
            Console.WriteLine($"O mês de {mes} tem 28 dias!");
            break;
        case "fevereiro":
            Console.WriteLine($"O mês de {mes} tem 28 dias!");
            break;
        case "Março":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "março":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Abril":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "abril":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Maio":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "maio":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Junho":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "junho":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Julho":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "julho":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Agosto":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "agosto":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Setembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "setembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Outubro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "outubro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "Novembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "novembro":
            Console.WriteLine($"O mês de {mes} tem 30 dias!");
            break;
        case "Dezembro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
        case "dezembro":
            Console.WriteLine($"O mês de {mes} tem 31 dias!");
            break;
    }
}
Console.ReadKey();
