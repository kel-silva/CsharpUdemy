// See https://aka.ms/new-console-template for more information
Console.WriteLine("conversao de tipos!");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.14790m;

//string s1 = valorInt.ToString();
//string s2 = valorDouble.ToString();
//string s3 = valorDecimal.ToString();



//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToString(valorDouble));
Console.WriteLine(Convert.ToString(valorDecimal));


Console.ReadLine();
