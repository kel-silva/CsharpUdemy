// See https://aka.ms/new-console-template for more information
Console.WriteLine("estrutura de repeticao");


int i = 1;

repetir:
Console.WriteLine($"i = {i}");
i++;


if (i <= 10) {
    goto repetir;
    Console.WriteLine("fim do processamento");
    Console.ReadKey();
}
