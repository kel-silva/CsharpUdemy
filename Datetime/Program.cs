// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hora e Data Atual ");
DateTime  DataAtual = DateTime.Now;

Console.WriteLine(DataAtual);

//extrar iformacoes de data atual


Console.WriteLine("Extraindo informacoes de data struct C@");

DateTime hoje = DateTime.Now;
Console.WriteLine($"Hoje :{hoje}\n");

//Console.WriteLine(hoje.Year);
//Console.WriteLine(hoje.Month);
//Console.WriteLine(hoje.Day);
//Console.WriteLine(hoje.Hour);
//Console.WriteLine(hoje.Minute);
//Console.WriteLine(hoje.Millisecond);
//Console.ReadKey();


/// adiconando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(5));
Console.WriteLine(hoje.AddHours(5));
Console.WriteLine(hoje.AddYears(10));

///obter o dia da seman e o ano
///
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);



