// See https://aka.ms/new-console-template for more information
Console.WriteLine("operadores aritimeticos!");

Console.WriteLine("informe o valor de x");


int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" a raiz quadrada de X e =  {Math.Sqrt}");
Console.WriteLine($" a potencia  de X elvado a y =  {Math.Pow(x,y)}");
Console.WriteLine($" vALOR MINIMO de X e y =  {Math.Min(x,y)}");
Console.WriteLine($" vALOR maximo de X e y =  {Math.Max(x,y)}");
Console.WriteLine($" Conseno  de X  =  {Math.Cos(x)}");
Console.WriteLine($" seno  de X  =  {Math.Sin(x)}");
Console.WriteLine($" exponencial  de X  =  {Math.Exp(x)}");

Console.ReadKey();

//Console.WriteLine($"o resultado de Y + X e ; {x + y}");
//Console.WriteLine($"o resultado de Y - X e ; {x - y}");
//Console.WriteLine($"o resultado de Y * X e ; {x * y}");
//Console.WriteLine($"o resultado de Y resto da divisao  X e ; {x % y}");
//double divisao = (double)x / y;
//Console.WriteLine($"o resultado de Y resto da divisao  X e ; {divisao}");

