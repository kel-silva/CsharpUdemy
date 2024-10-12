// See https://aka.ms/new-console-template for more information
Console.WriteLine("comando Switch");

Console.WriteLine("informe o mes");

var mes = Console.ReadLine().ToLower();


switch (mes) {


    case "janeiro":
    case "marco":
     case "maio":
    case "julho":
    case "agosto":
    case "outubro":
   
    case "dezembro":
        Console.WriteLine("este mes tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("este mes tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("este mes tem 30 dias");
        break;

}
Console.WriteLine("\n fim do processamento");
Console.ReadKey();


