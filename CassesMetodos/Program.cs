// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calsses e Metodos!");

Console.WriteLine("classe e Metodos");


int x = 100;

Pessoa p1 = new Pessoa();
p1.nome = "Mauricio";
p1.idade = 67;
p1.sexo = "masculino";


Console.WriteLine($"{p1.nome} , {p1.idade} , {p1.sexo} ");

Pessoa p2 = new Pessoa();
p2.nome = "Eliane";
p2.idade = 62;
p2.sexo = "Feminino";

Console.WriteLine($"{p2.nome} , {p2.idade} , {p2.sexo} ");

Console.ReadKey();


class Pessoa() {

    public string nome;
    public int idade;
    public string sexo;
}
