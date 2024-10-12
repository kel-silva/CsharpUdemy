// See https://aka.ms/new-console-template for more information
Console.WriteLine("instrucao for ");


int resultado, numero;

Console.WriteLine("informe o numero inteiro");
numero = Convert.ToInt32(Console.ReadLine());



for (int i = 1; i < 10; i++)
{
    resultado = numero * i;
    Console.WriteLine(numero + " x " + 1 +" = "+ resultado);
}
Console.WriteLine("fim do processamento ");
Console.ReadKey();