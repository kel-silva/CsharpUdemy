// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operador Uniario e Ternario");

int positivo = 1;
int resultado;

resultado= +positivo;
Console.WriteLine(resultado);

Console.WriteLine("oerador uriario e ternario");

Console.WriteLine("informe o numero: \n");

//operador uniario
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"o negativo de {n} e  {-n}");


Console.ReadKey();

// oeradores ternario

Console.WriteLine("informe a temperatura");
var temp = Convert.ToInt32(Console.ReadLine());

var resultado1 = temp>27? " Quente ": " Normal ";

Console.WriteLine($"o tempo esta{resultado1}");
